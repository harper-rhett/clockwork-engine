using System.Runtime.InteropServices;
using System;

namespace Clockwork.Windowing;

// Adapted from https://github.com/nedoxff/TinyDialogsNet

public static class FileDialogs
{
	private const char MultipleFileSeparator = '|';

	private static string PointerToString(IntPtr pointer)
	{
		return OperatingSystem.IsWindows()
			? Marshal.PtrToStringUni(pointer)
			: Marshal.PtrToStringUTF8(pointer);
	}

	private static void CheckTitle(string title)
	{
		if (title.Contains('\n') || title.Contains('\t') || title.Contains('\'') || title.Contains('"'))
			throw new ArgumentException(
				@"The title is ill-formed. It cannot contain new-line (\n) and tab (\t) escape characters, nor quotes (both single and double).",
				nameof(title)
			);
	}

	public static bool TrySaveFile(string title, out string filePath, string defaultPath = "", string[] fileExtensions = default, string filterName = default)
	{
		CheckTitle(title);

		nint response = OperatingSystem.IsWindows()
			? SaveFileWindows(title, defaultPath, fileExtensions.Length, fileExtensions, filterName)
			: SaveFileLinux(title, defaultPath, fileExtensions.Length, fileExtensions, filterName);

		bool didSelect = response != IntPtr.Zero;
		filePath = didSelect ? PointerToString(response) : null;

		return didSelect;
	}

	public static bool TrySelectFile(string title, out string[] filePaths, string defaultPath = "", bool allowMultipleSelections = false, string[] fileExtensions = default, string filterName = default)
	{
		CheckTitle(title);

		nint response = OperatingSystem.IsWindows()
			? SelectFileWindows(title, defaultPath, fileExtensions.Length, fileExtensions, filterName, allowMultipleSelections ? 1 : 0)
			: SelectFileLinux(title, defaultPath, fileExtensions.Length, fileExtensions, filterName, allowMultipleSelections ? 1 : 0);

		bool didSelect = response != IntPtr.Zero;
		filePaths = didSelect ? PointerToString(response).Split(MultipleFileSeparator) : [];

		return didSelect;
	}

	public static bool TrySelectFolder(string title, out string folderPath, string defaultPath = "")
	{
		CheckTitle(title);

		nint response = OperatingSystem.IsWindows()
			? SelectFolderWindows(title, defaultPath)
			: SelectFolderLinux(title, defaultPath);

		bool didSelect = response != IntPtr.Zero;
		folderPath = didSelect ? PointerToString(response) : null;

		return didSelect;
	}

	[DllImport(Engine.tinyDialogsName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, EntryPoint = "tinyfd_saveFileDialog")]
	internal static extern IntPtr SaveFileLinux(string title, string defaultPathAndFile, int numOfFilterPatterns, string[] filterPatterns, string singleFilterDescription);

	[DllImport(Engine.tinyDialogsName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, EntryPoint = "tinyfd_openFileDialog")]
	internal static extern IntPtr SelectFileLinux (string title, string defaultPathAndFile, int numOfFilterPatters, string[] filterPatterns, string singleFilterDescription, int allowMultipleSelections);

	[DllImport(Engine.tinyDialogsName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, EntryPoint = "tinyfd_selectFolderDialog")]
	internal static extern IntPtr SelectFolderLinux(string title, string defaultPathAndFile);

	[DllImport(Engine.tinyDialogsName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl, EntryPoint = "tinyfd_saveFileDialogW")]
	internal static extern IntPtr SaveFileWindows(string title, string defaultPathAndFile, int numOfFilterPatterns, string[] filterPatterns, string singleFilterDescription);

	[DllImport(Engine.tinyDialogsName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl, EntryPoint = "tinyfd_openFileDialogW")]
	internal static extern IntPtr SelectFileWindows(string title, string defaultPathAndFile, int numOfFilterPatterns, string[] filterPatterns, string singleFilterDescription, int allowMultipleSelections);

	[DllImport(Engine.tinyDialogsName, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl, EntryPoint = "tinyfd_selectFolderDialogW")]
	internal static extern IntPtr SelectFolderWindows(string title, string defaultPathAndFile);
}
