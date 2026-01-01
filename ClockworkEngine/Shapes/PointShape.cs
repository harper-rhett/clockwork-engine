namespace Clockwork.Shapes;

public class PointShape : Entity, IIntersectsWithCircle, IIntersectsWithRectangle, IIntersectsWithLine
{
	public Transform2D Transform { get; set; } = new();
	public Color Color;

	public PointShape(Color color)
	{
		Color = color;
	}

	public override void OnDraw()
	{
		Primitives.DrawPixel(Transform.WorldPosition, Color);
	}

	public bool IntersectsWithCircle(Vector2 circlePosition, float circleRadius) => Intersection.PointInCircle(Transform.WorldPosition, circlePosition, circleRadius);
	public bool IntersectsWithRectangle(Rectangle rectangle) => Intersection.PointInRectangle(Transform.WorldPosition, rectangle);
	public bool IntersectsWithLine(Vector2 lineStartPosition, Vector2 lineEndPosition) => Intersection.PointOnLine(Transform.WorldPosition, lineStartPosition, lineEndPosition, 0.1f);
}
