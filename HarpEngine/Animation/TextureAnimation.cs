namespace HarpEngine.Animation;

public class TextureAnimation
{
	private Texture texture;
	private float timePerCell;
	private Rectangle[] cells;
	public float PlayTime { get; private set; }
	private float currentTime = 0;
	public float AnimationTime
	{
		get => currentTime;
		set => currentTime = value % PlayTime;
	}
	public bool PlayOnce;

	public TextureAnimation(Texture texture, int cellCount, int cellWidth, int cellHeight, float timePerCell)
	{
		this.texture = texture;
		this.timePerCell = timePerCell;

		ProcessCells(cellWidth, cellHeight, cellCount);
	}

	private void ProcessCells(int cellWidth, int cellHeight, int cellCount)
	{
		int xCount = texture.Width / cellWidth;
		int yCount = texture.Height / cellHeight;
		cells = new Rectangle[cellCount];
		PlayTime = timePerCell * cells.Length;

		for (int xCell = 0; xCell < xCount; xCell++)
			for (int yCell = 0; yCell < yCount; yCell++)
			{
				int cellIndex = xCell + yCell * xCount;
				if (cellIndex >= cellCount) return;
				int textureX = xCell * cellWidth;
				int textureY = yCell * cellHeight;
				Rectangle cell = new Rectangle(textureX, textureY, cellWidth, cellHeight);
				cells[cellIndex] = cell;
			}
	}

	public void Draw(Vector2 position, Vector2 direction, float frameTime, Color color)
	{
		int cellIndex;
		if (PlayOnce && currentTime >= PlayTime) cellIndex = cells.Length - 1;
		else cellIndex = (currentTime / timePerCell).Floored();

		Rectangle cell = cells[cellIndex];
		cell.Width *= direction.X;
		cell.Height *= direction.Y;
		texture.Draw(cell, position, color);

		currentTime += frameTime;
		if (!PlayOnce) currentTime %= PlayTime;
	}

	public void Reset() => currentTime = 0;
}
