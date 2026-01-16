using Clockwork.Utilities;
using Clockwork.Graphics;

using Clockwork.Graphics.Draw2D;

namespace Clockwork.Shapes;

public class PolygonShape : Entity, ITransform2D
{
	// General
	public Transform2D Transform { get; set; } = new();
	public int SideCount;
	public float Radius;
	public Color Color;

	public PolygonShape(float radius, int sideCount, Color color)
	{
		Radius = radius;
		SideCount = sideCount;
		Color = color;
	}

	public override void OnDraw()
	{
		Primitives2D.DrawPolygon(Transform.WorldPosition, SideCount, Radius, Transform.WorldRotation, Color);
	}
}