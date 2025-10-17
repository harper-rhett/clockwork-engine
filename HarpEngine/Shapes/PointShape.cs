namespace HarpEngine.Shapes;

public class PointShape : Entity, ICollidesWithCircle, ICollidesWithRectangle
{
	public Vector2 Position;
	public Color Color;

	public PointShape(Scene scene, Color color) : base(scene)
	{
		Color = color;
	}

	public bool CollidesWithCircle(Vector2 circlePosition, float circleRadius) => Collision.PointInCircle(Position, circlePosition, circleRadius);
	public bool CollidesWithCircle(CircleShape circleShape) => Collision.PointInCircle(Position, circleShape.Transform.WorldPosition, circleShape.Radius);
	public bool CollidesWithRectangle(Rectangle rectangle) => Collision.PointInRectangle(Position, rectangle);
	public bool CollidesWithRectangle(RectangleShape rectangleShape) => Collision.PointInRectangle(Position, rectangleShape.Rectangle);

	public override void Draw()
	{
		Primitives.DrawPixel(Position, Color);
	}
}
