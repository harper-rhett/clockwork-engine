using System.Runtime.InteropServices;
using System.Numerics;
using Clockwork.Interface;

namespace Clockwork.Graphics.Text;

public static class Text
{
	private static IText backend => BackendInterface.Rendering.Text;

	public static void Draw(string text, int x, int y, int fontSize, Color color) => backend.Draw(text, x, y, fontSize, color);
	public static void Draw(string text, Vector2 position, int fontSize, Color color) => backend.Draw(text, position, fontSize, color);
	public static void Draw(IFont font, string text, Vector2 position, float fontSize, float spacing, Color color) => backend.Draw(font, text, position, fontSize, spacing, color);
	public static void Draw(IFont font, string text, Vector2 position, Vector2 origin, float rotation, float fontSize, float spacing, Color color) => backend.Draw(font, text, position, origin, rotation, fontSize, spacing, color);

	public static Vector2 MeasureSize(IFont font, string text, float fontSize, float spacing) => backend.MeasureSize(font, text, fontSize, spacing);
}
