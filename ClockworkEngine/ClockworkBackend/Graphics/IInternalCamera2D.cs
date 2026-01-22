using System.Numerics;

namespace Clockwork.Graphics;

public interface IInternalCamera2D
{
	public Vector2 Position { get; set; }
	public float Rotation { get; set; }
	public float Zoom { get; set; }
}