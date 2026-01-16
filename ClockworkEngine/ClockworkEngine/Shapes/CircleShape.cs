using System.Numerics;
using Clockwork.Utilities;
using Clockwork.Graphics;
using Clockwork.Graphics.Draw2D;

namespace Clockwork.Shapes;

public class CircleShape : Entity, ITransform2D, IIntersectsWithPoint, IIntersectsWithCircle, IIntersectsWithRectangle, IIntersectsWithLine
{
	public Transform2D Transform { get; set; } = new();
	public float Radius;
	public Color Color;

	public CircleShape(float radius, Color color)
	{
		Radius = radius;
		Color = color;
	}

	public override void OnDraw()
	{
		Primitives2D.DrawCircle(Transform.WorldPosition, Radius, Color);
	}

	public bool IntersectsWithPoint(Vector2 position) => Intersection.PointInCircle(position, Transform.WorldPosition, Radius);
	public bool IntersectsWithCircle(Vector2 position, float radius) => Intersection.CircleOnCircle(Transform.WorldPosition, Radius, position, radius);
	public bool IntersectsWithRectangle(Rectangle rectangle) => Intersection.CircleOnRectangle(Transform.WorldPosition, Radius, rectangle);
	public bool IntersectsWithLine(Vector2 lineStartPosition, Vector2 lineEndPosition) => Intersection.CircleOnLine(Transform.WorldPosition, Radius, lineStartPosition, lineEndPosition);
}
