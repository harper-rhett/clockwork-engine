using System.Numerics;
using System.Runtime.InteropServices;

namespace Clockwork.Shapes;

public static class Intersection3D
{
	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetRayCollisionSphere")]
	public static extern RayCollision RayInSphereCollision(Ray ray, Vector3 spherePosition, float sphereRadius);

	public static bool RayInSphere(Ray ray, Vector3 spherePosition, float sphereRadius)
	{
		RayCollision rayCollision = RayInSphereCollision(ray, spherePosition, sphereRadius);
		return rayCollision.DidHit;
	}
}
