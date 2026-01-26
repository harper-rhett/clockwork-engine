using Clockwork.Graphics.Draw2D;
using Clockwork.Graphics;
using System.Numerics;

namespace Clockwork.Particles;

internal abstract class ParticleRenderer2D
{
	public abstract void Draw(Particle2D particle);

	private Color GetParticleColor(Particle2D particle)
	{
		float progress = 1 - (particle.timeToDeath / particle.Lifespan);
		return particle.Gradient.Sample(progress);
	}

	public class Pixel : ParticleRenderer2D
	{
		public override void Draw(Particle2D particle)
		{
			Color color = GetParticleColor(particle);
			Primitives2D.DrawPixel(particle.Position, color);
		}
	}

	public class Circle : ParticleRenderer2D
	{
		private float radius;

		public Circle(float radius)
		{
			this.radius = radius;
		}

		public override void Draw(Particle2D particle)
		{
			Color color = GetParticleColor(particle);
			Primitives2D.DrawCircle(particle.Position, radius, color);
		}
	}

	public class Polygon : ParticleRenderer2D
	{
		private int sides;
		private float radius;

		public Polygon(int sides, float radius)
		{
			this.sides = sides;
			this.radius = radius;
		}

		public override void Draw(Particle2D particle)
		{
			Color color = GetParticleColor(particle);
			Primitives2D.DrawPolygon(particle.Position, sides, radius, particle.Rotation, color);
		}
	}

	public class Texture : ParticleRenderer2D
	{
		private Graphics.Texture texture;
		private Rectangle particleRectangle;
		private Vector2 textureOrigin;

		public Texture(Graphics.Texture texture)
		{
			this.texture = texture;
			particleRectangle = new(0, 0, texture.Width, texture.Height);
			textureOrigin = new(texture.Width / 2f, texture.Height / 2f);
		}

		public override void Draw(Particle2D particle)
		{
			Rectangle drawRectangle = new(particle.Position, texture.Width, texture.Height);
			Color color = GetParticleColor(particle);
			texture.Draw(particleRectangle, drawRectangle, textureOrigin, particle.Rotation, color);
		}
	}
}
