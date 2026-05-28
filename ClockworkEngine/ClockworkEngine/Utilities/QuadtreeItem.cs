using System.Numerics;

namespace Clockwork.Utilities;

internal class QuadtreeItem<Type>
{
	public readonly Type Value;
	public readonly Vector2 Position;

	public QuadtreeItem(Type item, Vector2 position)
	{
		Value = item;
		Position = position;
	}
}
