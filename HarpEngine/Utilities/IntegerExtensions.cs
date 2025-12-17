namespace HarpEngine.Utilities;

public static class IntegerExtensions
{
	public static int Wrapped(this int value, int max)
	{
		return ((value % max) + max) % max;
	}

	public static int Wrapped(this int value, int max, out int wraps)
	{
		int result = value.Wrapped(max);
		wraps = (value - result) / max;
		return result;
	}
}
