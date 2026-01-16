using System.Numerics;
using Clockwork.Graphics.Draw2D;
using Clockwork.Graphics.Draw3D;

namespace Clockwork.Graphics;

public interface ICameras
{
	public ICamera2D Create2D(Vector2 position, float rotation, float zoom);
	public void BeginRendering2D(ICamera2D camera2D);
	public void EndRendering2D();

	public ICamera3D Create3D(Vector3 position, Quaternion rotation, float FOV);
	public void BeginRendering3D(ICamera3D camera2D);
	public void EndRendering3D();
}
