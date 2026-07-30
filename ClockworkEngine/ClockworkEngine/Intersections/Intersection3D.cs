using System.Numerics;
using System.Runtime.InteropServices;
using Clockwork.Shapes;

namespace Clockwork.Intersections;

public static class Intersection3D
{
	[DllImport(Engine.raylibLibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetRayCollisionSphere")]
	public static extern RayCollision RayInSphereCollision(Ray ray, Vector3 spherePosition, float sphereRadius);

	public static bool RayInSphere(Ray ray, Vector3 spherePosition, float sphereRadius)
	{
		RayCollision rayCollision = RayInSphereCollision(ray, spherePosition, sphereRadius);
		return rayCollision.DidHit;
	}
}
