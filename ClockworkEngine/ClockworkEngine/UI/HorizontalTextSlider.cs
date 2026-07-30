using Clockwork.Graphics.Text;

namespace Clockwork.UI;

public class HorizontalTextSlider : AlignmentContainer
{
	public HorizontalSlider Slider { get; private set; }
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
	public event HorizontalSlider.OnValueChanged ValueChanged
	{
		add => Slider.ValueChanged += value;
		remove => Slider.ValueChanged -= value;
	}

	public HorizontalTextSlider(string text)
	{
		TextElement = new(text);
		AddChild(TextElement);
		Alignment textAlignment = new(HorizontalAlignment.Left, VerticalAlignment.Center);
		SetAlignment(TextElement, textAlignment);

		Slider = new();
		Slider.Width = 500;
		AddChild(Slider);
		Alignment sliderAlignment = new(HorizontalAlignment.Right, VerticalAlignment.Center);
		SetAlignment(Slider, sliderAlignment);

		Height = 100;
	}
}
