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

	public int CenterX { get; private set; }
	public int CenterY { get; private set; }
	public int LeftX { get; private set; }
	public int RightX { get; private set; }
	public int TopY { get; private set; }
	public int BottomY { get; private set; }

	private HashSet<int> leftTiles = new();
	private HashSet<int> rightTiles = new();
	private HashSet<int> topTiles = new();
	private HashSet<int> bottomTiles = new();

	private readonly int width;
	private readonly int height;
	private readonly int halfWidth;
	private readonly int halfHeight;

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
		TopY = (position.Y - 1).Floored();
		BottomY = (position.Y + height).Floored();

		CheckTop(area, position, leftX, rightX);
		CheckBottom(area, position, leftX, rightX);
	}

	private void CheckTop(TiledArea area, Vector2 position, int leftX, int rightX)
	{
		TopInBounds = area.InBounds(CenterX, TopY);
		if (TopInBounds) TopCenterTile = area.GetTileType<TileType>(CenterX, TopY);
		for (int x = leftX; x <= rightX; x++)
		{
			if (!area.InBounds(x, TopY)) continue;
			int tileTypeID = area.GetTileTypeID(x, TopY);
			topTiles.Add(tileTypeID);
		}
	}

	private void CheckBottom(TiledArea area, Vector2 position, int leftX, int rightX)
	{
		BottomInBounds = area.InBounds(CenterX, BottomY);
		if (BottomInBounds) BottomCenterTile = area.GetTileType<TileType>(CenterX, BottomY);
		for (int x = leftX; x <= rightX; x++)
		{
			if (!area.InBounds(x, BottomY)) continue;
			int tileTypeID = area.GetTileTypeID(x, BottomY);
			bottomTiles.Add(tileTypeID);
		}
	}

	private void CheckLeftRight(TiledArea area, Vector2 position)
	{
		int topY = (position.Y).Floored();
		int bottomY = (position.Y + height - 1).Floored();
		LeftX = (position.X - 1).Floored();
		RightX = (position.X + width).Floored();

		CheckLeft(area, position, topY, bottomY);
		CheckRight(area, position, topY, bottomY);
	}

	private void CheckLeft(TiledArea area, Vector2 position, int topY, int bottomY)
	{
		LeftInBounds = area.InBounds(LeftX, CenterY);
		if (LeftInBounds) LeftCenterTile = area.GetTileType<TileType>(LeftX, CenterY);
		for (int y = topY; y <= bottomY; y++)
		{
			if (!area.InBounds(LeftX, y)) continue;
			int tileTypeID = area.GetTileTypeID(LeftX, y);
			leftTiles.Add(tileTypeID);
		}
	}

	private void CheckRight(TiledArea area, Vector2 position, int topY, int bottomY)
	{
		RightInBounds = area.InBounds(RightX, CenterY);
		if (RightInBounds) RightCenterTile = area.GetTileType<TileType>(RightX, CenterY);
		for (int y = topY; y <= bottomY; y++)
		{
			if (!area.InBounds(RightX, y)) continue;
			int tileTypeID = area.GetTileTypeID(RightX, y);
			rightTiles.Add(tileTypeID);
		}
	}
}
