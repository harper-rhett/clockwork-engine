namespace HarpEngine.Shapes;

public interface IIntersectWithCircle
{
	public bool CollidesWithCircle(Vector2 circlePosition, float circleRadius);
	public bool CollidesWithCircle(CircleShape circleShape);
}
