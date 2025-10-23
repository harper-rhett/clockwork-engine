namespace HarpEngine.Shapes;

public interface IIntersectWithRectangle
{
	public bool CollidesWithRectangle(Rectangle rectangle);
	public bool CollidesWithRectangle(RectangleShape rectangleShape);
}
