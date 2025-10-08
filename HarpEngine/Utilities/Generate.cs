namespace HarpEngine.Utilities;

public static class Generate
{
	private static Random random = new();
	public static int Seed
	{
		set => random = new(value);
	}

	public static double Double()
	{
		return random.NextDouble();
	}

	public static long Long()
	{
		return random.NextInt64();
	}

	public static float Float()
	{
		return random.NextSingle();
	}

	public static float Float(float max)
	{
		return Float() * max;
	}

	public static float Float(float min, float max)
	{
		return min + Float() * (max - min);
	}

	public static bool Bool()
	{
		return random.NextDouble() > 0.5;
	}

	public static float Radians()
	{
		return Float() * MathF.Tau;
	}

	public static float Degrees()
	{
		return Float() * 360f;
	}

	public static Vector2 Vector2()
	{
		float radians = Radians();
		float x = MathF.Cos(radians);
		float y = MathF.Sin(radians);
		Vector2 randomVector = new Vector2(x, y);
		return System.Numerics.Vector2.Normalize(randomVector);
	}
}
