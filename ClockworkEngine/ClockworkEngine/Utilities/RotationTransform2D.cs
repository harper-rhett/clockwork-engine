using System.Numerics;

namespace Clockwork.Utilities;

public class RotationTransform2D
{
	public RotationTransform2D Parent;

	public float WorldRotation
	{
		get => Parent is null ? LocalRotation : Parent.WorldRotation + LocalRotation;
		set => LocalRotation = Parent is null ? value : value - Parent.WorldRotation;
	}

	public float LocalRotation;

	public Matrix3x2 Matrix
	{
		get
		{
			Matrix3x2 rotationMatrix = Matrix3x2.CreateRotation(float.DegreesToRadians(LocalRotation));
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
