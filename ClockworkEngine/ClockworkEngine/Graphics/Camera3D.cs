using System.Numerics;

namespace Clockwork.Graphics.Draw3D;

public class Camera3D : CameraEntity
{
	public readonly IInternalCamera3D InternalCamera;

	// I may need to set up a transform!

	public Camera3D()
	{
		InternalCamera = Cameras.Create3D(Vector3.Zero, Quaternion.Identity, 45);
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
