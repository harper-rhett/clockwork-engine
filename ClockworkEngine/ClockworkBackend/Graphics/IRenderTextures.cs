namespace Clockwork.Graphics;

public interface IRenderTextures
{
	public void BeginDrawing(IRenderTexture renderTexture);
	public void EndDrawing();
	public IRenderTexture Load(int width, int height);
}
