using Clockwork.Input;
using System.Numerics;
using Clockwork.Utilities;

namespace Clockwork.Graphics.Cameras;

public class Camera2D : CameraEntity
{
	// General
	public Transform2D Transform = new();
	public Vector2 Position
	{
		get => Transform.WorldPosition;
		set => Transform.WorldPosition = value;
	}
	public float Rotation
	{
		get => Transform.WorldRotation;
		set => Transform.WorldRotation = value;
	}
	public Camera2DInternal InternalCamera;
	public Vector2 Offset
	{
		get => InternalCamera.Offset;
		set => InternalCamera.Offset = value;
	}
	public float Zoom
	{
		get => InternalCamera.Zoom;
		set => InternalCamera.Zoom = value;
	}
	public float Width => Engine.GameWidth / Zoom;
	public float Height => Engine.GameHeight / Zoom;

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
		Camera2DInternal.BeginRendering(InternalCamera);
	}

	internal override void End()
	{
		Camera2DInternal.EndRendering();
	}

	public float GetMouseWorldX() => (Mouse.GameX - Engine.HalfGameWidth) / Zoom + Transform.WorldPosition.X;
	public float GetMouseWorldY() => (Mouse.GameY - Engine.HalfGameHeight) / Zoom + Transform.WorldPosition.Y;

	public Rectangle GetAxisAlignedViewport()
	{
		return new Rectangle(Position.X - Offset.X / Zoom, Position.Y - Offset.Y / Zoom, Width, Height);
	}
}
