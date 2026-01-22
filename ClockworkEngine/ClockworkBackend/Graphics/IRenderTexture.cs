namespace Clockwork.Graphics;

public interface IRenderTexture : IDisposable
{
	public ITexture Texture { get; }
	public bool IsValid { get; }
}
