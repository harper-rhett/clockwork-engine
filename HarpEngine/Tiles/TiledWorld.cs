namespace HarpEngine.Tiles;

public class TiledWorld : Entity
{
	private IEnumerable<TiledArea> areas;
	private Dictionary<Coordinate, TiledArea> areasByTile = new();
	private int tileSize;

	public TiledWorld(IEnumerable<TiledArea> areas, int tileSize)
	{
		this.areas = areas;
		this.tileSize = tileSize;

		foreach (TiledArea area in areas)
		{
			Coordinate areaCoordinate = GetTileCoordinate(area.Position);
			for (int xTile = areaCoordinate.X; xTile < areaCoordinate.X + area.WidthInTiles; xTile++)
				for (int yTile = areaCoordinate.Y; yTile < areaCoordinate.Y + area.HeightInTiles; yTile++)
				{
					Coordinate currentCoordinate = new(xTile, yTile);
					areasByTile[currentCoordinate] = area;
				}
		}
	}

	public override void OnDraw()
	{
		foreach (TiledArea area in areas)
		{
			area.Draw();
		}
	}

	public bool DoesAreaExist(int pixelX, int pixelY)
	{
		Coordinate coordinate = GetTileCoordinate(pixelX, pixelY);
		return areasByTile.ContainsKey(coordinate);
	}

	public bool DoesAreaExist(Vector2 pixelPosition)
	{
		return DoesAreaExist(pixelPosition.X.Floored(), pixelPosition.Y.Floored());
	}

	public TiledArea GetArea(int pixelX, int pixelY)
	{
		Coordinate coordinate = GetTileCoordinate(pixelX, pixelY);
		return areasByTile[coordinate];
	}

	public TiledArea GetArea(Vector2 pixelPosition)
	{
		return GetArea(pixelPosition.X.Floored(), pixelPosition.Y.Floored());
	}

	private Coordinate GetTileCoordinate(int pixelX, int pixelY)
	{
		int coordinateX = ((float)pixelX / tileSize).Floored();
		int coordinateY = ((float)pixelY / tileSize).Floored();
		Coordinate coordinate = new(coordinateX, coordinateY);
		return coordinate;
	}

	private Coordinate GetTileCoordinate(Vector2 pixelPosition)
	{
		return GetTileCoordinate(pixelPosition.X.Floored(), pixelPosition.Y.Floored());
	}

	public Vector2 SnapPosition(int pixelX, int pixelY)
	{
		int tilePixelX = ((float)pixelX / tileSize).Floored() * tileSize;
		int tilePixelY = ((float)pixelY / tileSize).Floored() * tileSize;
		return new(tilePixelX, tilePixelY);
	}
}
