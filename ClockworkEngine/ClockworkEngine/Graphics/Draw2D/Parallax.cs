using System.Numerics;
using Clockwork.Utilities;
using Clockwork.Graphics;

namespace Clockwork.Graphics;

public class Parallax : Entity
{
	private Camera2DEntity camera;
	private Vector2 startPosition;
	private Vector2 cameraOffset;
	private List<Layer> layers = new();
	public bool RepeatX = true;
	public bool RepeatY = true;

	// I fear this can be simplified... We probably do not need origin and start position. Just one.
	// Scratch that. What I need is a cameraOrigin and startPosition. May have to tweak the math.
	public Parallax(Camera2DEntity camera, Vector2 originPosition, Vector2 startPosition)
	{
		this.camera = camera;
		this.startPosition = startPosition;
		cameraOffset = originPosition - startPosition;
	}

	public void AddLayer(ITexture backgroundTexture, Vector2 offset, float speed)
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

	private void DrawParallaxTexture(Vector2 parallaxPosition, ITexture texture)
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
			int textureX = (textureStartX + viewX).Wrapped(texture.Width, out int xWraps);
			int clipWidth = int.Min(texture.Width - textureX, Engine.GameWidth - viewX);
			int currentViewX = viewX;
			viewX += clipWidth;
			if (!RepeatX && xWraps != 0) continue;
			
			// Loop through y chunks
			for (int viewY = 0; viewY < Engine.GameHeight;)
			{
				// Adjust Y texture and clip space
				int textureY = (textureStartY + viewY).Wrapped(texture.Height, out int yWraps);
				int clipHeight = int.Min(texture.Height - textureY, Engine.GameHeight - viewY);
				int currentViewY = viewY;
				viewY += clipHeight;
				if (!RepeatY && yWraps != 0) continue;

				// Draw texture
				Rectangle sourceRectangle = new(textureX, textureY, clipWidth, clipHeight);
				Vector2 drawPosition = cameraPosition + new Vector2(currentViewX, currentViewY);
				texture.Draw(sourceRectangle, drawPosition, Colors.White);
			}
		}
	}

	public class Layer
	{
		public readonly ITexture Texture;
		public readonly Vector2 Offset;
		public readonly float Speed;

		public Layer(ITexture texture, Vector2 offset, float speed)
		{
			Texture = texture;
			Offset = offset;
			Speed = speed;
		}
	}
}
