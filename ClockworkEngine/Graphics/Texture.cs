using System.Runtime.InteropServices;
using System.Numerics;

namespace Clockwork.Graphics;

public static class Texture
{
	private static ITextures backend => Engine.Rendering.Textures;

	public static ITexture Load(string filePath) => backend.Load(filePath);
	public static ITexture Load(IImage image) => backend.Load(image);
}