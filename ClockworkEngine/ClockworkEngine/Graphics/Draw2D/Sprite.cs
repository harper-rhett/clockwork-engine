using Clockwork.Utilities;
using System.Numerics;

namespace Clockwork.Graphics.Draw2D;

public class Sprite
{
	// Interface
	public Transform2D Transform = new();
	public Vector2 Origin;
	public Color Color = Colors.White;

	// Shortcuts
	public int Width => texture.Width;
	public int Height => texture.Height;
	public float HalfWidth { get; private set; }
	public float HalfHeight { get; private set; }
	public float ScaledWidth => WorldRectangle.Width;
	public float ScaledHeight => WorldRectangle.Height;
	public float HalfScaledWidth { get; private set; }
	public float HalfScaledHeight { get; private set; }
	public Rectangle WorldRectangle { get; private set; }

	// General
	private Texture texture;
	private Rectangle TextureRectangle;

	// Transform shortcuts
	public Vector2 Position
	{
		get => Transform.Position;
		set => Transform.Position = value;
	}
	public float Rotation
	{
		get => Transform.WorldRotation;
		set => Transform.WorldRotation = value;
	}

	// Scale
	private Vector2 scale;
	public Vector2 Scale
	{
		get => scale;
		set
		{
			scale = value;
			WorldRectangle = new(Position, ScaledWidth, ScaledHeight);
			HalfScaledWidth = WorldRectangle.Width / 2f;
			HalfScaledHeight = WorldRectangle.Height / 2f;
			Offset = spriteOffset;
		}
	}

	// Offset
	private SpriteOffset spriteOffset;
	public SpriteOffset Offset
	{
		get => spriteOffset;
		set
		{
			spriteOffset = value;
			Origin = spriteOffset switch
			{
				SpriteOffset.TopLeft => Vector2.Zero,
				SpriteOffset.LeftCenter => new Vector2(0, HalfScaledHeight),
				SpriteOffset.BottomLeft => new Vector2(0, ScaledHeight),
				SpriteOffset.BottomCenter => new Vector2(HalfScaledWidth, ScaledHeight),
				SpriteOffset.BottomRight => new Vector2(ScaledWidth, ScaledHeight),
				SpriteOffset.RightCenter => new Vector2(ScaledWidth, HalfScaledHeight),
				SpriteOffset.TopRight => new Vector2(ScaledWidth, 0),
				SpriteOffset.TopCenter => new Vector2(HalfScaledWidth, 0),
				SpriteOffset.Center => new Vector2(HalfScaledWidth, HalfScaledHeight),
				_ => Vector2.Zero,
			};
		}
	}

	public Sprite(string filePath)
	{
		LoadTexture(filePath);
	}

	public Sprite(string filePath, Vector2 position, float rotation)
	{
		Position = position;
		Rotation = rotation;
		LoadTexture(filePath);
	}

	public void LoadTexture(string filePath)
	{
		texture = Texture.Load(filePath);
		HalfWidth = texture.Width / 2f;
		HalfHeight = texture.Height / 2f;
		TextureRectangle = new(Vector2.Zero, Width, Height);
		WorldRectangle = new(Position, Width, Height);
	}

	public void Draw()
	{
		WorldRectangle = new(Position, Width, Height);
		texture.Draw(TextureRectangle, WorldRectangle, Origin, Rotation, Color);
	}
}
