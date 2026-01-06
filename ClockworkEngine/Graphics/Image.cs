using Clockwork.Graphics;

namespace Clockwork.Graphics;

public static class Image
{
	private static IImages backend => Engine.Rendering.Images;

	public static IImage Load(string fileName) => backend.Load(fileName);
}
