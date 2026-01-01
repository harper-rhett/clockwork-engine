namespace Clockwork.Audio;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct Sound : IDisposable
{
	public AudioStream Stream;
	public uint FrameCount;

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LoadSound")]
	public static extern Sound Load(string filePath);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IsSoundValid")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool IsThisValid(Sound sound);
	public bool IsValid => IsThisValid(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "UnloadSound")]
	private static extern void Unload(Sound sound);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "PlaySound")]
	private static extern void Play(Sound sound);
	public void Play() => Play(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "StopSound")]
	private static extern void Stop(Sound sound);
	public void Stop() => Stop(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "PauseSound")]
	private static extern void Pause(Sound sound);
	public void Pause() => Pause(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ResumeSound")]
	private static extern void Resume(Sound sound);
	public void Resume() => Resume(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IsSoundPlaying")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool IsThisPlaying(Sound sound);
	public bool IsPlaying => IsThisPlaying(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetSoundVolume")]
	private static extern void SetVolume(Sound sound, float volume);
	public float Volume { set => SetVolume(this, value); }

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetSoundPitch")]
	private static extern void SetPitch(Sound sound, float pitch);
	public float Pitch { set => SetPitch(this, value); }

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetSoundPan")]
	private static extern void SetStereoPan(Sound sound, float pan);
	public float StereoPan { set => SetStereoPan(this, value); }

	public void Dispose()
	{
		Unload(this);
	}
}