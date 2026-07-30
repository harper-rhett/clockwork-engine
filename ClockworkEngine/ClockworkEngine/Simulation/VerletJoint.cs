using Clockwork.Graphics;
using System.Numerics;
using Clockwork.Shapes;

namespace Clockwork.Simulation;

public class VerletJoint : CircleShape
{
	private Vector2 lastPosition;

	public Vector2 Velocity
	{
		get => (Position - lastPosition) / FrameTime;
		set => lastPosition = Position - value * FrameTime;
	}
	private float inverseDamping = 1;
	public float Damping
	{
		get => 1f - inverseDamping;
		set => inverseDamping = float.Clamp(1f - value, 0f, 1f);
	}

	public VerletJoint(float radius, Color color) : base(radius, color)
	{

	}

	public override void OnUpdate()
	{
		// Update base
		base.OnUpdate();
		if (FrameTime == 0) return;

		// Cache velocity
		Vector2 velocity = Velocity;

		// Damping
		if (inverseDamping < 1f) velocity *= float.Pow(inverseDamping, FrameTime);

		// Update position
		lastPosition = Position;
		Position = Position + velocity * FrameTime;
	}

	public override void OnAddedToScene()
	{
		lastPosition = Position;
	}

	public void AddVelocity(Vector2 velocity)
	{
		lastPosition -= velocity * FrameTime;
	}
}
