using System.Runtime.InteropServices;

namespace Clockwork.Audio;

public static class AudioDevice
{
	[DllImport(Engine.raylibLibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "InitAudioDevice")]
	internal static extern void Initialize();

	[DllImport(Engine.raylibLibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "CloseAudioDevice")]
	internal static extern void Close();

	[DllImport(Engine.raylibLibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetMasterVolume")]
	private static extern void SetVolume(float volume);
	public static float Volume { set => SetVolume(value); }

	public static void Restart()
	{
		Close();
		Initialize();
	}
}
