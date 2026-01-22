using Clockwork.Interface;
using Clockwork.Graphics;

namespace Clockwork.Graphics;

public static class Image
{
	private static IImages backend => BackendInterface.Rendering.Images;

	public static IImage Load(string fileName) => backend.Load(fileName);
	public static IImage Load(ITexture texture) => backend.Load(texture);
}
