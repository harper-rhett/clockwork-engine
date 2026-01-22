using System.Numerics;

namespace Clockwork.Graphics;

public interface ICameras
{
	public IInternalCamera2D Create2D(Vector2 position, float rotation, float zoom);
	public void BeginRendering2D(IInternalCamera2D camera2D);
	public void EndRendering2D();

	public IInternalCamera3D Create3D(Vector3 position, Quaternion rotation, float FOV);
	public void BeginRendering3D(IInternalCamera3D camera2D);
	public void EndRendering3D();
}
