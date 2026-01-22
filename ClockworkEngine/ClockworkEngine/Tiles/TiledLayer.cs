using Clockwork.Utilities;
using System.Numerics;

namespace Clockwork.Tiles;

public class TiledLayer : TiledLayer<TiledArea>
{
	public TiledLayer(int tileSize) : base(tileSize)
	{
	}
}

public class TiledLayer<TiledAreaType> : Entity where TiledAreaType : TiledArea
{
	private List<TiledArea> areas = new();
	private Dictionary<Coordinate, TiledArea> areasByTile = new();
	private int tileSize;

	public TiledLayer(int tileSize)
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
		foreach (TiledArea area in areas) area.Draw();
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

	public TiledAreaType GetArea(int pixelX, int pixelY)
	{
		Coordinate coordinate = GetTileCoordinate(pixelX, pixelY);
		return areasByTile[coordinate] as TiledAreaType;
	}

	public TiledAreaType GetArea(Vector2 pixelPosition)
	{
		return GetArea(pixelPosition.X.Floored(), pixelPosition.Y.Floored()) as TiledAreaType;
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
}
