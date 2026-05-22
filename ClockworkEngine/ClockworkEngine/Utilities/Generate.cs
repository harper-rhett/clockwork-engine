using System.Numerics;

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
	public static int Integer(int minInclusive, int maxExclusive) => seed.NextInteger(minInclusive, maxExclusive);
	public static float Float() => seed.NextFloat();
	public static float Float(float max) => seed.NextFloat(max);
	public static float Float(float min, float max) => seed.NextFloat(min, max);
	public static double Double() => seed.NextDouble();
	public static long Long() => seed.NextLong();
	public static bool Bool() => seed.NextBool();
	public static bool Bool(float trueChance) => seed.NextBool(trueChance);
	public static float Radians() => seed.NextRadians();
	public static float Degrees() => seed.NextDegrees();
	public static Vector2 UnitVector2() => seed.NextUnitVector2();
	public static Vector3 UnitVector3() => seed.NextUnitVector3();
	public static void Shuffle<Type>(IList<Type> list) => seed.Shuffle(list);
	public static int Index<Type>(ICollection<Type> collection) => seed.NextIndex(collection);
	public static int GetRandomIndex<Type>(this ICollection<Type> collection) => seed.NextIndex(collection);
	public static Type Item<Type>(IList<Type> list) => seed.NextItem(list);
	public static Type GetRandomItem<Type>(this IList<Type> list) => seed.NextItem(list);
}
