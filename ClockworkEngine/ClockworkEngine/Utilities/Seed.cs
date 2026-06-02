using Clockwork.Graphics;
using System;
using System.Collections.Generic;
using System.Numerics;

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
		public int NextInteger(int minInclusive, int maxExclusive) => random.Next(minInclusive, maxExclusive);

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
			return NextBool(0.5f);
		}

		public bool NextBool(float trueChance)
		{
			return NextDouble() < trueChance;
		}

		public float NextRadians()
		{
			return NextFloat() * float.Tau;
		}

		public float NextDegrees()
		{
			return NextFloat() * 360f;
		}

		public Vector2 NextUnitVector2()
		{
			float radians = NextRadians();
			float x = float.Cos(radians);
			float y = float.Sin(radians);
			return new Vector2(x, y);
		}

		public Vector2 NextVector2(float westX, float northY, float eastX, float southY)
		{
			float x = NextFloat(westX, eastX);
			float y = NextFloat(northY, southY);
			return new Vector2(x, y);
		}

		public Vector2 NextVector2(Rectangle bounds)
		{
			return NextVector2(bounds.X, bounds.X + bounds.Width, bounds.Y, bounds.Y + bounds.Height);
		}

		public Vector3 NextUnitVector3()
		{
			float azimuth = NextRadians();
			float z = NextFloat(-1f, 1f);
			float radius = float.Sqrt(1f - z * z);

			float x = radius * float.Cos(azimuth);
			float y = radius * float.Sin(azimuth);
			return new Vector3(x, y, z);
		}

		public void ShuffleNextList<Type>(IList<Type> list)
		{
			for (int index = list.Count - 1; index > 0; index--)
			{
				int randomIndex = NextInteger(index + 1);
				(list[index], list[randomIndex]) = (list[randomIndex], list[index]);
			}
		}

		public List<Type> GetNextShuffledList<Type>(IList<Type> list)
		{
			List<Type> shuffledList = new(list);
			ShuffleNextList(shuffledList);
			return shuffledList;
		}

		public int NextIndex<Type>(ICollection<Type> collection)
		{
			return NextInteger(collection.Count);
		}

		public Type NextItem<Type>(IList<Type> list)
		{
			int randomIndex = NextIndex(list);
			return list[randomIndex];
		}

		public void RemoveNextItem<Type>(IList<Type> list)
		{
			list.RemoveAt(NextIndex(list));
		}
	}
}
