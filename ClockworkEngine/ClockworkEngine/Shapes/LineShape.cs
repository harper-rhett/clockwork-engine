using System.Numerics;
using Clockwork.Graphics;
using Clockwork.Graphics.Draw2D;
using Clockwork.Intersections;

namespace Clockwork.Shapes;

public class LineShape : Entity, IIntersectsWithPoint, IIntersectsWithCircle, IIntersectsWithRectangle, IIntersectsWithLine
{
	public virtual Vector2 StartPosition { get; protected set; }
	public virtual Vector2 EndPosition { get; protected set; }
	public float Thickness;
	public Color Color;

	public LineShape(float thickness, Color color)
	{
		Thickness = thickness;
		Color = color;
	}

	public override void OnDraw()
	{
		Primitives2D.DrawLine(StartPosition, EndPosition, Thickness, Color);
	}

	public bool IntersectsWithPoint(Vector2 pointPosition) => Intersection2D.PointOnLine(pointPosition, StartPosition, EndPosition, 0.1f);
	public bool IntersectsWithCircle(Vector2 circlePosition, float circleRadius) => Intersection2D.CircleOnLine(circlePosition, circleRadius, StartPosition, EndPosition);
	public bool IntersectsWithRectangle(Rectangle rectangle) => Intersection2D.LineOnRectangle(StartPosition, EndPosition, rectangle);
	public bool IntersectsWithLine(Vector2 lineStartPosition, Vector2 lineEndPosition) => Intersection2D.LineOnLine(StartPosition, EndPosition, lineStartPosition, lineEndPosition);
}
