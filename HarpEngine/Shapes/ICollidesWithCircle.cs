namespace HarpEngine.Shapes;

public interface ICollidesWithCircle
{
	public bool CollidesWithCircle(Vector2 circlePosition, float circleRadius);
	public bool CollidesWithCircle(CircleShape circleShape);
}
