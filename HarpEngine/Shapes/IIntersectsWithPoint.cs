namespace HarpEngine.Shapes;

public interface IIntersectsWithPoint
{
	public bool IntersectsWithPoint(Vector2 pointPosition);
	public bool IntersectsWithPoint(PointShape pointShape) => IntersectsWithPoint(pointShape.Transform.WorldPosition);
}
