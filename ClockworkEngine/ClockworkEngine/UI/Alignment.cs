namespace Clockwork.UI;

public struct Alignment
{
	public HorizontalAlignment Horizontal;
	public VerticalAlignment Vertical;

	public Alignment(HorizontalAlignment horizontalAlignment, VerticalAlignment verticalAlignment)
	{
		Horizontal = horizontalAlignment;
		Vertical = verticalAlignment;
	}
}
