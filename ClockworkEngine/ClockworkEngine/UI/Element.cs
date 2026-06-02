using Clockwork.Graphics;
using Clockwork.Graphics.Draw2D;
using Clockwork.Input;
using System;
using System.Numerics;

namespace Clockwork.UI;

public class Element : Entity
{
	// Shape
	public Rectangle Rectangle;
	public Color BackgroundColor = Colors.White;
	public Color BorderColor = Colors.Clear;
	public int BorderThickness;
	private int rightBound => (int)(Rectangle.X + Rectangle.Width);
	private int lowerBound => (int)(Rectangle.Y + Rectangle.Height);

	// Hover
	public event Action<Element> HoverEntered;
	public event Action<Element> HoverExited;
	private bool wasHovering;

	// Input
	public event Action<Element> Pressed;
	public event Action<Element> Released;

	public Element()
	{
		Rectangle = new(Vector2.Zero, Engine.GameSize);
	}

	public Element(int x, int y, int width, int height)
	{
		Rectangle = new(x, y, width, height);
	}

	public Element(Vector2 position, Vector2 size)
	{
		Rectangle = new(position, size);
	}

	public override void OnUpdate()
	{
		UpdateHover();
		UpdatePressed();
		UpdateReleased();
	}

	private void UpdateHover()
	{
		if (HoverEntered is null && HoverExited is null) return;

		bool isHovering = IsHovering;
		if (!wasHovering && isHovering)
		{
			HoverEntered?.Invoke(this);
			wasHovering = true;
		}
		else if (wasHovering && !isHovering)
		{
			HoverExited?.Invoke(this);
			wasHovering = false;
		}
	}

	private bool IsHovering
	{
		get
		{
			Vector2 mousePosition = Mouse.GamePosition;
			bool isHovering = mousePosition.X > Rectangle.X
			&& mousePosition.X < rightBound
			&& mousePosition.Y > Rectangle.Y
			&& mousePosition.Y < lowerBound
			&& Mouse.IsOnScreen;
			return isHovering;
		}
	}

	private void UpdatePressed()
	{
		if (
			Pressed is not null
			&& wasHovering
			&& Mouse.IsButtonPressed(MouseButton.Left)
		) Pressed.Invoke(this);
	}

	private void UpdateReleased()
	{
		if (
			Released is not null
			&& Mouse.IsButtonReleased(MouseButton.Left)
		) Released.Invoke(this);
	}

	public override void OnDraw()
	{
		if (BackgroundColor == Colors.Clear) return;

		Primitives2D.DrawRectangle(Rectangle, BackgroundColor);

		if (BorderThickness > 0 && BackgroundColor != Colors.Clear) DrawBorder();
	}

	private void DrawBorder()
	{
		Primitives2D.DrawRectangleLines(Rectangle, BorderThickness, BorderColor);
	}
}