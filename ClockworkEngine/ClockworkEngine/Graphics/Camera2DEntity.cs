using Clockwork.Input;
using System.Numerics;
using Clockwork.Utilities;

namespace Clockwork.Graphics.Draw2D;

public class Camera2DEntity : CameraEntity
{
	// General
	public readonly ICamera2D InternalCamera;
	public Transform2D Transform = new();

	// Mouse
	public float MouseWorldX => Mouse.GameX - Engine.HalfGameWidth + Transform.WorldPosition.X;
	public float MouseWorldY => Mouse.GameY - Engine.HalfGameHeight + Transform.WorldPosition.Y;

	public Camera2DEntity()
	{
		Vector2 centeredOffset = new(Engine.HalfGameWidth, Engine.HalfGameHeight);
		InternalCamera = Cameras.Create2D(Vector2.Zero - centeredOffset, 0, 1);
	}

	public override void OnUpdate()
	{
		InternalCamera.Position = Transform.WorldPosition;
		InternalCamera.Rotation = Transform.WorldRotation;
	}

	internal override void Begin()
	{
		Cameras.BeginRendering2D(InternalCamera);
	}

	internal override void End()
	{
		Cameras.EndRendering2D();
	}
}
