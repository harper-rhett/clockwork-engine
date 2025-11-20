namespace HarpEngine.Animation;

public class Transform2DEaser : Easer
{
	private Transform2D transform;

	// Original transform values
	private Vector2 originalWorldPosition;
	private Vector2 originalLocalPosition;
	private float originalWorldRotation;
	private float originalLocalRotation;

	// Target transform values
	public Vector2 TargetWorldPosition;
	public Vector2 TargetLocalPosition;
	public float TargetWorldRotation;
	public float TargetLocalRotation;

	public Transform2DEaser(Transform2D transform, float easeSeconds) : base(easeSeconds)
	{
		this.transform = transform;
		SerializeTransform();
	}

	public void SerializeTransform()
	{
		originalWorldPosition = transform.WorldPosition;
		originalLocalPosition = transform.LocalPosition;
		originalWorldRotation = transform.WorldRotation;
		originalLocalRotation = transform.LocalRotation;
	}

	protected override void OnEasing()
	{
		if (transform.Parent is not null)
		{
			transform.WorldPosition = EaseVector2(originalWorldPosition, TargetWorldPosition);
			transform.LocalPosition = EaseVector2(originalLocalPosition, TargetLocalPosition);
			transform.WorldRotation = EaseFloat(originalWorldRotation, TargetWorldRotation);
			transform.LocalRotation = EaseFloat(originalLocalRotation, TargetLocalRotation);
		}
		else
		{
			transform.LocalPosition = EaseVector2(originalLocalPosition, TargetWorldPosition);
			transform.LocalRotation = EaseFloat(originalLocalRotation, TargetWorldRotation);
		}
	}
}
