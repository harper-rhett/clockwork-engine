using Clockwork.Graphics;
using Clockwork.Graphics.Draw2D;
using Clockwork.Input;
using System;
using System.Numerics;

namespace Clockwork.UI;

public class Element : Entity
{
	// Shape
	private int x;
	private int y;
	private int width;
	private int height;

	// General
	public Color BackgroundColor = Colors.White;
	public Color BorderColor = Colors.Clear;
	public int BorderThickness;
	private int rightBound => x + width;
	private int lowerBound => y + height;

	// Hover
	public event Action<Element> HoverEntered;
	public event Action<Element> HoverExited;
	private bool wasHovering;

	// Input
	public event Action<Element> Pressed;
	public event Action<Element> Released;

	// Public shape
	public int X
	{
		get => x;
		set
		{
			x = value;
			OnXUpdated();
		}
	}
	public int Y
	{
		get => y;
		set
		{
			y = value;
			OnYUpdated();
		}
	}
	public int Width
	{
		get => width;
		set
		{
			width = value;
			OnWidthUpdated();
		}
	}
	public int Height
	{
		get => height;
		set
		{
			height = value;
			OnHeightUpdated();
		}
	}

	public Element()
	{
		width = Engine.GameWidth;
		height = Engine.GameHeight;
	}

	public Element(int x, int y, int width, int height)
	{
		this.x = x; this.y = y;
		this.width = width; this.height = height;
	}

	public Element(Vector2 position, Vector2 size)
	{
		x = (int)position.X; y = (int)position.Y;
		width = (int)size.X; height = (int)size.Y;
	}

	public Vector2 GetPosition() => new Vector2(x, y);

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
			bool isHovering = mousePosition.X > x
			&& mousePosition.X < rightBound
			&& mousePosition.Y > y
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

		Primitives2D.DrawRectangle(x, y, width, height, BackgroundColor);

		if (BorderThickness > 0 && BackgroundColor != Colors.Clear) DrawBorder();
	}

	private void DrawBorder()
	{
		Rectangle rectangle = new(x, y, width, height);
		Primitives2D.DrawRectangleLines(rectangle, BorderThickness, BorderColor);
	}

	protected virtual void OnXUpdated() { }
	protected virtual void OnYUpdated() { }
	protected virtual void OnWidthUpdated() { }
	protected virtual void OnHeightUpdated() { }
}