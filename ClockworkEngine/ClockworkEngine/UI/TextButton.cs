using System.Numerics;

namespace Clockwork.UI;

public class TextButton : Button
{
	public TextElement TextElement { get; private set; }
	public string Text
	{
		get => TextElement.Text;
		set => TextElement.Text = value;
	}

	public TextButton(string text) : base()
	{
		InitializeText(text);
	}

	public TextButton(string text, int x, int y, int width, int height) : base(x, y, width, height)
	{
		InitializeText(text);
	}

	public TextButton(string text, int x, int y, int width, int height, Style defaultStyle, Style hoverStyle, Style pressedStyle) : base(x, y, width, height, defaultStyle, hoverStyle, pressedStyle)
	{
		InitializeText(text);
	}

	public TextButton(string text, Vector2 position, Vector2 size) : base(position, size)
	{
		InitializeText(text);
	}

	public TextButton(string text, Vector2 position, Vector2 size, Style style, Style hoverStyle, Style pressedStyle) : base(position, size, style, hoverStyle, pressedStyle)
	{
		InitializeText(text);
	}

	private void InitializeText(string text)
	{
		TextElement = new(text);
		TextElement.HorizontalAlignment = HorizontalAlignment.Center;
		TextElement.VerticalAlignment = VerticalAlignment.Center;
		AddChild(TextElement);
	}
}
