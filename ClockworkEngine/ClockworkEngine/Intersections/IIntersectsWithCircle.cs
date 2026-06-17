using System.Numerics;
using Clockwork.Shapes;

namespace Clockwork.Intersections;

public interface IIntersectsWithCircle
{
	public bool IntersectsWithCircle(Vector2 circlePosition, float circleRadius);
	public bool IntersectsWithCircle(CircleShape circleShape) => IntersectsWithCircle(circleShape.Transform.WorldPosition, circleShape.Radius);
}
