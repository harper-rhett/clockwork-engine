namespace Clockwork.UI;

public class HorizontalStackContainer : Container
{
	public int Spacing;
	public bool StretchChildrenWidth;

	protected override void OnXUpdated()
	{
		int xOffset = 0;
		for (int childIndex = 0; childIndex < children.Count; childIndex++)
		{
			Element child = children[childIndex];
			child.X = PaddingLeft + xOffset + Spacing * childIndex;
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
