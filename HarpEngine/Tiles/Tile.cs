namespace HarpEngine.Tiles;

public class Tile<TileType> where TileType : Enum
{
	private Texture tilesetTexture;
	private Rectangle spriteRectangle;
	public readonly TileType Type;

	public Tile(Texture tilesetTexture, int tilesetX, int tilesetY, int size, TileType type, bool xFlipped, bool yFlipped)
	{
		this.tilesetTexture = tilesetTexture;
		Type = type;

		int width = xFlipped ? -size : size;
		int height = yFlipped ? -size : size;
		spriteRectangle = new(tilesetX, tilesetY, width, height);
	}

	public void Draw(Vector2 position)
	{
		tilesetTexture.Draw(spriteRectangle, position, Colors.White);
	}
}
