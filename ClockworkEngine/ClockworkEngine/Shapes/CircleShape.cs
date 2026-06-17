using System.Numerics;
using Clockwork.Utilities;
using Clockwork.Graphics;
using Clockwork.Graphics.Draw2D;
using Clockwork.Intersections;

namespace Clockwork.Shapes;

public class CircleShape : Entity, IIntersectsWithPoint, IIntersectsWithCircle, IIntersectsWithRectangle, IIntersectsWithLine
{
	public Transform2D Transform { get; set; } = new();
	public float Radius;
	public int Segments = 36;
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

	public CircleShape(float radius, Color color)
	{
		Radius = radius;
		Color = color;
	}

	public override void OnDraw()
	{
		Primitives2D.DrawCircle(Position, Radius, Segments, Color);
	}

	public bool IntersectsWithPoint(Vector2 position) => Intersection2D.PointInCircle(position, Position, Radius);
	public bool IntersectsWithCircle(Vector2 position, float radius) => Intersection2D.CircleOnCircle(Position, Radius, position, radius);
	public bool IntersectsWithRectangle(Rectangle rectangle) => Intersection2D.CircleOnRectangle(Position, Radius, rectangle);
	public bool IntersectsWithLine(Vector2 lineStartPosition, Vector2 lineEndPosition) => Intersection2D.CircleOnLine(Position, Radius, lineStartPosition, lineEndPosition);
}
