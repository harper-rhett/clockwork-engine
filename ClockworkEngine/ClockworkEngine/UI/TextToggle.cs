using Clockwork.Graphics.Text;
using System;

namespace Clockwork.UI;

public class TextToggle : HorizontalStackContainer
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
	public event Toggle.OnToggled Toggled
	{
		add => Toggle.Toggled += value;
		remove => Toggle.Toggled -= value;
	}

	public TextToggle(string text)
	{
		Initialize(text);
		InitializeDefaultState();
	}

	private void Initialize(string text)
	{
		Toggle = new();
		AddChild(Toggle);

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
