using System.Numerics;

namespace Clockwork.Utilities;

public interface ITranslation2D
{
	public Vector2 WorldPosition { get; set; }
	public Vector2 LocalPosition { get; set; }
}
