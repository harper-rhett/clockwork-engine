namespace HarpEngine.Shapes;

public class CircleShape : Entity, ICollidesWithPoint, ICollidesWithCircle, ICollidesWithRectangle
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

	public bool CollidesWithPoint(Vector2 position) => Collision.PointInCircle(position, Transform.WorldPosition, Radius);

	public bool CollidesWithCircle(Vector2 position, float radius) => Collision.CircleOnCircle(Transform.WorldPosition, Radius, position, radius);
	public bool CollidesWithCircle(CircleShape circleShape) => Collision.CircleOnCircle(Transform.WorldPosition, Radius, circleShape.Transform.WorldPosition, circleShape.Radius);

	public bool CollidesWithRectangle(Rectangle rectangle) => Collision.CircleOnRectangle(Transform.WorldPosition, Radius, rectangle);
	public bool CollidesWithRectangle(RectangleShape rectangleShape) => Collision.CircleOnRectangle(Transform.WorldPosition, Radius, rectangleShape.Rectangle);
}
