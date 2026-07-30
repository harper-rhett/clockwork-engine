namespace Clockwork.Utilities;

public class FireTimer : Entity
{
	public float CooldownTime;
	private float backloggedTime;
	private bool isFiring;
	public delegate void FiredDelegate();
	public event FiredDelegate Fired;

	public FireTimer(float cooldownTime)
	{
		CooldownTime = cooldownTime;
		backloggedTime = cooldownTime;
	}

	public override void OnUpdate()
	{
		if (!isFiring) return;

		backloggedTime += FrameTime;
		int backloggedActions = (int)float.Floor(backloggedTime / CooldownTime);
		backloggedTime -= backloggedActions * CooldownTime;

		for (int actionNumber = 1; actionNumber <= backloggedActions; actionNumber++) Fire();
	}

	public override void OnDraw() { }

	public void Start()
	{
		isFiring = true;
	}

	public void Stop()
	{
		isFiring = false;
	}

	private void Fire()
	{
		OnFired();
		Fired?.Invoke();
	}

	protected virtual void OnFired() { }
}