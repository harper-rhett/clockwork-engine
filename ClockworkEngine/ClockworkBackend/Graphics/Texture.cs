using Clockwork.Backend;

namespace Clockwork.Graphics;

public static class Texture
{
	private static ITextures backend => BackendInterface.Rendering.Textures;

	public static ITexture Load(string filePath) => backend.Load(filePath);
	public static ITexture Load(IImage image) => backend.Load(image);
}