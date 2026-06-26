using Clockwork.Graphics;

namespace Clockwork.UI;

public struct Style
{
	public Color BackgroundColor = Colors.White;
	public Color BorderColor = Colors.Clear;
	public int BorderThickness;

	public Style(Color backgroundColor, Color borderColor, int borderThickness)
	{
		BackgroundColor = backgroundColor;
		BorderColor = borderColor;
		BorderThickness = borderThickness;
	}
}
