using System.Numerics;

namespace Clockwork.UI;

public class HorizontalStackContainer : Container
{
	public int Spacing;
	public bool StretchChildrenWidth;

	public HorizontalStackContainer() : base() { }

	public HorizontalStackContainer(int x, int y, int width, int height) : base(x, y, width, height) { }
	public HorizontalStackContainer(int x, int y, int width, int height, Style style) : base(x, y, width, height, style) { }

	public HorizontalStackContainer(Vector2 position, Vector2 size) : base(position, size) { }
	public HorizontalStackContainer(Vector2 position, Vector2 size, Style style) : base(position, size, style) { }

	protected override void OnXUpdated()
	{
		int xOffset = 0;
		for (int childIndex = 0; childIndex < children.Count; childIndex++)
		{
			Element child = children[childIndex];
			child.X = X + PaddingLeft + xOffset + Spacing * childIndex;
			xOffset += child.Width;
		}
	}

	protected override void OnYUpdated()
	{
		for (int childIndex = 0; childIndex < children.Count; childIndex++)
		{
			Element child = children[childIndex];
			child.Y = Y + PaddingTop;
		}
	}

	protected override void OnWidthUpdated()
	{
		if (!StretchChildrenWidth) return;
		for (int childIndex = 0; childIndex < children.Count; childIndex++)
		{
			Element child = children[childIndex];
			int workableWidth = Width - PaddingLeft - PaddingRight - Spacing * (children.Count - 1);
			child.Width = workableWidth / children.Count;
		}
	}

	protected override void OnHeightUpdated()
	{
		for (int childIndex = 0; childIndex < children.Count; childIndex++)
		{
			Element child = children[childIndex];
			child.Height = Height - PaddingTop - PaddingBottom;
		}
	}
}
