using Clockwork.Graphics;
using Clockwork.Graphics.Text;
using System.Numerics;

namespace Clockwork.UI;

public class TextElement : Element
{
	private string content = "[default text]";
	public string Content
	{
		get => content;
		set
		{
			content = value;
			Measure();
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
	private int fontSize = 35;
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
			RefreshHorizontalAlignment();
		}
	}

	private VerticalAlignment verticalAlignment;
	public VerticalAlignment VerticalAlignment
	{
		get => verticalAlignment;
		set
		{
			verticalAlignment = value;
			RefreshVerticalAlignment();
		}
	}

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
		this.content = content;
		this.fontSize = fontSize;
		TextColor = textColor;
		characterSpacing = fontSize / 10;
		Measure();
	}

	private void InitializeDefaultState()
	{
		BackgroundColor = DefaultBackgroundColor;
	}

	public override void OnDraw()
	{
		base.OnDraw();
		Text.Draw(font, Content, GetPosition() + offset, fontSize, characterSpacing, TextColor);
	}

	private void Measure()
	{
		Vector2 size = Text.MeasureSize(font, content, fontSize, characterSpacing);
		TextWidth = (int)size.X;
		TextHeight = (int)size.Y;
	}

	private void RefreshHorizontalAlignment()
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

	private void RefreshVerticalAlignment()
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

	protected override void OnXUpdated() => RefreshHorizontalAlignment();
	protected override void OnYUpdated() => RefreshVerticalAlignment();
	protected override void OnWidthUpdated() => RefreshHorizontalAlignment();
	protected override void OnHeightUpdated() => RefreshVerticalAlignment();
}