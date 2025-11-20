namespace HarpEngine.Audio;

public static class AudioDevice
{
	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "InitAudioDevice")]
	internal static extern void Initialize();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "CloseAudioDevice")]
	internal static extern void Close();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetMasterVolume")]
	private static extern void SetVolume(float volume);
	public static float Volume { set => SetVolume(value); }

	public static void Restart()
	{
		Close();
		Initialize();
	}
}
