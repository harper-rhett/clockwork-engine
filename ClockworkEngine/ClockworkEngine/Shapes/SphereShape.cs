using Clockwork.Graphics.Draw3D;
using Clockwork.Utilities;
using System.Numerics;

namespace Clockwork.Shapes;

public class SphereShape : Entity
{
	public Transform3D Transform;
	public float Radius;
	private Mesh mesh;
	public Material Material;

	public SphereShape(Vector3 position, float radius)
	{
		Transform = new(position, Quaternion.Identity);
		mesh = Mesh.GenerateSphere(radius, 12, 12);
		Material = new();
	}

	public override void OnDraw()
	{
		mesh.Draw(Material, Transform);
	}
}
