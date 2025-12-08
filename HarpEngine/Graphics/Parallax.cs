using System.Collections.Generic;

namespace HarpEngine.Graphics;

public class Parallax : Entity
{
	private Camera2D camera;
	private List<Layer> layers = new();

	public Parallax(Camera2D camera)
	{
		this.camera = camera;
	}

	public void AddLayer(Texture backgroundTexture, Vector2 offset, float speed)
	{
		layers.Add(new(backgroundTexture, offset, speed));
	}

	public override void OnDraw()
	{
		foreach (Layer layer in layers)
		{
			Vector2 position = camera.Transform.WorldPosition * -layer.Speed + layer.Offset;
			layer.Texture.Draw(position, Colors.White);
			Console.WriteLine(position);
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
