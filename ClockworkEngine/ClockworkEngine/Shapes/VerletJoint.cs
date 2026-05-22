using Clockwork.Graphics;
using System.Numerics;

namespace Clockwork.Shapes;

public class VerletJoint : CircleShape
{
	private Vector2 lastPosition;

	public Vector2 Velocity
	{
		get => (Position - lastPosition) / FrameTime;
		set => lastPosition = Position - value * FrameTime;
	}

	public VerletJoint(float radius, Color color) : base(radius, color)
	{

	}

	public override void OnUpdate()
	{
		base.OnUpdate();
		if (FrameTime == 0) return;

		Vector2 velocity = Velocity;
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
