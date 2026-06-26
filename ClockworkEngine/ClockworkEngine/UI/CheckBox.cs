using Clockwork.Graphics;
using System.Numerics;

namespace Clockwork.UI;

public class CheckBox : Button
{
	private bool isChecked;
	public bool IsChecked
	{
		get => isChecked;
		set
		{
			isChecked = value;
			Check.ActiveStyle = isChecked ? CheckStyle : UncheckedStyle;
		}
	}
	public Element Check { get; private set; }
	public Style CheckStyle;
	public Style UncheckedStyle;

	public CheckBox()
	{
		Initialize();
		InitializeDefaultState();
	}

	public CheckBox(Vector2 position, Vector2 size) : base(position, size)
	{
		Initialize();
		InitializeDefaultState();
	}

	private void Initialize()
	{
		Check = new();
		AddChild(Check);
	}

	private void InitializeDefaultState()
	{
		CheckStyle = new(Colors.Black, Colors.Clear, 0);
		UncheckedStyle = new(Colors.Clear, Colors.Clear, 0);
		Check.ActiveStyle = UncheckedStyle;
		Padding = 15;
		Width = 100;
		Height = 100;
	}

	public override void OnPressed()
	{
		base.OnPressed();
	}

	public override void OnReleased()
	{
		base.OnReleased();
		IsChecked = !IsChecked;
	}

	public override void OnDraw()
	{
		base.OnDraw();
	}
}
