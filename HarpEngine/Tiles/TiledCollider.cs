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

	private HashSet<int> innerTiles = new();
	private HashSet<int> leftTiles = new();
	private HashSet<int> rightTiles = new();
	private HashSet<int> topTiles = new();
	private HashSet<int> bottomTiles = new();

	public readonly int Width;
	public readonly int Height;
	public readonly int HalfWidth;
	public readonly int HalfHeight;

	public TiledCollider(int width, int height)
	{
		Width = width;
		Height = height;
		HalfWidth = width / 2;
		HalfHeight = height / 2;
	}

	public void Update(TiledArea area, Vector2 position)
	{
		// Reset hash sets
		leftTiles.Clear();
		rightTiles.Clear();
		topTiles.Clear();
		bottomTiles.Clear();
		innerTiles.Clear();

		// Update collisions
		CenterX = position.X.Floored() + HalfWidth;
		CenterY = position.Y.Floored() + HalfHeight;
		UpdateCenter(area, position);
		UpdateLeftRight(area, position);
		UpdateTopBottom(area, position);
	}

	public void Draw(Vector2 position, Color color)
	{
		Primitives.DrawRectangle(position, new(Width, Height), color.SetAlpha(0.5f));
		Primitives.DrawPixel(CenterX, CenterY, color);
	}

	public bool IsTileInner(int tileTypeID) => innerTiles.Contains(tileTypeID);
	public bool IsTileInner(TileType tileType) => IsTileInner((int)(object)tileType);

	public bool IsTileLeft(int tileTypeID) => leftTiles.Contains(tileTypeID);
	public bool IsTileLeft(TileType tileType) => IsTileLeft((int)(object)tileType);

	public bool IsTileRight(int tileTypeID) => rightTiles.Contains(tileTypeID);
	public bool IsTileRight(TileType tileType) => IsTileRight((int)(object)tileType);

	public bool IsTileTop(int tileTypeID) => topTiles.Contains(tileTypeID);
	public bool IsTileTop(TileType tileType) => IsTileTop((int)(object)tileType);

	public bool IsTileBottom(int tileTypeID) => bottomTiles.Contains(tileTypeID);
	public bool IsTileBottom(TileType tileType) => IsTileBottom((int)(object)tileType);

	private void UpdateCenter(TiledArea area, Vector2 position)
	{
		CenterInBounds = area.InBounds(CenterX, CenterY);
		if (CenterInBounds) CenterTile = area.GetTileType<TileType>(CenterX, CenterY);
		CheckInner(area, position);
	}

	private void CheckInner(TiledArea area, Vector2 position)
	{
		int xPosition = position.X.Floored();
		int yPosition = position.Y.Floored();
		for (int xOffset = 0; xOffset < Width; xOffset++)
			for (int yOffset = 0; yOffset < Height; yOffset++)
			{
				int x = xPosition + xOffset;
				int y = yPosition + yOffset;
				if (!area.InBounds(x, y)) continue;
				int tileTypeID = area.GetTileTypeID(x, y);
				innerTiles.Add(tileTypeID);
			}
	}

	private void UpdateTopBottom(TiledArea area, Vector2 position)
	{
		int leftX = (position.X).Floored();
		int rightX = (position.X + Width - 1).Floored();
		TopY = (position.Y - 1).Floored();
		BottomY = (position.Y + Height).Floored();

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

	private void UpdateLeftRight(TiledArea area, Vector2 position)
	{
		int topY = (position.Y).Floored();
		int bottomY = (position.Y + Height - 1).Floored();
		LeftX = (position.X - 1).Floored();
		RightX = (position.X + Width).Floored();

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
