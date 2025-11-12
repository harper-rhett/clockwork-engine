namespace HarpEngine.Tiles;

public class Tile
{
	private Vector2 position;
	private Texture tilesetTexture;
	private Rectangle spriteRectangle;

	public Tile(Vector2 position, Texture tilesetTexture, int tilesetX, int tilesetY, int size, bool xFlipped, bool yFlipped)
	{
		this.position = position;
		this.tilesetTexture = tilesetTexture;

		int width = xFlipped ? -size : size;
		int height = yFlipped ? -size : size;
		spriteRectangle = new(tilesetX, tilesetY, width, height);
	}

	public void Draw()
	{
		tilesetTexture.Draw(spriteRectangle, position, Colors.White);
	}
}
