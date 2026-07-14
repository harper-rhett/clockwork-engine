using Clockwork.Graphics;
using System;
using System.Numerics;

namespace Clockwork.UI;

public class Button : Container
{
	public Style DefaultStyle;
	public Style HoverStyle;
	public Style PressedStyle;
	public bool IsHovered { get; private set; }
	public bool IsPressed { get; private set; }

	public Button() : base()
	{
		Height = 100;
		InitializeDefaultStyles();
		SubscribeToEvents();
	}

	public Button(Style defaultStyle, Style hoverStyle, Style pressedStyle) : base(defaultStyle)
	{
		Height = 100;
		DefaultStyle = defaultStyle;
		HoverStyle = hoverStyle;
		PressedStyle = pressedStyle;
		SubscribeToEvents();
	}

	public Button(int x, int y, int width, int height) : base(x, y, width, height)
	{
		Height = 100;
		InitializeDefaultStyles();
		SubscribeToEvents();
	}

	public Button(int x, int y, int width, int height, Style defaultStyle, Style hoverStyle, Style pressedStyle) : base(x, y, width, height, defaultStyle)
	{
		DefaultStyle = defaultStyle;
		HoverStyle = hoverStyle;
		PressedStyle = pressedStyle;
		SubscribeToEvents();
	}

	public Button(Vector2 position, Vector2 size) : base(position, size)
	{
		Height = 100;
		InitializeDefaultStyles();
		SubscribeToEvents();
	}

	public Button(Vector2 position, Vector2 size, Style defaultStyle, Style hoverStyle, Style pressedStyle) : base(position, size, defaultStyle)
	{
		DefaultStyle = defaultStyle;
		HoverStyle = hoverStyle;
		PressedStyle = pressedStyle;
		SubscribeToEvents();
	}

	private void InitializeDefaultStyles()
	{
		DefaultStyle = new(Colors.White, Colors.Black, 5);
		HoverStyle = new(Colors.White, Colors.Blue, 5);
		PressedStyle = new(Colors.SkyBlue, Colors.Blue, 5);
		ActiveStyle = DefaultStyle;
		InitializeDisabledStyle();
	}

	private void SubscribeToEvents()
	{
		HoverEntered += OnHoverEntered;
		HoverExited += OnHoverExited;
		Pressed += OnPressed;
		Released += OnReleased;
	}

	public virtual void OnHoverEntered()
	{
		ActiveStyle = HoverStyle;
		IsHovered = true;
	}

	public virtual void OnHoverExited()
	{
		ActiveStyle = DefaultStyle;
		IsHovered = false;
	}

	public virtual void OnPressed()
	{
		ActiveStyle = PressedStyle;
		IsPressed = true;
	}

	public virtual void OnReleased()
	{
		ActiveStyle = HoverStyle;
		IsPressed = false;
	}
}
