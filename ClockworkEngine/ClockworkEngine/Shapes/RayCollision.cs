using System.Numerics;
using System.Runtime.InteropServices;

namespace Clockwork.Shapes;

[StructLayout(LayoutKind.Sequential)]
public struct RayCollision
{
	[MarshalAs(UnmanagedType.I1)] public bool DidHit;
	public float Distance;
	public Vector3 Point;
	public Vector3 Normal;
}