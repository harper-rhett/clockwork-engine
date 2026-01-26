namespace Clockwork.Utilities;

public static class FloatExtensions
{
	public static int Rounded(this float value)
	{
		return (int)float.Round(value);
	}

	public static int Floored(this float value)
	{
		return (int)float.Floor(value);
	}

	public static int Ceiled(this float value)
	{
		return (int)float.Ceiling(value);
	}

	public static float Wrapped(this float value, float max)
	{
		return ((value % max) + max) % max;
	}

	public static float Wrapped(this float value, float max, out float wraps)
	{
		float result = value.Wrapped(max);
		wraps = (value - result) / max;
		return result;
	}
}
