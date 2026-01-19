using System.Numerics;

namespace Clockwork.Graphics;

public interface IInternalCamera3D
{
	public Vector3 Position { get; set; }
	public Quaternion Rotation { get; set; }
	public CameraProjection CameraProjection { get; set; }
}
