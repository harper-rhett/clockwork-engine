using Clockwork.Graphics;
using System.Numerics;

namespace Clockwork.Shapes;

public class VerletJoint : CircleShape
{
	private Vector2 lastPosition;

	public VerletJoint(float radius, Color color) : base(radius, color)
	{

	}

	public override void OnUpdate()
	{
		base.OnUpdate();
		if (Engine.FrameTime == 0) return;

		Vector2 velocity = (Position - lastPosition) / Engine.FrameTime;
		lastPosition = Position;
		Position = Position + velocity * Engine.FrameTime;
	}

	public override void OnAddedToScene()
	{
		lastPosition = Position;
	}

	public void AddVelocity(Vector2 velocity)
	{
		lastPosition -= velocity * Engine.FrameTime;
	}

	public void SetVelocity(Vector2 velocity)
	{
		lastPosition = Position - velocity * Engine.FrameTime;
	}
}
