using Clockwork.Graphics;
using Clockwork.Graphics.Text;
using System.Numerics;

namespace Clockwork.UI;

public class TextElement : Element
{
	public string Content = "[default text]";
	public Font Font = Font.Default;
	public int FontSize = 25;
	public Color TextColor = Colors.Black;

	private static Color DefaultBackgroundColor = Colors.Clear;

	public TextElement()
	{
		InitializeDefaultState();
	}

	public TextElement(string content)
	{
		Content = content;
		InitializeDefaultState();
	}

	public TextElement(string content, int fontSize, Color textColor)
	{
		Content = content;
		FontSize = fontSize;
		TextColor = textColor;
	}

	private void InitializeDefaultState()
	{
		BackgroundColor = DefaultBackgroundColor;
	}

	public override void OnDraw()
	{
		base.OnDraw();
		Text.Draw(Font, Content, GetPosition(), FontSize, 0, TextColor);
	}
}
