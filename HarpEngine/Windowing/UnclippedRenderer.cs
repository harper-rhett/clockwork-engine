namespace HarpEngine.Windowing;

internal class UnclippedRenderer : WindowRenderer
{
	private Color borderColor;
	private Rectangle gameRectangle;
	private Rectangle viewportRectangle;

	public UnclippedRenderer(Color borderColor)
	{
		this.borderColor = borderColor;
	}

	private int mouseGameX;
	internal override int MouseGameX => mouseGameX;

	private int mouseGameY;
	internal override int MouseGameY => mouseGameY;

	internal override void Update(RenderTexture gameRenderTexture)
	{
		// Initialize
		RefreshDimensions(gameRenderTexture);
		gameRectangle = new(0, 0, gameWidth, -gameHeight);

		// Only calculate viewport rectangle if window has been resized
		if (DidResize) CalculateScale();
		CalculateMouse();
	}

	internal override void Draw(RenderTexture gameRenderTexture)
	{
		// Clear background to draw border before drawing game
		Drawing.Clear(borderColor);
		gameRenderTexture.Texture.Draw(gameRectangle, viewportRectangle, Vector2.Zero, 0, Colors.White);
	}

	private void CalculateScale()
	{
		viewportRectangle = new();

		float gameAspect = (float)gameWidth / gameHeight;
		float windowAspect = (float)windowWidth / windowHeight;
		bool widerWindow = windowAspect > gameAspect;
		bool widerGame = windowAspect < gameAspect;

		if (widerWindow)
		{
			float viewportWidth = windowHeight * gameAspect;
			viewportRectangle.X = (windowWidth - viewportWidth) / 2f;
			viewportRectangle.Y = 0;
			viewportRectangle.Width = viewportWidth;
			viewportRectangle.Height = windowHeight;
		}
		else if (widerGame)
		{
			float viewportHeight = windowWidth / gameAspect;
			viewportRectangle.X = 0;
			viewportRectangle.Y = (windowHeight - viewportHeight) / 2f;
			viewportRectangle.Width = windowWidth;
			viewportRectangle.Height = viewportHeight;
		}
		else
		{
			viewportRectangle = new(0, 0, windowWidth, windowHeight);
		}
	}

	private void CalculateMouse()
	{
		float widthScale = gameRectangle.Width / viewportRectangle.Width;
		float viewportX = float.Clamp(Mouse.WindowX - viewportRectangle.X, 0, viewportRectangle.Width);
		float gameX = viewportX * widthScale;
		mouseGameX = (int)gameX;

		float heightScale = gameRectangle.Height  / - viewportRectangle.Height;
		float viewportY = float.Clamp(Mouse.WindowY - viewportRectangle.Y, 0, viewportRectangle.Height);
		float gameY = viewportY * heightScale;
		mouseGameY = (int)gameY;
	}
}