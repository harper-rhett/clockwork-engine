using Clockwork.Graphics;
using System;
using System.Numerics;

namespace Clockwork.UI;

public class TextureElement : Element, IDisposable
{
	private Texture texture;
	private Rectangle sourceRectangle;
	private Rectangle destinationRectangle;
	public Color Color = Colors.White;

	public TextureElement(string texturePath)
	{
		texture = Texture.Load(texturePath);
		sourceRectangle = texture.GetRectangle();
		Width = texture.Width;
		Height = texture.Height;
	}

	public override void OnDraw()
	{
		base.OnDraw();
		texture.Draw(sourceRectangle, destinationRectangle, Vector2.Zero, 0, Color);
	}

	public void Dispose()
	{
		texture.Dispose();
	}

	protected override void OnXUpdated()
	{
		destinationRectangle.X = X;
	}

	protected override void OnYUpdated()
	{
		destinationRectangle.Y = Y;
	}

	protected override void OnWidthUpdated()
	{
		destinationRectangle.Width = Width;
	}

	protected override void OnHeightUpdated()
	{
		destinationRectangle.Height = Height;
	}
}
