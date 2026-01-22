using System.Numerics;

namespace Clockwork.Graphics;

public interface ITexture : IDisposable
{
	public int Width { get; }
	public int Height { get; }
	public bool IsValid { get; }

	public void Draw(int x, int y, Color color);
	public void Draw(Vector2 position, Color color);
	public void Draw(Rectangle source, int x, int y, Color color);
	public void Draw(Rectangle source, Vector2 position, Color color);
	public void Draw(Rectangle source, Rectangle destination, Vector2 origin, float rotation, Color color);
}
