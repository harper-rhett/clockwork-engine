namespace Clockwork.Graphics;

public interface IImages
{
	public IImage Load(string fileName);
	public IImage Load(ITexture texture);
}
