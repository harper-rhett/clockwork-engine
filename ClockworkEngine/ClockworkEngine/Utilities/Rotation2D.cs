using System.Numerics;

namespace Clockwork.Utilities;

public class Rotation2D : IRotation2D
{
	public Rotation2D Parent;

	public float WorldRotation
	{
		get => Parent is null ? LocalRotation : Parent.WorldRotation + LocalRotation;
		set => LocalRotation = Parent is null ? value : value - Parent.WorldRotation;
	}

	public float LocalRotation { get; set; }

	public static Matrix3x2 GetRotation(float localRotation) => Matrix3x2.CreateRotation(float.DegreesToRadians(localRotation));
	public Matrix3x2 Matrix
	{
		get
		{
			Matrix3x2 rotationMatrix = GetRotation(LocalRotation);
			if (Parent is null) return rotationMatrix;
			else return rotationMatrix * Parent.Matrix;
		}
	}

	public Matrix3x2 MatrixInverse
	{
		get
		{
			Matrix3x2.Invert(Matrix, out Matrix3x2 WorldToLocalMatrix);
			return WorldToLocalMatrix;
		}
	}
}
