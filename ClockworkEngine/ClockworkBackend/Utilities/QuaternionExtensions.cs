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

	public static Quaternion CreateRotation(Vector3 axis, float radians)
	{
		float halfAngle = radians / 2f;
		float sin = float.Sin(halfAngle);
		float cos = float.Cos(halfAngle);

		return new(
			axis.X * sin,
			axis.Y * sin,
			axis.Z * sin,
			cos
		);
	}

	public static Quaternion RotateWorldAxis(this Quaternion quaternion, Vector3 worldAxis, float radians)
	{
		Quaternion rotation = CreateRotation(worldAxis, radians);
		Quaternion rotatedQuaternion = rotation * quaternion;
		return rotatedQuaternion;
	}

	public static Quaternion RotateLocalAxis(this Quaternion quaternion, Vector3 localAxis, float radians)
	{
		Quaternion rotation = CreateRotation(localAxis, radians);
		Quaternion rotatedQuaternion = quaternion * rotation;
		return rotatedQuaternion;
	}
}
