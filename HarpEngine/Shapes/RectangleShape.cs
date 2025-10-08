namespace HarpEngine.Shapes;

public class RectangleShape : Entity
{
	public Transform2D Transform = new();
	public Vector2 Origin = Vector2.Zero;
	public int Width;
	public int Height;
	public Color Color;
	public Rectangle Rectangle => new(Transform.WorldPosition, Width, Height);

	public RectangleShape(Scene scene, int width, int height, Color color) : base(scene)
	{
		Width = width;
		Height = height;
		Color = color;
	}

	public override void Draw()
	{
		Primitives.DrawRectangle(Rectangle, Origin, Transform.WorldRotation, Color);
	}

	public bool CollidesWith(Rectangle rectangle) => Collision.RectangleOnRectangle(Rectangle, rectangle);
	public bool CollidesWith(RectangleShape rectangleShape) => Collision.RectangleOnRectangle(Rectangle, rectangleShape.Rectangle);
}
