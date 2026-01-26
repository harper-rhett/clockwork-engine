using Clockwork.Input;
using System.Numerics;
using Clockwork.Utilities;

namespace Clockwork.Graphics;

public class Camera2D : CameraEntity
{
	// General
	public Transform2D Transform = new();
	public RaylibCamera2D InternalCamera;
	public Vector2 Offset
	{
		get => InternalCamera.Offset;
		set => InternalCamera.Offset = value;
	}

	// Mouse
	public float MouseWorldX => Mouse.GameX - Engine.HalfGameWidth + Transform.WorldPosition.X;
	public float MouseWorldY => Mouse.GameY - Engine.HalfGameHeight + Transform.WorldPosition.Y;

	public Camera2D()
	{
		Vector2 centeredOffset = new(Engine.HalfGameWidth, Engine.HalfGameHeight);
		InternalCamera = new(Vector2.Zero, 0, 1);
		InternalCamera.Offset = centeredOffset;
	}

	internal override void Begin()
	{
		InternalCamera.Position = Transform.WorldPosition;
		InternalCamera.Rotation = Transform.WorldRotation;
		RaylibCamera2D.BeginRendering(InternalCamera);
	}

	internal override void End()
	{
		RaylibCamera2D.EndRendering();
	}
}
