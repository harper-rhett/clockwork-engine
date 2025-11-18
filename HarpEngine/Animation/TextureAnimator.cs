namespace HarpEngine.Animation;

public class TextureAnimator
{
	private Texture texture;
	private float timePerCell;
	private Rectangle[] cells;
	private float animationTime;
	private float time = 0;

	public TextureAnimator(Texture texture, int cellCount, int cellWidth, int cellHeight, float timePerCell)
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
		animationTime = timePerCell * cells.Length;

		for (int xCell = 0; xCell < xCount; xCell++)
			for (int yCell = 0; yCell < yCount; yCell++)
			{
				int cellIndex = xCell + yCell * xCount;
				if (cellIndex >= cellCount) return;
				int textureX = xCell * cellWidth;
				int textureY = yCell * cellHeight;
				Rectangle cell = new Rectangle(textureX, textureY, texture.Width, texture.Height);
				cells[cellIndex] = cell;
			}
	}

	public void Draw(Vector2 position, Color color, float frameTime)
	{
		time += frameTime;
		time %= animationTime;
		int cellIndex = (time / timePerCell).Floored();
		texture.Draw(cells[cellIndex], position, color);
	}

	public void Reset() => time = 0;
}
