using Clockwork.Graphics;
using Clockwork.Graphics.Draw2D;
using Clockwork.Input;
using System;
using System.Numerics;

namespace Clockwork.UI;

public class Element
{
	// Shape
	private int x;
	private int y;
	private int width;
	private int height;

	// General
	public Style DisabledStyle;
	public Style ActiveStyle;
	public Color BackgroundColor
	{
		get => ActiveStyle.BackgroundColor;
		set => ActiveStyle.BackgroundColor = value;
	}
	public Color BorderColor
	{
		get => ActiveStyle.BorderColor;
		set => ActiveStyle.BorderColor = value;
	}
	public int BorderThickness
	{
		get => ActiveStyle.BorderThickness;
		set => ActiveStyle.BorderThickness = value;
	}
	private int rightBound => x + width;
	private int lowerBound => y + height;
	private bool enabled = true;
	public bool Enabled
	{
		get => enabled;
		set
		{
			enabled = value;
			if (enabled) OnEnabled();
			else OnDisabled();
		}
	}
	private bool visible = true;
	public bool Visible
	{
		get => visible;
		set
		{
			visible = value;
			if (visible) OnVisible();
			else OnInvisible();
		}
	}

	// Hover
	public event Action HoverEntered;
	public event Action HoverExited;
	private bool wasHovering;

	// Input
	public event Action Pressed;
	public event Action Released;

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
	public Vector2 Position => new(x, y);
	public Vector2 Size => new(width, height);
	public Rectangle Rectangle => new(x, y, width, height);

	public Element()
	{
		width = Engine.GameWidth;
		height = Engine.GameHeight;
	}

	public Element(int x, int y, int width, int height)
	{
		InitializeTransform(x, y, width, height);
		InitializeDisabledStyle();
	}

	public Element(int x, int y, int width, int height, Style style)
	{
		InitializeTransform(x, y, width, height);
		ActiveStyle = style;
		InitializeDisabledStyle();
	}

	public Element(Vector2 position, Vector2 size)
	{
		InitializeTransform((int)position.X, (int)position.Y, (int)size.X, (int)size.Y);
		InitializeDisabledStyle();
	}

	public Element(Vector2 position, Vector2 size, Style style)
	{
		InitializeTransform((int)position.X, (int)position.Y, (int)size.X, (int)size.Y);
		ActiveStyle = style;
		InitializeDisabledStyle();
	}

	protected void InitializeTransform(int x, int y, int width, int height)
	{
		this.x = x; this.y = y;
		this.width = width; this.height = height;
		InitializeDisabledStyle();
	}

	protected void InitializeDisabledStyle()
	{
		DisabledStyle = new(BackgroundColor.SetAlpha(0.5f), BorderColor.SetAlpha(0.5f), BorderThickness);
	}

	public virtual void OnUpdate()
	{
		if (!enabled) return;
		UpdateHover();
		UpdatePressed();
		UpdateReleased();
	}

	private void UpdateHover()
	{
		if (HoverEntered is null && HoverExited is null) return;

		bool isHovering = IsHovering();
		if (!wasHovering && isHovering)
		{
			HoverEntered?.Invoke();
			wasHovering = true;
		}
		else if (wasHovering && !isHovering)
		{
			HoverExited?.Invoke();
			wasHovering = false;
		}
	}

	protected bool IsHovering()
	{
		Vector2 mousePosition = Mouse.GamePosition;
		bool isHovering = mousePosition.X > x
		&& mousePosition.X < rightBound
		&& mousePosition.Y > y
		&& mousePosition.Y < lowerBound
		&& Mouse.IsOnScreen;
		return isHovering;
	}

	private void UpdatePressed()
	{
		if (
			Pressed is not null
			&& wasHovering
			&& Mouse.IsButtonPressed(MouseButton.Left)
		) Pressed.Invoke();
	}

	private void UpdateReleased()
	{
		if (
			Released is not null
			&& wasHovering
			&& Mouse.IsButtonReleased(MouseButton.Left)
		) Released.Invoke();
	}

	public virtual void OnDraw()
	{
		if (!visible) return;

		Style currentStyle = enabled ? ActiveStyle : DisabledStyle;
		if (BackgroundColor != Colors.Clear)
		{
			Primitives2D.DrawRectangle(Rectangle, currentStyle.BackgroundColor);
		}

		if (BorderThickness > 0 && BorderColor != Colors.Clear)
		{
			Primitives2D.DrawRectangleLines(Rectangle, currentStyle.BorderThickness, currentStyle.BorderColor);
		}
	}

	protected virtual void OnXUpdated() { }
	protected virtual void OnYUpdated() { }
	protected virtual void OnWidthUpdated() { }
	protected virtual void OnHeightUpdated() { }
	protected virtual void OnEnabled() { }
	protected virtual void OnDisabled() { }
	protected virtual void OnVisible() { }
	protected virtual void OnInvisible() { }
}