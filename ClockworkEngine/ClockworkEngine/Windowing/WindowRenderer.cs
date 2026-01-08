using Clockwork.Graphics;

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
	internal abstract int MouseGameX { get; }
	internal abstract int MouseGameY { get; }

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
	protected void RefreshDimensions(IRenderTexture gameRenderTexture)
	{
		windowWidth = Window.Width;
		windowHeight = Window.Height;
		gameWidth = gameRenderTexture.Texture.Width;
		gameHeight = gameRenderTexture.Texture.Height;
	}

	// Custom implementation for game sizing
	internal abstract void Update(IRenderTexture gameRenderTexture);
	internal abstract void Draw(IRenderTexture gameRenderTexture);

	// Current
	internal static WindowRenderer Current { get; private set; } = new UnclippedRenderer(Colors.Black);
	public static void SetUnclipped(Color borderColor) => Current = new UnclippedRenderer(borderColor);
	public static void SetClipped() => Current = new ClippedRenderer();
}