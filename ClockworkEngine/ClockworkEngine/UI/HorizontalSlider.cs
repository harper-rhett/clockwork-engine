using Clockwork.Graphics;
using Clockwork.Input;
using System;
using System.IO;
using System.Numerics;

namespace Clockwork.UI;

// NOTE: Maybe add hovering text over the handle that represents the value.

public class HorizontalSlider : Container
{
	public Element Rail { get; private set; }
	public Button Handle { get; private set; }
	public TextElement ValueText { get; private set; }
	public delegate void OnValueChanged(float value);
	public event OnValueChanged ValueChanged;
	public bool IsDragging { get; private set; }
	private float value = 0.5f;
	public float Value
	{
		get => value;
		set
		{
			this.value = value;
			UpdateHandleX();
			UpdateHandleY();
		}
	}
	public int ValueTextOffset = 40;

	public HorizontalSlider() : base()
	{
		Initialize();
	}

	private void Initialize()
	{
		Style railStyle = new(Colors.White, Colors.Black, 5);
		Rail = new(railStyle);
		Rail.Width = Width;
		AddChild(Rail);

		Handle = new();
		Handle.Width = 75;
		Handle.Height = 75;
		Handle.Pressed += OnHandlePressed;
		Handle.Released += OnHandleReleased;
		AddChild(Handle);

		ValueText = new();
		ValueText.FontSize = 50;
		ValueText.Visible = false;
		ValueText.HorizontalAlignment = HorizontalAlignment.Center;
		ValueText.VerticalAlignment = VerticalAlignment.Center;
		AddChild(ValueText);

		Height = 100;
		PaddingTop = 35;
		PaddingBottom = 35;
		PaddingLeft = 40;
		PaddingRight = 40;

		ForceLayoutUpdate();
	}

	public override void OnUpdate(DrawContext drawContext)
	{
		base.OnUpdate(drawContext);

		// Cancel if no longer dragging
		if (!IsDragging) return;
		if (Mouse.IsButtonReleased(MouseButton.Left))
		{
			StopDragging();
			return;
		}

		// Calculate position
		int handleHalfWidth = Handle.GetHalfWidth();
		int mouseX = drawContext == DrawContext.Game ? Mouse.GameX : Mouse.WindowX;
		int valueX = int.Clamp(mouseX, X + PaddingLeft, X + Width - PaddingRight);
		Handle.X = valueX - handleHalfWidth;
		int localX = Handle.X - Rail.X + Handle.GetHalfWidth();
		value = localX / (float)Rail.Width;

		// Position value text
		ValueText.Text = $"{value:F2}";
		ValueText.Width = ValueText.TextWidth;
		ValueText.X = valueX - ValueText.GetHalfWidth();
		ValueText.Y = Handle.Y - ValueTextOffset;
	}

	private void UpdateHandleX()
	{
		Handle.X = Rail.X + (int)(Rail.Width * value) - Handle.GetHalfWidth();
	}

	private void UpdateHandleY()
	{
		Handle.Y = Rail.Y + Rail.GetHalfHeight() - Handle.GetHalfHeight();
	}

	private void StopDragging()
	{
		ValueText.Visible = false;
		IsDragging = false;
		ValueChanged?.Invoke(value);
	}

	private void OnHandlePressed()
	{
		ValueText.Visible = true;
		IsDragging = true;
	}

	private void OnHandleReleased()
	{
		StopDragging();
	}

	protected override void OnXUpdated()
	{
		Rail.X = X + PaddingLeft;
		UpdateHandleX();
	}

	protected override void OnYUpdated()
	{
		Rail.Y = Y + PaddingTop;
		UpdateHandleY();
	}

	protected override void OnWidthUpdated()
	{
		Rail.Width = Width - PaddingLeft - PaddingRight;
		UpdateHandleX();
	}

	protected override void OnHeightUpdated()
	{
		Rail.Height = Height - PaddingTop - PaddingBottom;
		UpdateHandleY();
	}
}