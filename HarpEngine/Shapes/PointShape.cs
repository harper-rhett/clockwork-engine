namespace HarpEngine.Shapes;

public class PointShape : Entity, IIntersectWithCircle, IIntersectWithRectangle
{
	public Vector2 Position;
	public Color Color;

	public PointShape(Scene scene, Color color) : base(scene)
	{
		Color = color;
	}

	public bool CollidesWithCircle(Vector2 circlePosition, float circleRadius) => Intersection.PointInCircle(Position, circlePosition, circleRadius);
	public bool CollidesWithCircle(CircleShape circleShape) => Intersection.PointInCircle(Position, circleShape.Transform.WorldPosition, circleShape.Radius);
	public bool CollidesWithRectangle(Rectangle rectangle) => Intersection.PointInRectangle(Position, rectangle);
	public bool CollidesWithRectangle(RectangleShape rectangleShape) => Intersection.PointInRectangle(Position, rectangleShape.Rectangle);

	public override void Draw()
	{
		Primitives.DrawPixel(Position, Color);
	}
}
