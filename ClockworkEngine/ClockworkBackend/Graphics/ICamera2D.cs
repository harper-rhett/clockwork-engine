using System.Numerics;

namespace Clockwork.Graphics;

public interface ICamera2D
{
	public abstract Vector2 Position { get; set; }
	public abstract Vector2 Offset { get; set; }
	public abstract float Rotation { get; set; }
	public abstract float Zoom { get; set; }
}