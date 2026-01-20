using Clockwork.Graphics.Draw3D;
using Clockwork.Input;
using Clockwork.Utilities;
using System.Numerics;

namespace Clockwork.Graphics;

public class FreeCamera3D : Camera3D
{
	public float MovementSpeed = 1f;
	public float TurnSpeed = 0.5f;

	public FreeCamera3D()
	{

	}

	public override void OnUpdate()
	{
		bool isSprinting = Keyboard.IsKeyDown(KeyboardKey.LeftShift);

		Vector3 direction = Vector3.Zero;

		if (Keyboard.IsKeyDown(KeyboardKey.W)) direction += Transform.Forward;
		else if (Keyboard.IsKeyDown(KeyboardKey.S)) direction += Transform.Back;

		if (Keyboard.IsKeyDown(KeyboardKey.A)) direction += Transform.Left;
		else if (Keyboard.IsKeyDown(KeyboardKey.D)) direction += Transform.Right;

		if (Keyboard.IsKeyDown(KeyboardKey.E)) direction += Transform.Up;
		else if (Keyboard.IsKeyDown(KeyboardKey.Q)) direction += Transform.Down;

		if (direction.Length() > 0)
		{
			float finalMovementSpeed = isSprinting ? MovementSpeed * 3 : MovementSpeed;
			Vector3 normalizedDirection = Vector3.Normalize(direction);
			Transform.WorldPosition += normalizedDirection * finalMovementSpeed * Engine.FrameTime;
		}

		Vector3 axis = Vector3.Zero;
		if (Keyboard.IsKeyDown(KeyboardKey.Left)) axis += Vector3.UnitY;
		else if (Keyboard.IsKeyDown(KeyboardKey.Right)) axis += -Vector3.UnitY;

		if (axis.Length() > 0)
		{
			Vector3 normalizedAxis = Vector3.Normalize(axis);
			float finalTurnSpeed = isSprinting ? TurnSpeed * 3 : TurnSpeed;
			Transform.WorldRotation = Transform.WorldRotation.RotateWorldAxis(normalizedAxis, finalTurnSpeed * Engine.FrameTime);
		}

		base.OnUpdate();
	}
}
