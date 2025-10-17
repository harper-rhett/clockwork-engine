namespace HarpEngine.Shapes;

public interface ICollidesWithRectangle
{
	public bool CollidesWithRectangle(Rectangle rectangle);
	public bool CollidesWithRectangle(RectangleShape rectangleShape);
}
