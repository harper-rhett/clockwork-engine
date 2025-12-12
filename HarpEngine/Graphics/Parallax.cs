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
		int textureStartX = textureStart.X.Floored();
		int textureStartY = textureStart.Y.Floored();

		// Loop through x chunks
		for (int viewX = 0; viewX < Engine.GameWidth;)
		{
			// Adjust X texture and clip space
			int textureX = (textureStartX + viewX).Wrapped(texture.Width);
			int clipWidth = int.Min(texture.Width - textureX, Engine.GameWidth - viewX);
			
			// Loop through y chunks
			for (int viewY = 0; viewY < Engine.GameHeight;)
			{
				// Adjust Y texture and clip space
				int textureY = (textureStartY + viewY).Wrapped(texture.Height);
				int clipHeight = int.Min(texture.Height - textureY, Engine.GameHeight - viewY);

				// Draw texture
				Rectangle sourceRectangle = new(textureX, textureY, clipWidth, clipHeight);
				Vector2 drawPosition = cameraPosition + new Vector2(viewX, viewY);
				texture.Draw(sourceRectangle, drawPosition, Colors.White);
				viewY += clipHeight;
			}

			viewX += clipWidth;
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
