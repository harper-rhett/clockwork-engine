namespace HarpEngine.Tiles;

public class TiledArea
{
	public readonly Vector2 Position;
	public readonly int WidthInTiles;
	public readonly int HeightInTiles;
	public readonly int WidthInPixels;
	public readonly int HeightInPixels;
	public readonly int TileSize;
	private readonly RenderTexture renderTexture;
	private readonly Rectangle renderRectangle;
	public int[,] TileTypes { private get; set; }

	public Tile[] Tiles
	{
		set => ProcessTexture(value);
	}

	public TiledArea(Vector2 position, int widthInTiles, int heightInTiles, int tileSize)
	{
		Position = position;
		WidthInTiles = widthInTiles;
		HeightInTiles = heightInTiles;
		WidthInPixels = widthInTiles * tileSize;
		HeightInPixels = heightInTiles * tileSize;
		TileSize = tileSize;
		renderTexture = RenderTexture.Load(WidthInPixels, HeightInPixels);
		renderRectangle = new(0, 0, WidthInPixels, -HeightInPixels);
	}

	private void ProcessTexture(Tile[] tiles)
	{
		RenderTexture.BeginDrawing(renderTexture);
		foreach (Tile tile in tiles) tile.Draw();
		RenderTexture.EndDrawing();
	}

	public void Draw()
	{
		// WTF is going on???
		renderTexture.Texture.Draw(renderRectangle, Position + Vector2.UnitY * HeightInPixels, Colors.White);
	}

	public TileType GetTileType<TileType>(int pixelX, int pixelY) where TileType : Enum
	{
		float localX = pixelX - Position.X;
		float localY = pixelY - Position.Y;
		int tileX = (localX / TileSize).Floored();
		int tileY = (localY / TileSize).Floored();
		return (TileType)(object)TileTypes[tileX, tileY];
	}

	public bool InBounds(int pixelX, int pixelY)
	{
		bool xCheck = pixelX >= Position.X.Floored() && pixelX < Position.X.Floored() + WidthInPixels;
		bool yCheck = pixelY >= Position.Y.Floored() && pixelY < Position.Y.Floored() + HeightInPixels;
		return xCheck && yCheck;
	}

	public Vector2 SnapPosition(int pixelX, int pixelY) // can be moved to TiledWorld?
	{
		int tilePixelX = ((float)pixelX / TileSize).Floored() * TileSize;
		int tilePixelY = ((float)pixelY / TileSize).Floored() * TileSize;
		return new(tilePixelX, tilePixelY);
	}
}
