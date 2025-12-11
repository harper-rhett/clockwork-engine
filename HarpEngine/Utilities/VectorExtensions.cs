namespace HarpEngine.Utilities;

public static class VectorExtensions
{
	public static Vector2 Project(this Vector2 sourceVector, Vector2 basisVector)
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
}
