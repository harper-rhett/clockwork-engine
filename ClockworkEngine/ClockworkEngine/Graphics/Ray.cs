using System.Runtime.InteropServices;
using System.Numerics;

[StructLayout(LayoutKind.Sequential)]
public struct Ray
{
	public Vector3 Position;
	public Vector3 Direction;

	public Ray(Vector3 position, Vector3 direction)
	{
		Position = position;
		Direction = direction;
	}
}