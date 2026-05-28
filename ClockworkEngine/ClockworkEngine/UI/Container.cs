using System.Collections.Generic;
using System.Numerics;

namespace Clockwork.UI;

public class Container : Element
{
	public readonly List<Element> Children = new();
	public int Padding;

	public Container() : base() { }

	public Container(int x, int y, int width, int height) : base(x, y, width, height) { }

	public Container(Vector2 position, Vector2 size) : base(position, size) { }

	public override void OnUpdate()
	{
		base.OnUpdate();
	}

	public override void OnDraw()
	{
		base.OnDraw();
		// need to draw children on top
	}
}
