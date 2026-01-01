namespace Clockwork.Audio;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct Music : IDisposable
{
	public AudioStream Stream;
	public uint FrameCount;
	private byte looping;
	public bool Looping
	{
		get => looping != 0;
		set => looping = (byte)(value ? 1 : 0);
	}
	public int CtxType;
	public void* CtxData;

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LoadMusicStream")]
	public static extern Music Load(string filePath);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IsMusicValid")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool IsThisValid(Music music);
	public bool IsValid => IsThisValid(this);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "UnloadMusicStream")]
	private static extern void Unload(Music music);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "PlayMusicStream")]
	private static extern void Play(Music music);
	public void Play() => Play(this);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IsMusicStreamPlaying")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool IsThisPlaying(Music music);
	public bool IsPlaying => IsThisPlaying(this);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "UpdateMusicStream")]
	private static extern void Update(Music music);
	public void Update() => Update(this);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "StopMusicStream")]
	private static extern void Stop(Music music);
	public void Stop() => Stop(this);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "PauseMusicStream")]
	private static extern void Pause(Music music);
	public void Pause() => Pause(this);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ResumeMusicStream")]
	private static extern void Resume(Music music);
	public void Resume() => Resume(this);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SeekMusicStream")]
	private static extern void SetPosition(Music music, float seconds);
	public float Position { set => SetPosition(this, value); }

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetMusicVolume")]
	private static extern void SetVolume(Music music, float volume);
	public float Volume { set => SetVolume(this, value); }

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetMusicPitch")]
	private static extern void SetPitch(Music music, float pitch);
	public float Pitch { set => SetPitch(this, value); }

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetMusicPan")]
	private static extern void SetStereoPan(Music music, float pan);
	public float StereoPan { set => SetStereoPan(this, value); }

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetMusicTimeLength")]
	private static extern float GetDuration(Music music);
	public float Duration => GetDuration(this);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetMusicTimePlayed")]
	private static extern float GetTimePlayed(Music music);
	public float TimePlayed => GetTimePlayed(this);

	public void Dispose()
	{
		Unload(this);
	}
}
