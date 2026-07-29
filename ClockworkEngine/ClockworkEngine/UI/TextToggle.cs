using Clockwork.Graphics.Text;
using System;

namespace Clockwork.UI;

public class TextToggle : AlignmentContainer
{
	public Toggle Toggle { get; private set; }
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
		get => Toggle.IsChecked;
		set => Toggle.IsChecked = value;
	}
	public event Toggle.OnValueChanged ValueChanged
	{
		add => Toggle.ValueChanged += value;
		remove => Toggle.ValueChanged -= value;
	}

	public TextToggle(string text)
	{
		TextElement = new(text);
		AddChild(TextElement);
		Alignment textAlignment = new(HorizontalAlignment.Left, VerticalAlignment.Center);
		SetAlignment(TextElement, textAlignment);

		Toggle = new();
		Toggle.Width = 75;
		Toggle.Height = 75;
		AddChild(Toggle);
		Alignment toglleAlignment = new(HorizontalAlignment.Right, VerticalAlignment.Center);
		SetAlignment(Toggle, toglleAlignment);

		Height = 100;
	}
}
