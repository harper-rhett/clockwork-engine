using System.Numerics;

namespace Clockwork.Graphics;

public interface IText
{
	public void Draw(string text, int x, int y, int fontSize, Color color);
	public void Draw(string text, Vector2 position, int fontSize, Color color);
	public void Draw(IFont font, string text, Vector2 position, float fontSize, float spacing, Color color);
	public void Draw(IFont font, string text, Vector2 position, Vector2 origin, float rotation, float fontSize, float spacing, Color color);
	public Vector2 MeasureSize(IFont font, string text, float fontSize, float spacing);
}
