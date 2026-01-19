using System.Numerics;

namespace Clockwork.Utilities;

public static class QuaternionExtensions
{
	public static Vector3 GetForward(this Quaternion quaternion)
	{
		return Vector3.Transform(Vector3.UnitZ, quaternion);
	}

	public static Vector3 GetBack(this Quaternion quaternion)
	{
		return Vector3.Transform(-Vector3.UnitZ, quaternion);
	}

	public static Vector3 GetRight(this Quaternion quaternion)
	{
		return Vector3.Transform(Vector3.UnitX, quaternion);
	}

	public static Vector3 GetLeft(this Quaternion quaternion)
	{
		return Vector3.Transform(-Vector3.UnitX, quaternion);
	}

	public static Vector3 GetUp(this Quaternion quaternion)
	{
		return Vector3.Transform(Vector3.UnitY, quaternion);
	}

	public static Vector3 GetDown(this Quaternion quaternion)
	{
		return Vector3.Transform(-Vector3.UnitY, quaternion);
	}
}
