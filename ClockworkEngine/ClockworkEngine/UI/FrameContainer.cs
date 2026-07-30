using System.Numerics;

namespace Clockwork.UI;

public class FrameContainer : Container
{
	public FrameContainer() : base() { }
	public FrameContainer(Style style) : base(style) { }

	public FrameContainer(int x, int y, int width, int height) : base(x, y, width, height) { }
	public FrameContainer(int x, int y, int width, int height, Style style) : base(x, y, width, height, style) { }

	public FrameContainer(Vector2 position, Vector2 size) : base(position, size) { }
	public FrameContainer(Vector2 position, Vector2 size, Style style) : base(position, size, style) { }

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
