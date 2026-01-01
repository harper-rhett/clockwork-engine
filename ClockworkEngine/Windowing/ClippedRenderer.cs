namespace Clockwork.Windowing;

internal class ClippedRenderer : WindowRenderer
{
	private Rectangle gameRectangle;
	private Rectangle viewportRectangle;

	private int mouseGameX;
	internal override int MouseGameX => mouseGameX;

	private int mouseGameY;
	internal override int MouseGameY => mouseGameY;

	internal override void Update(RenderTexture gameRenderTexture)
	{
		// Initialize
		RefreshDimensions(gameRenderTexture);
		viewportRectangle = new(0, 0, windowWidth, windowHeight);

		// Only calculate game rectangle if window has been resized
		if (DidResize) CalculateScale();
		CalculateMouse();
	}

	internal override void Draw(RenderTexture gameRenderTexture)
	{
		// Draw game clipped
		gameRenderTexture.Texture.Draw(gameRectangle, viewportRectangle, Vector2.Zero, 0, Colors.White);
	}

	private void CalculateScale()
	{
		float gameAspect = (float)gameWidth / gameHeight;
		float windowAspect = (float)windowWidth / windowHeight;
		bool widerWindow = windowAspect > gameAspect;
		bool widerGame = windowAspect < gameAspect;

		if (widerWindow)
		{
			float aspectScale = gameAspect / windowAspect;
			float clippedGameHeight = gameHeight * aspectScale;
			gameRectangle.X = 0;
			gameRectangle.Y = (gameHeight - clippedGameHeight) / 2f;
			gameRectangle.Width = gameWidth;
			gameRectangle.Height = -clippedGameHeight;
		}
		else if (widerGame)
		{
			float aspectScale = gameAspect / windowAspect;
			float clippedGameWidth = gameWidth / aspectScale;
			gameRectangle.X = (gameWidth - clippedGameWidth) / 2f;
			gameRectangle.Y = 0;
			gameRectangle.Width = clippedGameWidth;
			gameRectangle.Height = -gameHeight;
		}
		else
		{
			gameRectangle = new(0, 0, gameWidth, -gameHeight);
		}
	}

	private void CalculateMouse()
	{
		float widthScale = gameRectangle.Width / viewportRectangle.Width;
		mouseGameX = (int)(Mouse.WindowX * widthScale + gameRectangle.X);
		
		float heightScale = gameRectangle.Height / -viewportRectangle.Height;
		mouseGameY = (int)(Mouse.WindowY * heightScale + gameRectangle.Y);
	}
}
