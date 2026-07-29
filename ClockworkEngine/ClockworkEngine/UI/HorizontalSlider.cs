using Clockwork.Graphics;
using Clockwork.Input;
using System;
using System.Numerics;

namespace Clockwork.UI;

public class HorizontalSlider : Container
{
	public Element Rail { get; private set; }
	public Button Handle { get; private set; }
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

		Height = 100;
		PaddingTop = 35;
		PaddingBottom = 35;
		PaddingLeft = 40;
		PaddingRight = 40;

		ForceLayoutUpdate();
	}

	public override void OnUpdate()
	{
		base.OnUpdate();

		// Cancel if no longer dragging
		if (!IsDragging) return;
		if (Mouse.IsButtonReleased(MouseButton.Left))
		{
			StopDragging();
			return;
		}

		// Calculate position
		int handleHalfWidth = Handle.GetHalfWidth();
		Handle.X = int.Clamp(Mouse.WindowX - handleHalfWidth, X + PaddingLeft - handleHalfWidth, X + Width - PaddingRight - handleHalfWidth);
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
		IsDragging = false;
		int localX = Handle.X - Rail.X + Handle.GetHalfWidth();
		value = localX / (float)Rail.Width;
		ValueChanged?.Invoke(value);
	}

	private void OnHandlePressed()
	{
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