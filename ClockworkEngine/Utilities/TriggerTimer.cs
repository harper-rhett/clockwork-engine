namespace Clockwork.Utilities;

public class TriggerTimer : Entity
{
	private float triggerSeconds;
	private float startTime;
	private float triggerTime = float.MaxValue;
	private bool isTriggered;
	public bool RemoveOnTriggered = true;
	public delegate void TriggeredDelegate();
	public event TriggeredDelegate Triggered;

	public TriggerTimer(float triggerSeconds)
	{
		this.triggerSeconds = triggerSeconds;
	}

	public override void OnUpdate()
	{
		if (isTriggered) return;

		if (Scene.Time >= triggerTime) Trigger();
	}

	public void Start()
	{
		startTime = Scene.Time;
		triggerTime = startTime + triggerSeconds;
		isTriggered = false;
	}

	public void Skip()
	{
		triggerTime = Scene.Time;
	}

	protected void Trigger()
	{
		isTriggered = true;
		Triggered?.Invoke();
		if (RemoveOnTriggered) Remove();
		OnTriggered();
	}

	public virtual void OnTriggered() { }
}