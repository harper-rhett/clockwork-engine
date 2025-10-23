namespace HarpEngine.Shapes;

public class RectangleShape : Entity, IIntersectWithPoint, IIntersectWithCircle, IIntersectWithRectangle
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

	public bool CollidesWithPoint(Vector2 position) => Intersection.PointInRectangle(position, Rectangle);

	public bool CollidesWithRectangle(Rectangle rectangle) => Intersection.RectangleOnRectangle(Rectangle, rectangle);
	public bool CollidesWithRectangle(RectangleShape rectangleShape) => Intersection.RectangleOnRectangle(Rectangle, rectangleShape.Rectangle);

	public bool CollidesWithCircle(Vector2 circlePosition, float circleRadius) => Intersection.CircleOnRectangle(circlePosition, circleRadius, Rectangle);
	public bool CollidesWithCircle(CircleShape circleShape) => Intersection.CircleOnRectangle(circleShape.Transform.WorldPosition, circleShape.Radius, Rectangle);
}
