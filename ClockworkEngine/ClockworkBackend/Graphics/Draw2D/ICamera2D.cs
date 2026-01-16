using System.Numerics;

namespace Clockwork.Graphics.Draw2D;

public interface ICamera2D
{
	public Vector2 Position { get; set; }
	public float Rotation { get; set; }
	public float Zoom { get; set; }
}