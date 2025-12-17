namespace HarpEngine.Tiles;

public class TiledWorld : Entity
{
	private List<TiledArea> areas = new();
	private Dictionary<Coordinate, TiledArea> areasByTile = new();
	private int tileSize;
	private HashSet<TiledArea> focusAreas = new();

	public TiledWorld(int tileSize)
	{
		this.tileSize = tileSize;
	}

	public void AddArea(TiledArea area)
	{
		areas.Add(area);
		Coordinate areaCoordinate = GetTileCoordinate(area.Position);
		for (int xTile = areaCoordinate.X; xTile < areaCoordinate.X + area.WidthInTiles; xTile++)
			for (int yTile = areaCoordinate.Y; yTile < areaCoordinate.Y + area.HeightInTiles; yTile++)
			{
				Coordinate currentCoordinate = new(xTile, yTile);
				areasByTile[currentCoordinate] = area;
			}
	}

	public override void OnDraw()
	{
		if (focusAreas.Count == 0) throw new InvalidOperationException("Focus must be set before attempting to draw.");
		foreach (TiledArea focusArea in focusAreas) focusArea.Draw();
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

	public Vector2 SnapPosition(Vector2 pixelPosition)
	{
		return SnapPosition(pixelPosition.X.Floored(), pixelPosition.Y.Floored());
	}

	public void AddFocus(TiledArea focusArea)
	{
		focusAreas.Add(focusArea);
		foreach (Entity entity in focusArea.RegisteredEntities)
		{
			entity.IsUpdating = true;
			entity.IsRendering = true;
		}
	}

	public void RemoveFocus(TiledArea focusArea)
	{
		focusAreas.Remove(focusArea);
		foreach (Entity entity in focusArea.RegisteredEntities)
		{
			entity.IsUpdating = false;
			entity.IsRendering = false;
		}
	}
}
