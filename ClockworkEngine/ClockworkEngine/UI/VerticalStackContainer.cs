namespace Clockwork.UI;

public class VerticalStackContainer : Container
{
	public int Spacing;
	public bool StretchChildrenHeight;

	protected override void OnXUpdated()
	{
		for (int childIndex = 0; childIndex < children.Count; childIndex++)
		{
			Element child = children[childIndex];
			child.X = X + PaddingLeft;
		}
	}

	protected override void OnYUpdated()
	{
		int yOffset = 0;
		for (int childIndex = 0; childIndex < children.Count; childIndex++)
		{
			Element child = children[childIndex];
			child.Y = yOffset + PaddingTop + Spacing * childIndex;
			yOffset += child.Height;
		}
	}

	protected override void OnWidthUpdated()
	{
		for (int childIndex = 0; childIndex < children.Count; childIndex++)
		{
			Element child = children[childIndex];
			child.Width = Width - PaddingLeft - PaddingRight;
		}
	}

	protected override void OnHeightUpdated()
	{
		if (!StretchChildrenHeight) return;
		for (int childIndex = 0; childIndex < children.Count; childIndex++)
		{
			Element child = children[childIndex];
			int workableHeight = Height - PaddingTop - PaddingBottom - Spacing * (children.Count - 1);
			child.Height = workableHeight / children.Count;
		}
	}
}
