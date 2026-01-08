using Clockwork.Backend;

namespace Clockwork.Graphics;

public static class Drawing
{
	private static IDrawing backend => BackendInterface.Rendering.Drawing;

	public static void Clear(Color color) => backend.Clear(color);
	public static void Begin() => backend.Begin();
	public static void End() => backend.End();
}
