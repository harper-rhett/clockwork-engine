using System;
using System.Runtime.InteropServices;

namespace Clockwork.Windowing;

// Raylib's FilePathList
[StructLayout(LayoutKind.Sequential)]
internal unsafe struct ItemPathList : IDisposable
{
	public uint Count;
	public byte** Paths;

	public string this[uint index]
	{
		get
		{
			if (index >= 0 && index < Count)
			{
				return Marshal.PtrToStringUTF8((IntPtr)Paths[index]);
			}
			else
			{
				throw new IndexOutOfRangeException();
			}
		}
	}

	public readonly string[] ToArray()
	{
		string[] filePaths = new string[Count];
		for (uint index = 0; index < Count; index++)
		{
			filePaths[index] = Marshal.PtrToStringUTF8((IntPtr)Paths[index]);
		}
		return filePaths;
	}

	[DllImport(Engine.raylibLibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "UnloadDroppedFiles")]
	private static extern void Unload(ItemPathList itemPathList);

	public void Dispose()
	{
		Unload(this);
	}
}