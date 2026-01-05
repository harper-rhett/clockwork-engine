using System.Numerics;

namespace Clockwork.Shapes;

public interface IIntersectsWithLine
{
	public bool IntersectsWithLine(Vector2 lineStartPosition, Vector2 lineEndPosition);
	public bool IntersectsWithLine(LineShape lineShape) => IntersectsWithLine(lineShape.StartPosition, lineShape.EndPosition);
}
