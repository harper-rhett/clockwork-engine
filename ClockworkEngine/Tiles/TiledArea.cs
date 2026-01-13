namespace Clockwork.Tiles;

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

	public virtual bool IsActive { get; set; }

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

	public void Draw()
	{
		if (!IsActive) return;
		renderTexture.Texture.Draw(renderRectangle, Position, Colors.White);
	}

	private void ProcessTexture(Tile[] tiles)
	{
		RenderTexture.BeginDrawing(renderTexture);
		foreach (Tile tile in tiles) tile.Draw();
		RenderTexture.EndDrawing();
	}
}
