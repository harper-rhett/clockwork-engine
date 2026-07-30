using System.Numerics;
using Clockwork.Shapes;

namespace Clockwork.Intersections;

public interface IIntersectsWithPoint
{
	public bool IntersectsWithPoint(Vector2 pointPosition);
	public bool IntersectsWithPoint(PointShape pointShape) => IntersectsWithPoint(pointShape.Transform.WorldPosition);
}
