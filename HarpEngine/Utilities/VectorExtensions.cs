namespace HarpEngine.Utilities;

public static class VectorExtensions
{
	public static int GetXRounded(this Vector2 vector2)
	{
		return (int)float.Round(vector2.X);
	}

	public static int GetYRounded(this Vector2 vector2)
	{
		return (int)float.Round(vector2.Y);
	}
}
