using System.Numerics;
using Clockwork.Utilities;
using Clockwork.Graphics;
using Clockwork.Graphics.Draw2D;
using Clockwork.Intersections;

namespace Clockwork.Shapes;

public class PointShape : Entity, IIntersectsWithCircle, IIntersectsWithRectangle, IIntersectsWithLine
{
	public Transform2D Transform { get; set; } = new();
	public Color Color;

	// Transform shortcuts
	public Vector2 Position
	{
		get => Transform.Position;
		set => Transform.Position = value;
	}
	public float Rotation
	{
		get => Transform.Rotation;
		set => Transform.Rotation = value;
	}

	public PointShape(Color color)
	{
		Color = color;
	}

	public override void OnDraw()
	{
		Primitives2D.DrawPixel(Position, Color);
	}

	public bool IntersectsWithCircle(Vector2 circlePosition, float circleRadius) => Intersection2D.PointInCircle(Position, circlePosition, circleRadius);
	public bool IntersectsWithRectangle(Rectangle rectangle) => Intersection2D.PointInRectangle(Position, rectangle);
	public bool IntersectsWithLine(Vector2 lineStartPosition, Vector2 lineEndPosition) => Intersection2D.PointOnLine(Position, lineStartPosition, lineEndPosition, 0.1f);
}
