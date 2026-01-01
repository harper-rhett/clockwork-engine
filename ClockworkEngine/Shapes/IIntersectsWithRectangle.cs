namespace Clockwork.Shapes;

public interface IIntersectsWithRectangle
{
	public bool IntersectsWithRectangle(Rectangle rectangle);
	public bool IntersectsWithRectangle(RectangleShape rectangleShape) => IntersectsWithRectangle(rectangleShape.Rectangle);
}
