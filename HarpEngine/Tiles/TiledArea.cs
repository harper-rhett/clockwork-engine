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
	public int[,] TilesByID { private get; set; }
	private List<Entity> registeredEntities = new();
	public IReadOnlyList<Entity> RegisteredEntities => registeredEntities;

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
		renderTexture.Texture.Draw(renderRectangle, Position, Colors.White);
	}

	public Coordinate GetTileLocalCoordinate(int pixelX, int pixelY)
	{
		float localX = pixelX - Position.X;
		float localY = pixelY - Position.Y;
		int tileX = (localX / TileSize).Floored();
		int tileY = (localY / TileSize).Floored();
		return new(tileX, tileY);
	}

	public int GetTileTypeID(int pixelX, int pixelY)
	{
		Coordinate tileCoordinate = GetTileLocalCoordinate(pixelX, pixelY);
		return TilesByID[tileCoordinate.X, tileCoordinate.Y];
	}

	public TileType GetTileType<TileType>(int pixelX, int pixelY) where TileType : Enum
	{
		return (TileType)(object)GetTileTypeID(pixelX, pixelY);
	}

	public bool InBounds(int pixelX, int pixelY)
	{
		bool xCheck = pixelX >= Position.X.Floored() && pixelX < Position.X.Floored() + WidthInPixels;
		bool yCheck = pixelY >= Position.Y.Floored() && pixelY < Position.Y.Floored() + HeightInPixels;
		return xCheck && yCheck;
	}

	public void RegisterEntity(Entity entity)
	{
		registeredEntities.Add(entity);
	}
}
