namespace Clockwork;

public class Camera2D : Camera
{
	// General
	private RaylibCamera2D raylibCamera;
	public Transform2D Transform = new();
	public Vector2 Offset
	{
		get => raylibCamera.Offset;
		set => raylibCamera.Offset = value;
	}

	// Mouse
	public float MouseWorldX => Mouse.GameX - Engine.HalfGameWidth + Transform.WorldPosition.X;
	public float MouseWorldY => Mouse.GameY - Engine.HalfGameHeight + Transform.WorldPosition.Y;

	public Camera2D()
	{
		Vector2 centeredOffset = new(Engine.HalfGameWidth, Engine.HalfGameHeight);
		raylibCamera = new(centeredOffset, Vector2.Zero, 0, 1);
	}

	public override void OnUpdate()
	{
		raylibCamera.Target = Transform.WorldPosition;
		raylibCamera.Rotation = Transform.WorldRotation;
	}

	internal override void Begin()
	{
		raylibCamera.Target = raylibCamera.Target.Floored();
		RaylibCamera2D.BeginRendering(raylibCamera);
	}

	internal override void End()
	{
		RaylibCamera2D.EndRendering();
	}
}
