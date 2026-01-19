using Clockwork.Graphics.Draw3D;
using Clockwork.Input;
using Clockwork.Utilities;
using System.Numerics;

namespace Clockwork.Graphics;

public class FreeCamera3D : Camera3D
{
	public float Speed = 1;

	public FreeCamera3D()
	{

	}

	public override void OnUpdate()
	{
		Vector3 direction = Vector3.Zero;

		if (Keyboard.IsKeyDown(KeyboardKey.W)) direction += Transform.Forward;
		else if (Keyboard.IsKeyDown(KeyboardKey.S)) direction += Transform.Back;

		if (Keyboard.IsKeyDown(KeyboardKey.A)) direction += Transform.Left;
		else if (Keyboard.IsKeyDown(KeyboardKey.D)) direction += Transform.Right;

		if (Keyboard.IsKeyDown(KeyboardKey.E)) direction += Transform.Up;
		else if (Keyboard.IsKeyDown(KeyboardKey.Q)) direction += Transform.Down;

		if (direction.Length() > 0)
		{
			float finalSpeed = Keyboard.IsKeyDown(KeyboardKey.LeftShift) ? Speed * 3 : Speed;
			Transform.WorldPosition += Vector3.Normalize(direction) * Engine.FrameTime * finalSpeed;
		}
			
		base.OnUpdate();
	}
}
