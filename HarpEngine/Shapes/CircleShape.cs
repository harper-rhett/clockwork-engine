namespace HarpEngine.Shapes;

public class CircleShape : Entity, IIntersectWithPoint, IIntersectWithCircle, IIntersectWithRectangle
{
	public Transform2D Transform = new();
	public float Radius;
	public Color Color;

	public CircleShape(Scene scene, float radius, Color color) : base(scene)
	{
		Radius = radius;
		Color = color;
	}

	public override void Draw()
	{
		Primitives.DrawCircle(Transform.WorldPosition, Radius, Color);
	}

	public bool CollidesWithPoint(Vector2 position) => Intersection.PointInCircle(position, Transform.WorldPosition, Radius);

	public bool CollidesWithCircle(Vector2 position, float radius) => Intersection.CircleOnCircle(Transform.WorldPosition, Radius, position, radius);
	public bool CollidesWithCircle(CircleShape circleShape) => Intersection.CircleOnCircle(Transform.WorldPosition, Radius, circleShape.Transform.WorldPosition, circleShape.Radius);

	public bool CollidesWithRectangle(Rectangle rectangle) => Intersection.CircleOnRectangle(Transform.WorldPosition, Radius, rectangle);
	public bool CollidesWithRectangle(RectangleShape rectangleShape) => Intersection.CircleOnRectangle(Transform.WorldPosition, Radius, rectangleShape.Rectangle);
}
