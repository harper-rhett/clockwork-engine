using Clockwork.Graphics;
using Clockwork.Windowing;
using System.Numerics;

namespace Clockwork.UI;

public class Panel : Entity
{
	public Element RootElement;
	private RenderTexture renderTexture;
	public int Width => renderTexture.Width;
	public int Height => renderTexture.Height;
	private Rectangle sourceRectangle;
	private Rectangle destinationRectangle;

	private readonly DrawContext drawContext;
	private int contextWidth;
	private int contextHeight;

	private float scale = 1f;
	public float Scale
	{
		get => scale;
		set
		{
			scale = value;
			destinationRectangle.Width = sourceRectangle.Width * scale;
			destinationRectangle.Height = sourceRectangle.Height * scale;
		}
	}

	private HorizontalAlignment horizontalAlignment;
	public HorizontalAlignment HorizontalAlignment
	{
		get => horizontalAlignment;
		set
		{
			horizontalAlignment = value;
			AlignHorizontal();
		}
	}

	private VerticalAlignment verticalAlignment;
	public VerticalAlignment VerticalAlignment
	{
		get => verticalAlignment;
		set
		{
			verticalAlignment = value;
			AlignVertical();
		}
	}

	public Panel(Element rootElement, DrawContext drawContext)
	{
		RootElement = rootElement;
		this.drawContext = drawContext;
		Initialize(Engine.GameWidth, Engine.GameHeight);
	}

	public Panel(Element rootElement, DrawContext drawContext, int width, int height)
	{
		RootElement = rootElement;
		this.drawContext = drawContext;
		Initialize(width, height);
	}

	private void Initialize(int width, int height)
	{
		if (drawContext is DrawContext.Game)
		{
			contextWidth = Engine.GameWidth;
			contextHeight = Engine.GameHeight;
			Engine.GameResized += UpdateContext;
		}
		else if (drawContext is DrawContext.GUI)
		{
			contextWidth = Window.Width;
			contextHeight = Window.Height;
			Window.Resized += UpdateContext;
		}
		RootElement.X = 0;
		RootElement.Y = 0;
		RootElement.Width = Engine.GameWidth;
		RootElement.Height = Engine.GameHeight;
		renderTexture = RenderTexture.Load(width, height);
		sourceRectangle = new(0, 0, width, -height);
		destinationRectangle = sourceRectangle;
	}

	public override void OnUpdate()
	{
		RootElement.OnUpdate();
		renderTexture.BeginDrawing();
		RootElement.OnDraw();
		RenderTexture.EndDrawing();
	}

	public override void OnDraw()
	{
		if (drawContext is DrawContext.Game) Draw();
	}

	public override void OnDrawGUI()
	{
		if (drawContext is DrawContext.GUI) Draw();
	}

	private void Draw()
	{
		renderTexture.Texture.Draw(sourceRectangle, destinationRectangle, Vector2.Zero, 0, Colors.White);
	}

	public override void OnRemovedFromScene()
	{
		if (drawContext is DrawContext.Game) Engine.GameResized -= UpdateContext;
		else if (drawContext is DrawContext.GUI) Window.Resized -= UpdateContext;
	}

	private void UpdateContext(int width, int height)
	{
		contextWidth = width;
		contextHeight = height;
		AlignHorizontal();
		AlignVertical();
	}

	private void AlignHorizontal()
	{
		switch (horizontalAlignment)
		{
			case HorizontalAlignment.Left:
				destinationRectangle.X = 0;
				break;
			case HorizontalAlignment.Center:
				destinationRectangle.X = (contextWidth / 2) - (Width / 2);
				break;
			case HorizontalAlignment.Right:
				destinationRectangle.X = contextWidth - Width;
				break;
		}
	}

	private void AlignVertical()
	{
		switch (verticalAlignment)
		{
			case VerticalAlignment.Top:
				destinationRectangle.Y = 0;
				break;
			case VerticalAlignment.Center:
				destinationRectangle.Y = (contextHeight / 2) - (Height / 2);
				break;
			case VerticalAlignment.Bottom:
				destinationRectangle.Y = contextHeight - Height;
				break;
		}
	}
}
