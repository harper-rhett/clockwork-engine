namespace Clockwork.Tiles;

public class TiledGameArea : TiledArea
{
	public int[,] TilesByID { private get; set; }
	private List<Entity> registeredEntities = new();
	public IReadOnlyList<Entity> RegisteredEntities => registeredEntities;

	private bool isActive;
	public override bool IsActive
	{
		get => isActive;
		set
		{
			isActive = value;
			foreach (Entity entity in registeredEntities)
			{
				entity.IsUpdating = value;
				entity.IsRendering = value;
			}
		}
	}

	public TiledGameArea(Vector2 position, int widthInTiles, int heightInTiles, int tileSize)
		: base(position, widthInTiles, heightInTiles, tileSize)
	{
		
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
