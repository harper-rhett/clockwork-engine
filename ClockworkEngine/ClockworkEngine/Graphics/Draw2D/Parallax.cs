using Clockwork.Utilities;
using System.Numerics;
using static Clockwork.Particles.ParticleRenderer2D;

namespace Clockwork.Graphics;

public class Parallax : Entity
{
	private Camera2D camera;
	private Vector2 startPosition;
	private Vector2 cameraOffset;
	private List<Layer> layers = new();
	public bool RepeatX = true;
	public bool RepeatY = true;

	public Parallax(Camera2D camera, Vector2 originPosition, Vector2 startPosition)
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

	// This works, damn it
	private void DrawParallaxTextureClaude(Vector2 parallaxPosition, ITexture texture)
	{
		// Get texture start
		Vector2 cameraPosition = camera.Transform.WorldPosition;
		Vector2 textureStart = cameraPosition - parallaxPosition;

		// Calculate starting tile indices (floor for proper negative handling)
		int startTileX = (int)Math.Floor(textureStart.X / texture.Width);
		int startTileY = (int)Math.Floor(textureStart.Y / texture.Height);

		// Calculate how many tiles we need to draw (add 2 to ensure coverage)
		int tilesNeededX = (int)Math.Ceiling((float)Engine.GameWidth / texture.Width) + 1;
		int tilesNeededY = (int)Math.Ceiling((float)Engine.GameHeight / texture.Height) + 1;

		// Draw tiles
		for (int tileX = 0; tileX < tilesNeededX; tileX++)
		{
			if (!RepeatX && (startTileX + tileX) != 0) continue;

			for (int tileY = 0; tileY < tilesNeededY; tileY++)
			{
				if (!RepeatY && (startTileY + tileY) != 0) continue;

				// Calculate world position for this tile
				Vector2 tileWorldPos = parallaxPosition + new Vector2(
					(startTileX + tileX) * texture.Width,
					(startTileY + tileY) * texture.Height
				);

				// Draw the full texture at this tile position
				Rectangle sourceRectangle = new(0, 0, texture.Width, texture.Height);
				texture.Draw(sourceRectangle, tileWorldPos, Colors.White);
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
