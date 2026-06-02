using Clockwork.Graphics;
using System;
using System.Numerics;

namespace Clockwork.UI;

public class Button : Container
{
	private static Color DefaultBackgroundColor = Colors.White;
	private static Color DefaultBorderColor = Colors.Black;
	public Color AccentColor = Colors.Blue;

	public Button()
	{
		InitializeDefaultState();
		SubscribeToEvents();
	}

	public Button(int x, int y, int width, int height) : base(x, y, width, height)
	{
		InitializeDefaultState();
		SubscribeToEvents();
	}

	public Button(int x, int y, int width, int height, Color backgroundColor, Color borderColor, int borderThickness) : base(x, y, width, height)
	{
		BackgroundColor = backgroundColor;
		BorderColor = borderColor;
		BorderThickness = borderThickness;
		SubscribeToEvents();
	}

	public Button(Vector2 position, Vector2 size, Color backgroundColor, Color borderColor, int borderThickness) : base(position, size)
	{
		BackgroundColor = backgroundColor;
		BorderColor = borderColor;
		BorderThickness = borderThickness;
		SubscribeToEvents();
	}

	private void InitializeDefaultState()
	{
		BackgroundColor = DefaultBackgroundColor;
		BorderColor = DefaultBorderColor;
		BorderThickness = 5;
	}

	private void SubscribeToEvents()
	{
		HoverEntered += OnHoverEntered;
		HoverExited += OnHoverExited;
		Pressed += OnPressed;
		Released += OnReleased;
	}

	public virtual void OnHoverEntered(Element element)
	{
		BorderColor = AccentColor;
	}

	public virtual void OnHoverExited(Element element)
	{
		BorderColor = DefaultBorderColor;
	}

	public virtual void OnPressed(Element element)
	{
		BackgroundColor = Color.Mix(DefaultBackgroundColor, AccentColor);
	}

	public virtual void OnReleased(Element element)
	{
		BackgroundColor = DefaultBackgroundColor;
	}
}
