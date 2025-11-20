namespace HarpEngine.Tiles;

public class TiledCollider<TileType> where TileType : Enum
{
	public bool CenterInBounds { get; set; }
	public bool LeftInBounds { get; private set; }
	public bool RightInBounds { get; private set; }
	public bool TopInBounds { get; private set; }
	public bool BottomInBounds { get; private set; }

	public TileType CenterTile { get; private set; }
	public TileType LeftCenterTile { get; private set; }
	public TileType RightCenterTile { get; private set; }
	public TileType TopCenterTile { get; private set; }
	public TileType BottomCenterTile { get; private set; }

	private HashSet<int> leftTiles = new();
	private HashSet<int> rightTiles = new();
	private HashSet<int> topTiles = new();
	private HashSet<int> bottomTiles = new();

	private readonly int width;
	private readonly int height;
	private readonly int halfWidth;
	private readonly int halfHeight;
	public int CenterX { get; private set; }
	public int CenterY { get; private set; }

	public TiledCollider(int width, int height)
	{
		this.width = width;
		this.height = height;
		halfWidth = width / 2;
		halfHeight = height / 2;
	}

	public void Update(TiledArea area, Vector2 position)
	{
		// Reset hash sets
		leftTiles.Clear();
		rightTiles.Clear();
		topTiles.Clear();
		bottomTiles.Clear();

		// Update collisions
		CenterX = position.X.Floored() + halfWidth;
		CenterY = position.Y.Floored() + halfHeight;
		CheckCenter(area, position);
		CheckLeftRight(area, position);
		CheckTopBottom(area, position);
	}

	public void Draw(Vector2 position, Color color)
	{
		Primitives.DrawRectangle(position, new(width, height), color.SetAlpha(0.5f));
		Primitives.DrawPixel(CenterX, CenterY, color);
	}

	public bool IsTileLeft(int tileTypeID) => leftTiles.Contains(tileTypeID);
	public bool IsTileLeft(TileType tileType) => IsTileLeft((int)(object)tileType);

	public bool IsTileRight(int tileTypeID) => rightTiles.Contains(tileTypeID);
	public bool IsTileRight(TileType tileType) => IsTileRight((int)(object)tileType);

	public bool IsTileTop(int tileTypeID) => topTiles.Contains(tileTypeID);
	public bool IsTileTop(TileType tileType) => IsTileTop((int)(object)tileType);

	public bool IsTileBottom(int tileTypeID) => bottomTiles.Contains(tileTypeID);
	public bool IsTileBottom(TileType tileType) => IsTileBottom((int)(object)tileType);

	private void CheckCenter(TiledArea area, Vector2 position)
	{
		CenterInBounds = area.InBounds(CenterX, CenterY);
		if (!CenterInBounds) return;
		CenterTile = area.GetTileType<TileType>(CenterX, CenterY);
	}

	private void CheckTopBottom(TiledArea area, Vector2 position)
	{
		int leftX = (position.X).Floored();
		int rightX = (position.X + width - 1).Floored();
		int topY = (position.Y - 1).Floored();
		int bottomY = (position.Y + height).Floored();

		CheckTop(area, position, leftX, rightX, topY);
		CheckBottom(area, position, leftX, rightX, bottomY);
	}

	private void CheckTop(TiledArea area, Vector2 position, int leftX, int rightX, int topY)
	{
		TopInBounds = area.InBounds(CenterX, topY);
		if (TopInBounds) TopCenterTile = area.GetTileType<TileType>(CenterX, topY);
		for (int x = leftX; x <= rightX; x++)
		{
			if (!area.InBounds(x, topY)) continue;
			int tileTypeID = area.GetTileTypeID(x, topY);
			topTiles.Add(tileTypeID);
		}
	}

	private void CheckBottom(TiledArea area, Vector2 position, int leftX, int rightX, int bottomY)
	{
		BottomInBounds = area.InBounds(CenterX, bottomY);
		if (BottomInBounds) BottomCenterTile = area.GetTileType<TileType>(CenterX, bottomY);
		for (int x = leftX; x <= rightX; x++)
		{
			if (!area.InBounds(x, bottomY)) continue;
			int tileTypeID = area.GetTileTypeID(x, bottomY);
			bottomTiles.Add(tileTypeID);
		}
	}

	private void CheckLeftRight(TiledArea area, Vector2 position)
	{
		int topY = (position.Y).Floored();
		int bottomY = (position.Y + height - 1).Floored();
		int leftX = (position.X - 1).Floored();
		int rightX = (position.X + width).Floored();

		CheckLeft(area, position, topY, bottomY, leftX);
		CheckRight(area, position, topY, bottomY, rightX);
	}

	private void CheckLeft(TiledArea area, Vector2 position, int topY, int bottomY, int leftX)
	{
		LeftInBounds = area.InBounds(leftX, CenterY);
		if (LeftInBounds) LeftCenterTile = area.GetTileType<TileType>(leftX, CenterY);
		for (int y = topY; y <= bottomY; y++)
		{
			if (!area.InBounds(leftX, y)) continue;
			int tileTypeID = area.GetTileTypeID(leftX, y);
			leftTiles.Add(tileTypeID);
		}
	}

	private void CheckRight(TiledArea area, Vector2 position, int topY, int bottomY, int rightX)
	{
		RightInBounds = area.InBounds(rightX, CenterY);
		if (RightInBounds) RightCenterTile = area.GetTileType<TileType>(rightX, CenterY);
		for (int y = topY; y <= bottomY; y++)
		{
			if (!area.InBounds(rightX, y)) continue;
			int tileTypeID = area.GetTileTypeID(rightX, y);
			rightTiles.Add(tileTypeID);
		}
	}
}
