using Clockwork.Graphics;
using Clockwork.Shapes;

namespace Clockwork.Intersections;

public interface IIntersectsWithRectangle
{
	public bool IntersectsWithRectangle(Rectangle rectangle);
	public bool IntersectsWithRectangle(RectangleShape rectangleShape) => IntersectsWithRectangle(rectangleShape.Rectangle);
}
