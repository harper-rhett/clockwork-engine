using Clockwork.Utilities;
using System.Numerics;

namespace Clockwork.Graphics.Draw3D;

public class Camera3D : CameraEntity
{
	public Transform3D Transform = new();
	public readonly IInternalCamera3D InternalCamera;

	public Camera3D()
	{
		InternalCamera = Cameras.Create3D(Vector3.Zero, Quaternion.Identity, 45);
	}

	public override void OnUpdate()
	{
		InternalCamera.Position = Transform.WorldPosition;
		InternalCamera.Rotation = Transform.WorldRotation;
	}

	internal override void Begin()
	{
		Cameras.BeginRendering3D(InternalCamera);
	}

	internal override void End()
	{
		Cameras.EndRendering3D();
	}
}
