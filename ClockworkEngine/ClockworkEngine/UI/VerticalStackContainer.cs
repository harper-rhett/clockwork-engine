namespace Clockwork.UI;

public class VerticalStackContainer : Container
{
	public int Spacing;

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
		for (int childIndex = 0; childIndex < children.Count; childIndex++)
		{
			Element child = children[childIndex];
			child.Y = Y + PaddingTop + (child.Height + Spacing) * childIndex;
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
		for (int childIndex = 0; childIndex < children.Count; childIndex++)
		{
			Element child = children[childIndex];
			// nothing yet
		}
	}
}
