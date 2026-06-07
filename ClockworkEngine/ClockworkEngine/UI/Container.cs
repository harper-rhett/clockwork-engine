using System.Collections.Generic;
using System.Numerics;

namespace Clockwork.UI;

public class Container : Element
{
	private readonly List<Element> children = new();
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

	public Container(Vector2 position, Vector2 size) : base(position, size) { }

	public void AddChild(Element element)
	{
		element.DrawLayer = DrawLayer + 1;
		children.Add(element);
		Refresh();
	}

	private void Refresh()
	{
		OnXUpdated();
		OnYUpdated();
		OnWidthUpdated();
		OnHeightUpdated();
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
}
