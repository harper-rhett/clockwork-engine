using Clockwork.Graphics.Draw3D;
using Clockwork.Input;
using Clockwork.Utilities;
using System.Numerics;

namespace Clockwork.Graphics;

public class FreeCamera3D : Camera3D
{
	public float MovementSpeed = 2f;
	public float TurnSpeed = 0.5f;

	public FreeCamera3D()
	{

	}

	public override void OnUpdate()
	{
		bool isSprinting = Keyboard.IsKeyDown(KeyboardKey.LeftShift);

		Move(isSprinting);
		Rotate(isSprinting);

		base.OnUpdate();
	}

	private void Move(bool isSprinting)
	{
		Vector3 direction = Vector3.Zero;

		if (Keyboard.IsKeyDown(KeyboardKey.W)) direction += Transform.Forward;
		else if (Keyboard.IsKeyDown(KeyboardKey.S)) direction += Transform.Back;

		if (Keyboard.IsKeyDown(KeyboardKey.A)) direction += Transform.Left;
		else if (Keyboard.IsKeyDown(KeyboardKey.D)) direction += Transform.Right;

		if (Keyboard.IsKeyDown(KeyboardKey.Space)) direction += Transform.Up;
		else if (Keyboard.IsKeyDown(KeyboardKey.LeftControl)) direction += Transform.Down;

		if (direction.Length() > 0)
		{
			float finalMovementSpeed = isSprinting ? MovementSpeed * 3 : MovementSpeed;
			Vector3 normalizedDirection = Vector3.Normalize(direction);
			Transform.WorldPosition += normalizedDirection * finalMovementSpeed * Engine.FrameTime;
		}
	}

	private void Rotate(bool isSprinting)
	{
		float finalTurnSpeed = isSprinting ? TurnSpeed * 2 : TurnSpeed;

		Vector3 yAxis = Vector3.Zero;

		if (Keyboard.IsKeyDown(KeyboardKey.Left)) yAxis += Vector3.UnitY;
		else if (Keyboard.IsKeyDown(KeyboardKey.Right)) yAxis += -Vector3.UnitY;

		if (yAxis.Length() > 0)
		{
			Vector3 normalizedAxis = Vector3.Normalize(yAxis);
			Transform.WorldRotation = Transform.WorldRotation.RotateWorldAxis(normalizedAxis, finalTurnSpeed * Engine.FrameTime);
		}

		Vector3 localXAxis = Vector3.Zero;

		if (Keyboard.IsKeyDown(KeyboardKey.Up)) localXAxis += Vector3.UnitX;
		else if (Keyboard.IsKeyDown(KeyboardKey.Down)) localXAxis += -Vector3.UnitX;

		if (localXAxis.Length() > 0)
		{
			Vector3 normalizedAxis = Vector3.Normalize(localXAxis);
			Transform.WorldRotation = Transform.WorldRotation.RotateLocalAxis(normalizedAxis, finalTurnSpeed * Engine.FrameTime);
		}
	}
}
