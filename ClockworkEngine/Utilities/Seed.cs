namespace Clockwork.Utilities
{
	public class Seed
	{
		private Random random;

		public Seed()
		{
			random = new();
		}

		public Seed(int seed)
		{
			random = new(seed);
		}

		public int Value
		{
			set => random = new(value);
		}

		public int NextInteger() => random.Next();
		public int NextInteger(int max) => random.Next(max);
		public int NextInteger(int min, int max) => random.Next(min, max);

		public float NextFloat() => random.NextSingle();

		public float NextFloat(float max)
		{
			return NextFloat() * max;
		}

		public float NextFloat(float min, float max)
		{
			return min + NextFloat() * (max - min);
		}

		public double NextDouble()
		{
			return random.NextDouble();
		}

		public long NextLong()
		{
			return random.NextInt64();
		}

		public bool NextBool()
		{
			return NextDouble() > 0.5;
		}

		public float NextRadians()
		{
			return NextFloat() * MathF.Tau;
		}

		public float NextDegrees()
		{
			return NextFloat() * 360f;
		}

		public Vector2 NextUnitVector2()
		{
			float radians = NextRadians();
			float x = MathF.Cos(radians);
			float y = MathF.Sin(radians);
			Vector2 randomVector = new Vector2(x, y);
			return Vector2.Normalize(randomVector);
		}
	}
}
