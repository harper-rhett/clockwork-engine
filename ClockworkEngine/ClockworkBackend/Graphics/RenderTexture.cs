using Clockwork.Interface;

namespace Clockwork.Graphics;

public static class RenderTexture
{
	private static IRenderTextures backend => BackendInterface.Rendering.RenderTextures;

	public static void BeginDrawing(IRenderTexture renderTexture) => backend.BeginDrawing(renderTexture);
	public static void EndDrawing() => backend.EndDrawing();
	public static IRenderTexture Load(int width, int height) => backend.Load(width, height);
}
