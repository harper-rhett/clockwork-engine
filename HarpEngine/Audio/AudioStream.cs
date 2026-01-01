namespace Clockwork.Audio;

[StructLayout(LayoutKind.Sequential)]
public struct AudioStream : IDisposable
{
	public IntPtr Buffer;
	public IntPtr Processor;
	public uint SampleRate;
	public uint SampleSize;
	public uint Channels;

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IsAudioStreamValid")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool IsThisValid(AudioStream audioStream);
	public bool IsValid => IsThisValid(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "UnloadAudioStream")]
	private static extern void Unload(AudioStream audioStream);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IsAudioStreamProcessed")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool IsThisProcessed(AudioStream audioStream);
	public bool IsProcessed => IsThisProcessed(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "PlayAudioStream")]
	private static extern void Play(AudioStream audioStream);
	public void Play() => Play(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "PauseAudioStream")]
	private static extern void Pause(AudioStream audioStream);
	public void Pause() => Pause(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ResumeAudioStream")]
	private static extern void Resume(AudioStream audioStream);
	public void Resume() => Resume(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IsAudioStreamPlaying")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool IsThisPlaying(AudioStream audioStream);
	public bool IsPlaying => IsThisPlaying(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "StopAudioStream")]
	private static extern void Stop(AudioStream audioStream);
	public void Stop() => Stop(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetAudioStreamVolume")]
	private static extern void SetVolume(AudioStream audioStream, float volume);
	public float Volume { set => SetVolume(this, value); }

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetAudioStreamPitch")]
	private static extern void SetPitch(AudioStream audioStream, float pitch);
	public float Pitch { set => SetPitch(this, value); }

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetAudioStreamPan")]
	private static extern void SetStereoPan(AudioStream audioStream, float pan);
	public float StereoPan { set => SetStereoPan(this, value); }

	public void Dispose()
	{
		Unload(this);
	}
}
