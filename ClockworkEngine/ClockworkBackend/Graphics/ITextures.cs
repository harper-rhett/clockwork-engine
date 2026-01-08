namespace Clockwork.Graphics;

public interface ITextures
{
	public ITexture Load(string filePath);
	public ITexture Load(IImage image);
}
