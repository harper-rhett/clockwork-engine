using System.Numerics;

namespace Clockwork.Utilities;

internal struct QuadtreePoint<Type>
{
	public readonly Type Item;
	public readonly Vector2 Position;

	public QuadtreePoint(Type item, Vector2 position)
	{
		Item = item;
		Position = position;
	}
}
