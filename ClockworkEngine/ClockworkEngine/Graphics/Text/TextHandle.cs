using Clockwork.Graphics.Text;
using Clockwork.Graphics;
using System.Numerics;

public class TextHandle
{
	private string content;
	public string Content
	{
		get => content;
		set
		{
			content = value;
			Remeasure();
		}
	}

	private int fontSize;
	public int FontSize
	{
		get => fontSize;
		set
		{
			fontSize = value;
			Remeasure();
		}
	}


	private Font font;
	public Font Font
	{
		get => font;
		set
		{
			font = value;
			Remeasure();
		}
	}

	public Vector2 Size { get; private set; }
	public Color Color = Colors.White;

	public TextHandle(string content)
	{
		Content = content;
		Remeasure();
	}

	private void Remeasure()
	{
		Size = Text.MeasureSize(font, Content, FontSize, 0);
	}

	public void Draw(Vector2 position)
	{
		Text.Draw(font, Content, position, FontSize, 0, Color);
	}
}
