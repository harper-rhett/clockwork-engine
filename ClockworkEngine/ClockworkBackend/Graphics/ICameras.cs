using System.Numerics;

namespace Clockwork.Graphics;

public interface ICameras
{
	public ICamera2D Create(Vector2 position, Vector2 offset, float rotation, float zoom);
	public void BeginRendering2D(ICamera2D camera2D);
	public void EndRendering2D();
}
