using System.Numerics;

namespace Clockwork.Graphics.Draw3D;

public interface ICamera3D
{
	public Vector3 Position { get; set; }
	public Quaternion Rotation { get; set; }
	public CameraProjection CameraProjection { get; set; }
}
