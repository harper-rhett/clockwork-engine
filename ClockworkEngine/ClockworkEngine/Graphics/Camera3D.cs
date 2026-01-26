using Clockwork.Utilities;
using System.Numerics;

namespace Clockwork.Graphics.Draw3D;

public class Camera3D : CameraEntity
{
	public Transform3D Transform = new();
	public RaylibCamera3D InternalCamera;

	public Camera3D(Vector3 position)
	{
		Transform.WorldPosition = position;
		InternalCamera = new(position, Quaternion.Identity, 45, CameraProjection.Perspective);
	}

	internal override void Begin()
	{
		InternalCamera.Position = Transform.WorldPosition;
		InternalCamera.Rotation = Transform.WorldRotation;
		RaylibCamera3D.BeginRendering(InternalCamera);
	}

	internal override void End()
	{
		RaylibCamera3D.EndRendering();
	}
}
