namespace Clockwork.Tiles;

public class Tile
{
	private Vector2 localPosition;
	private Texture tilesetTexture;
	private Rectangle spriteRectangle;

	public Tile(Vector2 localPosition, Texture tilesetTexture, int tilesetX, int tilesetY, int size, bool xFlipped, bool yFlipped)
	{
		this.localPosition = localPosition;
		this.tilesetTexture = tilesetTexture;

		int width = xFlipped ? -size : size;
		int height = yFlipped ? -size : size;
		spriteRectangle = new(tilesetX, tilesetY, width, height);
	}

	public void Draw()
	{
		tilesetTexture.Draw(spriteRectangle, localPosition, Colors.White);
	}
}
