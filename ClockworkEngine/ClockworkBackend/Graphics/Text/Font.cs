using Clockwork.Interface;

namespace Clockwork.Graphics.Text;

public static class Font
{
	private static IFonts backend => BackendInterface.Rendering.Fonts;

	public static IFont Default => backend.Default;
	public static IFont Load(string fileName) => backend.Load(fileName);
}