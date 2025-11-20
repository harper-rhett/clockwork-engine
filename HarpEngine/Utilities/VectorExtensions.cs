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
}
