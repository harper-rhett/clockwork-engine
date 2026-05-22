using Clockwork.Input;
using System;
using System.Numerics;

namespace Clockwork.Graphics.Cameras;

public class FreeCamera2D : Camera2D
{
	public float MovementSpeed = 50f;
	public float ZoomSpeed = 1.0f;

	public FreeCamera2D() : base()
	{

	}

	public override void OnUpdate()
	{
		float speedModifier = 1;
		if (Keyboard.IsKeyDown(KeyboardKey.LeftShift)) speedModifier = 3;
		else if (Keyboard.IsKeyDown(KeyboardKey.LeftControl)) speedModifier = 0.25f;

		Move(speedModifier);
		Zoom(speedModifier);

		base.OnUpdate();
	}

	private void Move(float speedModifier)
	{
		Vector2 direction = Vector2.Zero;

		if (Keyboard.IsKeyDown(KeyboardKey.W)) direction += Transform.Up;
		else if (Keyboard.IsKeyDown(KeyboardKey.S)) direction += Transform.Down;

		if (Keyboard.IsKeyDown(KeyboardKey.A)) direction += Transform.Left;
		else if (Keyboard.IsKeyDown(KeyboardKey.D)) direction += Transform.Right;

		if (direction.Length() > 0)
		{
			Vector2 normalizedDirection = Vector2.Normalize(direction);
			Transform.WorldPosition += normalizedDirection * MovementSpeed * speedModifier * Engine.FrameTime;
		}
	}

	private void Zoom(float speedModifier)
	{
		if (Keyboard.IsKeyDown(KeyboardKey.Up)) InternalCamera.Zoom += ZoomSpeed * speedModifier * Engine.FrameTime;
		else if (Keyboard.IsKeyDown(KeyboardKey.Down)) InternalCamera.Zoom -= ZoomSpeed * speedModifier * Engine.FrameTime;
		InternalCamera.Zoom = float.Clamp(InternalCamera.Zoom, 0.25f, 10);
	}
}
