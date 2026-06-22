using System.Collections.Generic;
using System.Numerics;

namespace Clockwork.UI;

public class Container : Element
{
	protected readonly List<Element> children = new();
	public IReadOnlyList<Element> Children => children;
	public int Padding
	{
		set
		{
			PaddingLeft = value;
			PaddingRight = value;
			PaddingTop = value;
			PaddingBottom = value;
		}
	}
	public int PaddingLeft;
	public int PaddingRight;
	public int PaddingTop;
	public int PaddingBottom;

	public Container() : base() { }

	public Container(int x, int y, int width, int height) : base(x, y, width, height) { }
	public Container(int x, int y, int width, int height, Style style) : base(x, y, width, height, style) { }

	public Container(Vector2 position, Vector2 size) : base(position, size) { }
	public Container(Vector2 position, Vector2 size, Style style) : base(position, size, style) { }

	public void AddChild(Element element)
	{
		children.Add(element);

		OnWidthUpdated();
		OnHeightUpdated();
		OnXUpdated();
		OnYUpdated();
	}

	public override void OnUpdate()
	{
		base.OnUpdate();
		foreach (Element child in children) child.OnUpdate();
	}

	public override void OnDraw()
	{
		base.OnDraw();
		foreach (Element child in children) child.OnDraw();
	}

	protected override void OnXUpdated()
	{
		foreach (Element child in children) child.X = X + PaddingLeft;
	}

	protected override void OnYUpdated()
	{
		foreach (Element child in children) child.Y = Y + PaddingTop;
	}

	protected override void OnWidthUpdated()
	{
		foreach (Element child in children) child.Width = Width - PaddingLeft - PaddingRight;
	}

	protected override void OnHeightUpdated()
	{
		foreach (Element child in children) child.Height = Height - PaddingTop - PaddingBottom;
	}

	protected override void OnEnabled()
	{
		foreach (Element child in children) child.Enabled = true;
	}

	protected override void OnDisabled()
	{
		foreach (Element child in children) child.Enabled = false;
	}
}
