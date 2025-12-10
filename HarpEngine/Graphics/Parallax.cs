using System.Collections.Generic;

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
			layer.Texture.Draw(position, Colors.White);
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
