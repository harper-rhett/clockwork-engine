namespace Clockwork.Shapes;

public class LineShape : Entity, IIntersectsWithPoint, IIntersectsWithCircle, IIntersectsWithRectangle, IIntersectsWithLine
{
	public Vector2 StartPosition;
	public Vector2 EndPosition;
	public float Thickness;
	public Color Color;

	public LineShape(float thickness, Color color)
	{
		Thickness = thickness;
		Color = color;
	}

	public override void OnDraw()
	{
		Primitives.DrawLine(StartPosition, EndPosition, Thickness, Color);
	}

	public bool IntersectsWithPoint(Vector2 pointPosition) => Intersection.PointOnLine(pointPosition, StartPosition, EndPosition, 0.1f);
	public bool IntersectsWithCircle(Vector2 circlePosition, float circleRadius) => Intersection.CircleOnLine(circlePosition, circleRadius, StartPosition, EndPosition);
	public bool IntersectsWithRectangle(Rectangle rectangle) => Intersection.LineOnRectangle(StartPosition, EndPosition, rectangle);
	public bool IntersectsWithLine(Vector2 lineStartPosition, Vector2 lineEndPosition) => Intersection.LineOnLine(StartPosition, EndPosition, lineStartPosition, lineEndPosition);
}
