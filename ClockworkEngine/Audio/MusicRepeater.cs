namespace Clockwork.Audio;

public class MusicRepeater : Entity
{
	private Music music;
	private bool isStarted;
	private bool isPaused;

	public MusicRepeater(Music music)
	{
		this.music = music;
	}

	public override void OnUpdate()
	{
		if (isStarted && !isPaused) music.Update();
	}

	public void Start()
	{
		music.Play();
		isStarted = true;
	}

	public void Stop()
	{
		music.Stop();
		isStarted = false;
	}

	public void Pause()
	{
		music.Pause();
		isPaused = true;
	}

	public void Resume()
	{
		music.Resume();
		isPaused = false;
	}
}
