namespace Clockwork.Utilities;

public static class Generate
{
	private static Seed seed = new();
	public static int Seed
	{
		set => seed = new(value);
	}

	public static int Integer() => seed.NextInteger();
	public static int Integer(int max) => seed.NextInteger(max);
	public static int Integer(int min, int max) => seed.NextInteger(min, max);
	public static float Float() => seed.NextFloat();
	public static float Float(float max) => seed.NextFloat(max);
	public static float Float(float min, float max) => seed.NextFloat(min, max);
	public static double Double() => seed.NextDouble();
	public static long Long() => seed.NextLong();
	public static bool Bool() => seed.NextBool();
	public static float Radians() => seed.NextRadians();
	public static float Degrees() => seed.NextDegrees();
	public static Vector2 UnitVector2() => seed.NextUnitVector2();
}
