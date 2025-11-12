namespace HarpEngine.Tiles;

public class TiledArea<TileType> where TileType : Enum
{
	public readonly Vector2 Position;
	public readonly int WidthInTiles;
	public readonly int HeightInTiles;
	public readonly int WidthInPixels;
	public readonly int HeightInPixels;
	public readonly int TileSize;
	private readonly RenderTexture renderTexture;
	private readonly Rectangle renderRectangle;
	private Tile<TileType>[,] tiles;

	public TiledArea(Vector2 position, int widthInTiles, int heightInTiles, int tileSize, Tile<TileType>[,] tiles)
	{
		Position = position;
		WidthInTiles = widthInTiles;
		HeightInTiles = heightInTiles;
		WidthInPixels = widthInTiles * tileSize;
		HeightInPixels = heightInTiles * tileSize;
		TileSize = tileSize;
		renderTexture = RenderTexture.Load(WidthInPixels, HeightInPixels);
		renderRectangle = new(0, 0, WidthInPixels, -HeightInPixels);

		ProcessTexture();
	}

	private void ProcessTexture()
	{
		RenderTexture.BeginDrawing(renderTexture);
		for (int tileX = 0; tileX < WidthInTiles; tileX++)
			for (int tileY = 0; tileY < HeightInTiles; tileY++)
			{
				Tile<TileType> tile = tiles[tileX, tileY];
				Vector2 tilePosition = Position + new Vector2(tileX * TileSize, tileY * TileSize);
				tile.Draw(tilePosition);
			}
		RenderTexture.EndDrawing();
	}

	public void Draw()
	{
		renderTexture.Texture.Draw(renderRectangle, Position, Colors.White);
	}

	public TileType GetTile(int pixelX, int pixelY)
	{
		int tileX = (pixelX - Position.X.Floored()) / TileSize;
		int tileY = (pixelY - Position.Y.Floored()) / TileSize;
		return tiles[tileX, tileY].Type;
	}

	public bool InBounds(int pixelX, int pixelY)
	{
		bool xCheck = pixelX >= Position.X.Floored() && pixelX < Position.X.Floored() + WidthInPixels;
		bool yCheck = pixelY >= Position.Y.Floored() && pixelY < Position.Y.Floored() + HeightInPixels;
		return xCheck && yCheck;
	}

	public Vector2 SnapPosition(int pixelX, int pixelY)
	{
		int tilePixelX = ((float)pixelX / TileSize).Floored() * TileSize;
		int tilePixelY = ((float)pixelY / TileSize).Floored() * TileSize;
		return new(tilePixelX, tilePixelY);
	}
}
