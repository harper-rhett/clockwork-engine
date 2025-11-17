namespace HarpEngine.Tiles;

public class TiledCollider<TileType> where TileType : Enum
{
	public bool LeftInBounds { get; private set; }
	public bool RightInBounds { get; private set; }
	public bool TopInBounds { get; private set; }
	public bool BottomInBounds { get; private set; }

	public TileType LeftCenterTile { get; private set; }
	public TileType RightCenterTile { get; private set; }
	public TileType TopCenterTile { get; private set; }
	public TileType BottomCenterTile { get; private set; }

	private HashSet<int> leftTiles = new();
	private HashSet<int> rightTiles = new();
	private HashSet<int> topTiles = new();
	private HashSet<int> bottomTiles = new();

	private readonly int width;
	private readonly int halfWidth;
	private readonly int height;
	private readonly int halfHeight;

	public TiledCollider(int width, int height)
	{
		this.width = width;
		halfWidth = width / 2;
		this.height = height;
		halfHeight = height / 2;
	}

	public void Update(TiledArea area, Vector2 position)
	{
		leftTiles.Clear();
		rightTiles.Clear();
		topTiles.Clear();
		bottomTiles.Clear();
		CheckLeftRight(area, position);
		CheckTopBottom(area, position);
	}

	public bool IsTileLeft(int tileTypeID) => leftTiles.Contains(tileTypeID);
	public bool IsTileLeft(TileType tileType) => IsTileLeft((int)(object)tileType);

	public bool IsTileRight(int tileTypeID) => rightTiles.Contains(tileTypeID);
	public bool IsTileRight(TileType tileType) => IsTileRight((int)(object)tileType);

	public bool IsTileTop(int tileTypeID) => topTiles.Contains(tileTypeID);
	public bool IsTileTop(TileType tileType) => IsTileTop((int)(object)tileType);

	public bool IsTileBottom(int tileTypeID) => bottomTiles.Contains(tileTypeID);
	public bool IsTileBottom(TileType tileType) => IsTileBottom((int)(object)tileType);

	private void CheckTopBottom(TiledArea area, Vector2 position)
	{
		int leftX = (position.X).Floored();
		int centerX = leftX + halfWidth;
		int rightX = (position.X + width - 1).Floored();
		int topY = (position.Y - 1).Floored();
		int bottomY = (position.Y + height).Floored();

		CheckTop(area, position, leftX, centerX, rightX, topY);
		CheckBottom(area, position, leftX, centerX, rightX, bottomY);
	}

	private void CheckTop(TiledArea area, Vector2 position, int leftX, int centerX, int rightX, int topY)
	{
		TopInBounds = area.InBounds(leftX, topY) && area.InBounds(rightX, topY);
		if (!TopInBounds) return;

		TopCenterTile = (TileType)(object)area.GetTileTypeID(centerX, topY);
		for (int x = leftX; x <= rightX; x++)
		{
			int tileTypeID = area.GetTileTypeID(x, topY);
			topTiles.Add(tileTypeID);
		}
	}

	private void CheckBottom(TiledArea area, Vector2 position, int leftX, int centerX, int rightX, int bottomY)
	{
		BottomInBounds = area.InBounds(leftX, bottomY) && area.InBounds(rightX, bottomY);
		if (!BottomInBounds) return;

		BottomCenterTile = (TileType)(object)area.GetTileTypeID(centerX, bottomY);
		for (int x = leftX; x <= rightX; x++)
		{
			int tileTypeID = area.GetTileTypeID(x, bottomY);
			bottomTiles.Add(tileTypeID);
		}
	}

	private void CheckLeftRight(TiledArea area, Vector2 position)
	{
		int topY = (position.Y).Floored();
		int centerY = topY + halfHeight;
		int bottomY = (position.Y + height - 1).Floored();
		int leftX = (position.X - 1).Floored();
		int rightX = (position.X + width).Floored();

		CheckLeft(area, position, topY, centerY, bottomY, leftX);
		CheckRight(area, position, topY, centerY, bottomY, rightX);
	}

	private void CheckLeft(TiledArea area, Vector2 position, int topY, int centerY, int bottomY, int leftX)
	{
		LeftInBounds = area.InBounds(leftX, topY) && area.InBounds(leftX, bottomY);
		if (!LeftInBounds) return;

		LeftCenterTile = (TileType)(object)area.GetTileTypeID(leftX, centerY);
		for (int y = topY; y <= bottomY; y++)
		{
			int tileTypeID = area.GetTileTypeID(leftX, y);
			leftTiles.Add(tileTypeID);
		}
	}

	private void CheckRight(TiledArea area, Vector2 position, int topY, int centerY, int bottomY, int rightX)
	{
		RightInBounds = area.InBounds(rightX, topY) && area.InBounds(rightX, bottomY);
		if (!RightInBounds) return;

		RightCenterTile = (TileType)(object)area.GetTileTypeID(rightX, centerY);
		for (int y = topY; y <= bottomY; y++)
		{
			int tileTypeID = area.GetTileTypeID(rightX, y);
			rightTiles.Add(tileTypeID);
		}
	}
}
