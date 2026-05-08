using Clockwork.Utilities;
using Clockwork.Graphics;

using Clockwork.Graphics.Draw2D;
using System.Numerics;

namespace Clockwork.Shapes;

public class PolygonShape : Entity
{
	// General
	public Transform2D Transform { get; set; } = new();
	public int SideCount;
	public float Radius;
	public Color Color;

	// Transform shortcuts
	public Vector2 Position
	{
		get => Transform.WorldPosition;
		set => Transform.WorldPosition = value;
	}
	public float Rotation
	{
		get => Transform.WorldRotation;
		set => Transform.WorldRotation = value;
	}

	public PolygonShape(float radius, int sideCount, Color color)
	{
		Radius = radius;
		SideCount = sideCount;
		Color = color;
	}

	public override void OnDraw()
	{
		Primitives2D.DrawPolygon(Position, SideCount, Radius, Rotation, Color);
	}
}