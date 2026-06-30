using Clockwork.Graphics.Text;

namespace Clockwork.UI;

public class TextCheckBox : HorizontalStackContainer
{
	public CheckBox CheckBox { get; private set; }
	public TextElement TextElement { get; private set; }
	public string Text
	{
		get => TextElement.Text;
		set => TextElement.Text = value;
	}
	public Font Font
	{
		get => TextElement.Font;
		set => TextElement.Font = value;
	}
	public bool IsChecked
	{
		get => CheckBox.IsChecked;
		set => CheckBox.IsChecked = value;
	}

	public TextCheckBox(string text)
	{
		Initialize(text);
		InitializeDefaultState();
	}

	private void Initialize(string text)
	{
		CheckBox = new();
		AddChild(CheckBox);

		TextElement = new(text);
		TextElement.VerticalAlignment = VerticalAlignment.Center;
		AddChild(TextElement);
	}

	private void InitializeDefaultState()
	{
		Height = 100;
		Spacing = 25;
	}
}
