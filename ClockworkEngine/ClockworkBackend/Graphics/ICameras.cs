using System.Numerics;
using Clockwork.Graphics.Draw2D;
using Clockwork.Graphics.Draw3D;

namespace Clockwork.Graphics;

public interface ICameras
{
	public ICamera2D Create2D(Vector2 position, Vector2 offset, float rotation, float zoom);
	public void BeginRendering2D(ICamera2D camera2D);
	public void EndRendering2D();
}
