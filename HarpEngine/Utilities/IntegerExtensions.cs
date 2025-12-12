namespace HarpEngine.Utilities;

public static class IntegerExtensions
{
	public static int Wrapped(this int value, int max)
	{
		return ((value % max) + max) % max;
	}
}
