using HarpEngine;
using HarpEngine.Tiles;
using HarpEngine.Utilities;

namespace Tiles;

public class TiledWorld<TileType> where TileType : Enum
{
	private IEnumerable<TiledArea<TileType>> areas;
	private Dictionary<Coordinate, TiledArea<TileType>> areasByTile = new();
	private int tileSize;

	public TiledWorld(IEnumerable<TiledArea<TileType>> areas, int tileSize)
	{
		this.areas = areas;
		this.tileSize = tileSize;

		foreach (TiledArea<TileType> area in areas)
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

	public void Draw()
	{
		foreach (TiledArea<TileType> area in areas)
		{
			area.Draw();
		}
	}

	public bool DoesAreaExist(Vector2 pixelPosition)
	{
		Coordinate coordinate = GetTileCoordinate(pixelPosition);
		return areasByTile.ContainsKey(coordinate);
	}

	public TiledArea<TileType> GetArea(Vector2 pixelPosition)
	{
		Coordinate coordinate = GetTileCoordinate(pixelPosition);
		return areasByTile[coordinate];
	}

	private Coordinate GetTileCoordinate(Vector2 pixelPosition)
	{
		int coordinateX = (pixelPosition.X / tileSize).Floored();
		int coordinateY = (pixelPosition.Y / tileSize).Floored();
		Coordinate coordinate = new(coordinateX, coordinateY);
		return coordinate;
	}
}
