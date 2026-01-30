using Clockwork.Utilities;
using System.Numerics;

namespace Clockwork.Graphics.Draw3D;

public class Camera3D : CameraEntity
{
	public Transform3D Transform = new();
	public Camera3DInternal InternalCamera;

	public Camera3D(Vector3 position)
	{
		Transform.WorldPosition = position;
		InternalCamera = new(position, Quaternion.Identity, 45, CameraProjection.Perspective);
	}

	internal override void Begin()
	{
		InternalCamera.Position = Transform.WorldPosition;
		InternalCamera.Rotation = Transform.WorldRotation;
		Camera3DInternal.BeginRendering(InternalCamera);
	}

	internal override void End()
	{
		Camera3DInternal.EndRendering();
	}
}
