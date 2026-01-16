using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Clockwork.Graphics.Draw3D;

public class Camera3DEntity : CameraEntity
{
	public readonly ICamera3D InternalCamera;

	// I may need to set up a transform!

	public Camera3DEntity()
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
