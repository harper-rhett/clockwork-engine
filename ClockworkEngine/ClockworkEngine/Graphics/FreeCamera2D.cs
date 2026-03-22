using Clockwork.Input;
using System.Numerics;

namespace Clockwork.Graphics;

public class FreeCamera2D : Camera2D
{
	public float MovementSpeed = 50f;

	public FreeCamera2D() : base()
	{

	}

	public override void OnUpdate()
	{
		bool isSprinting = Keyboard.IsKeyDown(KeyboardKey.LeftShift);

		Move(isSprinting);

		base.OnUpdate();
	}

	private void Move(bool isSprinting)
	{
		Vector2 direction = Vector2.Zero;

		if (Keyboard.IsKeyDown(KeyboardKey.W)) direction += Transform.Up;
		else if (Keyboard.IsKeyDown(KeyboardKey.S)) direction += Transform.Down;

		if (Keyboard.IsKeyDown(KeyboardKey.A)) direction += Transform.Left;
		else if (Keyboard.IsKeyDown(KeyboardKey.D)) direction += Transform.Right;

		if (direction.Length() > 0)
		{
			float finalMovementSpeed = isSprinting ? MovementSpeed * 3 : MovementSpeed;
			Vector2 normalizedDirection = Vector2.Normalize(direction);
			Transform.WorldPosition += normalizedDirection * finalMovementSpeed * Engine.FrameTime;
		}
	}
}
