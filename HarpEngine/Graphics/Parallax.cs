using System.Collections.Generic;
using static HarpEngine.Graphics.Parallax;

namespace HarpEngine.Graphics;

public class Parallax : Entity
{
	private Camera2D camera;
	private Vector2 startPosition;
	private Vector2 cameraOffset;
	private List<Layer> layers = new();

	public Parallax(Camera2D camera, Vector2 startPosition)
	{
		this.camera = camera;
		this.startPosition = startPosition;
		cameraOffset = camera.Transform.WorldPosition - startPosition;
	}

	public void AddLayer(Texture backgroundTexture, Vector2 offset, float speed)
	{
		layers.Add(new(backgroundTexture, offset, speed));
	}

	// Need to only draw what I need (right?)
	// or at least I need to repeat the texture
	public override void OnDraw()
	{
		foreach (Layer layer in layers)
		{
			Vector2 movement = startPosition + cameraOffset - camera.Transform.WorldPosition;
			Vector2 position = startPosition + movement * -layer.Speed + layer.Offset;
			DrawParallaxTexture(position, layer.Texture);
		}
	}

	private void DrawParallaxTexture(Vector2 parallaxPosition, Texture texture)
	{
		// Get texture start
		Vector2 cameraPosition = camera.Transform.WorldPosition;
		Vector2 textureStart = cameraPosition - parallaxPosition;

		// Scope to camera view
		int viewX = 0;
		int viewY = 0;

		// Loop through rendering blocks
		// TODO: width and height are not accurate when cut off by viewport
		while (viewX < Engine.GameWidth && viewY < Engine.GameHeight)
		{
			// Adjust to texture space
			int textureX = (textureStart.X.Floored() + viewX) % texture.Width;
			int textureY = (textureStart.Y.Floored() + viewY) % texture.Height;
			int xWidth = texture.Width - textureX;
			int yWidth = texture.Height - textureY;

			// Draw texture
			Rectangle sourceRectangle = new(textureX, textureY, xWidth, yWidth);
			Vector2 drawPosition = cameraPosition + new Vector2(viewX, viewY);
			texture.Draw(sourceRectangle, drawPosition, Colors.White);
			viewX += xWidth;
			viewY += yWidth;
		}
	}

	public class Layer
	{
		public readonly Texture Texture;
		public readonly Vector2 Offset;
		public readonly float Speed;

		public Layer(Texture texture, Vector2 offset, float speed)
		{
			Texture = texture;
			Offset = offset;
			Speed = speed;
		}
	}
}
