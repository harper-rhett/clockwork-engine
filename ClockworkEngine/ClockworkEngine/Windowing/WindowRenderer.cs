using Clockwork.Graphics;
using Clockwork.Input;

namespace Clockwork.Windowing;

public abstract class WindowRenderer
{
	// Window fields
	protected int windowWidth;
	protected int windowHeight;
	private int previousWindowWidth;
	private int previousWindowHeight;

	// Game fields
	protected int gameWidth;
	protected int gameHeight;

	// Mouse fields
	internal abstract int mouseGameX { get; set; }
	internal abstract int mouseGameY { get; set; }

	protected bool DidResize
	{
		get
		{
			bool result = windowWidth != previousWindowWidth || windowHeight != previousWindowHeight;
			previousWindowWidth = windowWidth;
			previousWindowHeight = windowHeight;
			return result;
		}
	}

	// Fetch new values
	protected void RefreshDimensions(RenderTexture gameRenderTexture)
	{
		windowWidth = Window.RenderWidth;
		windowHeight = Window.RenderHeight;
		gameWidth = gameRenderTexture.Texture.Width;
		gameHeight = gameRenderTexture.Texture.Height;
	}

	protected int MouseRenderX => (int)(Mouse.WindowX * (float)Window.RenderWidth / Window.Width);
	protected int MouseRenderY => (int)(Mouse.WindowY * (float)Window.RenderHeight / Window.Height);

	// Custom implementation for game sizing
	internal abstract void Update(RenderTexture gameRenderTexture);
	internal abstract void Draw(RenderTexture gameRenderTexture);

	// Current
	internal static WindowRenderer Current { get; private set; } = new UnclippedRenderer(Colors.Black);
	public static void SetUnclipped(Color borderColor) => Current = new UnclippedRenderer(borderColor);
	public static void SetClipped() => Current = new ClippedRenderer();
}