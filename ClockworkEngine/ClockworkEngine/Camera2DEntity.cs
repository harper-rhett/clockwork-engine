using Clockwork.Graphics;
using Clockwork.Input;
using System.Numerics;
using Clockwork.Utilities;

namespace Clockwork;

public class Camera2DEntity : CameraEntity
{
	// General
	public readonly ICamera2D InternalCamera;
	public Transform2D Transform = new();
	public Vector2 Offset
	{
		get => InternalCamera.Offset;
		set => InternalCamera.Offset = value;
	}

	// Mouse
	public float MouseWorldX => Mouse.GameX - Engine.HalfGameWidth + Transform.WorldPosition.X;
	public float MouseWorldY => Mouse.GameY - Engine.HalfGameHeight + Transform.WorldPosition.Y;

	public Camera2DEntity()
	{
		Vector2 centeredOffset = new(Engine.HalfGameWidth, Engine.HalfGameHeight);
		InternalCamera = Camera.Create(Vector2.Zero, centeredOffset, 0, 1);
	}

	public override void OnUpdate()
	{
		InternalCamera.Position = Transform.WorldPosition;
		InternalCamera.Rotation = Transform.WorldRotation;
	}

	internal override void Begin()
	{
		Camera.BeginRendering2D(InternalCamera);
	}

	internal override void End()
	{
		Camera.EndRendering2D();
	}
}
