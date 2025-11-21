namespace HarpEngine.Animation;

public class TextureAnimation
{
	private Texture texture;
	private Rectangle[] frameCells;
	public float PlayTime { get; private set; }
	private float currentTime = 0;
	public float AnimationTime
	{
		get => currentTime;
		set => currentTime = value % PlayTime;
	}
	public bool PlayOnce;
	public float TimePerFrame;
	public bool IsPaused;

	public TextureAnimation(Texture texture, int frameCount, int frameWidth, int frameHeight, float timePerFrame)
	{
		this.texture = texture;
		TimePerFrame = timePerFrame;

		ProcessCells(frameWidth, frameHeight, frameCount);
	}

	private void ProcessCells(int frameWidth, int frameHeight, int frameCount)
	{
		int xCount = texture.Width / frameWidth;
		int yCount = texture.Height / frameHeight;
		frameCells = new Rectangle[frameCount];

		for (int xCell = 0; xCell < xCount; xCell++)
			for (int yCell = 0; yCell < yCount; yCell++)
			{
				int cellIndex = xCell + yCell * xCount;
				if (cellIndex >= frameCount) return;
				int textureX = xCell * frameWidth;
				int textureY = yCell * frameHeight;
				Rectangle cell = new Rectangle(textureX, textureY, frameWidth, frameHeight);
				frameCells[cellIndex] = cell;
			}
	}

	public void Draw(Vector2 position, Vector2 direction, Color color)
	{
		PlayTime = TimePerFrame * frameCells.Length;

		int cellIndex;
		if (PlayOnce && currentTime >= PlayTime) cellIndex = frameCells.Length - 1;
		else cellIndex = (currentTime / TimePerFrame).Floored();

		Rectangle cell = frameCells[cellIndex];
		cell.Width *= direction.X;
		cell.Height *= direction.Y;
		texture.Draw(cell, position, color);

		if (!IsPaused) currentTime += Engine.FrameTime;
		if (!PlayOnce) currentTime %= PlayTime;
	}

	public void Reset() => currentTime = 0;
}
