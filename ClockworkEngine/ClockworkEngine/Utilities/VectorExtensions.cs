using System.Numerics;

namespace Clockwork.Utilities;

public static class VectorExtensions
{
	public static Vector2 Projected(this Vector2 sourceVector, Vector2 basisVector)
	{
		float secondDot = Vector2.Dot(basisVector, basisVector);
		if (secondDot == 0) return Vector2.Zero;
		float bothDot = Vector2.Dot(sourceVector, basisVector);
		float scalar = bothDot / secondDot;
		return basisVector * scalar;
	}

	public static Vector2 Rounded(this Vector2 vector)
	{
		return new(vector.X.Rounded(), vector.Y.Rounded());
	}

	public static Vector2 Floored(this Vector2 vector)
	{
		return new(vector.X.Floored(), vector.Y.Floored());
	}

	public static Vector2 Ceiled(this Vector2 vector)
	{
		return new(vector.X.Ceiled(), vector.Y.Ceiled());
	}

	public static Vector2 Averaged(Vector2 firstVector, Vector2 secondVector)
	{
		return (firstVector + secondVector) / 2f;
	}

	public static Vector2 SetX(this Vector2 vector, float x)
	{
		return new Vector2(x, vector.Y);
	}

	public static Vector2 SetY(this Vector2 vector, float y)
	{
		return new Vector2(vector.X, y);
	}

	public static Vector2 NegateX(this Vector2 vector)
	{
		return vector.SetX(-vector.X);
	}

	public static Vector2 NegateY(this Vector2 vector)
	{
		return vector.SetY(-vector.Y);
	}

	public static Vector2 Normalized(this Vector2 vector)
	{
		return Vector2.Normalize(vector);
	}

	public static Vector2 Snapped(this Vector2 vector, float gridSize)
	{
		return (vector / gridSize).Rounded() * gridSize;
	}

	public static Vector2 DirectionTo(this Vector2 originVector, Vector2 targetVector)
	{
		return Vector2.Normalize(targetVector - originVector);
	}

	public static Vector3 DirectionTo(this Vector3 originVector, Vector3 targetVector)
	{
		return Vector3.Normalize(targetVector - originVector);
	}
}
