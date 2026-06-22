using Clockwork.Graphics;
using Clockwork.Graphics.Text;
using System.Numerics;

namespace Clockwork.UI;

public class TextElement : Element
{
	private string text = "[default text]";
	public string Text
	{
		get => text;
		set
		{
			text = value;
			Measure();
			AlignHorizontal();
		}
	}
	private Font font = Font.Default;
	public Font Font
	{
		get => font;
		set
		{
			font = value;
			Measure();
		}
	}
	private int fontSize = 45;
	public int FontSize
	{
		get => fontSize;
		set
		{
			fontSize = value;
			Measure();
		}
	}
	private int characterSpacing = 3;
	public int CharacterSpacing
	{
		get => characterSpacing;
		set
		{
			characterSpacing = value;
			Measure();
		}
	}
	public Color TextColor = Colors.Black;
	public Color DisabledTextColor;
	public int TextWidth { get; private set; }
	public int TextHeight { get; private set; }
	private Vector2 offset = Vector2.Zero;

	private HorizontalAlignment horizontalAlignment;
	public HorizontalAlignment HorizontalAlignment
	{
		get => horizontalAlignment;
		set
		{
			horizontalAlignment = value;
			AlignHorizontal();
		}
	}

	private VerticalAlignment verticalAlignment;
	public VerticalAlignment VerticalAlignment
	{
		get => verticalAlignment;
		set
		{
			verticalAlignment = value;
			AlignVertical();
		}
	}

	public TextElement()
	{
		InitializeDefaultState();
	}

	public TextElement(string content)
	{
		Text = content;
		InitializeDefaultState();
	}

	public TextElement(string content, int fontSize, Color textColor)
	{
		this.text = content;
		this.fontSize = fontSize;
		TextColor = textColor;
		characterSpacing = fontSize / 10;
		Measure();
	}

	private void InitializeDefaultState()
	{
		DisabledTextColor = TextColor.SetAlpha(0.5f);
		BackgroundColor = Colors.Clear;
	}

	public override void OnDraw()
	{
		base.OnDraw();
		if (!Visible) return;
		Graphics.Text.Text.Draw(font, Text, Position + offset, fontSize, characterSpacing, Enabled ? TextColor : DisabledTextColor);
	}

	private void Measure()
	{
		Vector2 size = Graphics.Text.Text.MeasureSize(font, text, fontSize, characterSpacing);
		TextWidth = (int)size.X;
		TextHeight = (int)size.Y;
	}

	private void AlignHorizontal()
	{
		switch (horizontalAlignment)
		{
			case HorizontalAlignment.Left:
				offset.X = 0;
				break;
			case HorizontalAlignment.Center:
				offset.X = (Width / 2) - (TextWidth / 2);
				break;
			case HorizontalAlignment.Right:
				offset.X = Width - TextWidth;
				break;
		}
	}

	private void AlignVertical()
	{
		switch (verticalAlignment)
		{
			case VerticalAlignment.Top:
				offset.Y = 0;
				break;
			case VerticalAlignment.Center:
				offset.Y = (Height / 2) - (TextHeight / 2);
				break;
			case VerticalAlignment.Bottom:
				offset.Y = Height - TextHeight;
				break;
		}
	}

	protected override void OnXUpdated() => AlignHorizontal();
	protected override void OnYUpdated() => AlignVertical();
	protected override void OnWidthUpdated() => AlignHorizontal();
	protected override void OnHeightUpdated() => AlignVertical();
}