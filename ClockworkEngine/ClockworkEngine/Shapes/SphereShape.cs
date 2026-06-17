using Clockwork.Graphics;
using Clockwork.Graphics.Draw3D;
using Clockwork.Utilities;
using System.Numerics;
using Clockwork.Intersections;

namespace Clockwork.Shapes;

public class SphereShape : Entity, IIntersectsWithRay
{
	public Transform3D Transform;
	public float Radius;
	public Color Color;

	public unsafe SphereShape(Vector3 position, float radius, Color color)
	{
		Transform = new(position, Quaternion.Identity);
		Radius = radius;
		Color = color;
	}

	public override void OnDraw()
	{
		Primitives3D.DrawSphere(Transform.WorldPosition, Radius, Color);
	}

	public bool IntersectsWithRay(Ray ray)
	{
		return Intersection3D.RayInSphere(ray, Transform.WorldPosition, Radius);
	}
}
