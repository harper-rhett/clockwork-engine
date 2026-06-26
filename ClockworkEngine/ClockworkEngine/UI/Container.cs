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

	private List<Element> childrenToAdd = new();
	private List<(int, Element)> childrenToInsert = new();
	private List<Element> childrenToRemove = new();

	public Container() : base() { }

	public Container(int x, int y, int width, int height) : base(x, y, width, height) { }
	public Container(int x, int y, int width, int height, Style style) : base(x, y, width, height, style) { }

	public Container(Vector2 position, Vector2 size) : base(position, size) { }
	public Container(Vector2 position, Vector2 size, Style style) : base(position, size, style) { }

	public void AddChild(Element element)
	{
		childrenToAdd.Add(element);
	}

	public void InsertChild(int index, Element element)
	{
		childrenToInsert.Add((index, element));
	}

	public void RemoveChild(Element element)
	{
		childrenToRemove.Add(element);
	}

	private void Refresh()
	{
		OnWidthUpdated();
		OnHeightUpdated();
		OnXUpdated();
		OnYUpdated();
	}

	public override void OnUpdate()
	{
		base.OnUpdate();
		bool addChildren = childrenToAdd.Count > 0;
		bool insertChildren = childrenToInsert.Count > 0;
		bool removeChildren = childrenToRemove.Count > 0;
		if (addChildren || insertChildren || removeChildren)
		{
			if (addChildren)
			{
				foreach (Element child in childrenToAdd) children.Add(child);
				childrenToAdd.Clear();
			}
			if (insertChildren)
			{
				foreach ((int, Element) child in childrenToInsert) children.Insert(child.Item1, child.Item2);
				childrenToInsert.Clear();
			}
			if (removeChildren)
			{
				foreach (Element child in childrenToRemove) children.Remove(child);
				childrenToRemove.Clear();
			}
			Refresh();
		}
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

	protected override void OnVisible()
	{
		foreach (Element child in children) child.Visible = true;
	}

	protected override void OnInvisible()
	{
		foreach (Element child in children) child.Visible = false;
	}
}
