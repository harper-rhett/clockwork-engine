using Clockwork.Graphics.Draw2D;
using Clockwork.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Clockwork.Shapes;

public class SpriteShape : Entity
{
	public Transform2D Transform = new();
	public Vector2 Position
	{
		get => Transform.Position;
		set => Transform.Position = value;
	}
	public float Rotation
	{
		get => Transform.Rotation;
		set => Transform.Rotation = value;
	}
	public Sprite Sprite;

	public SpriteShape(string filePath)
	{
		Sprite = new(filePath);
		Sprite.Transform.Parent = Transform;
	}

	public override void OnDraw()
	{
		Sprite.Draw();
	}
}
