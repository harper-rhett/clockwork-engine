using System.Numerics;

namespace Clockwork.Utilities;

public class Translation2D : ITranslation2D
{
	public Translation2D Parent;

	public Vector2 WorldPosition
	{
		get => Parent is null ? LocalPosition : Vector2.Transform(LocalPosition, Parent.Matrix);
		set => LocalPosition = Parent is null ? value : Vector2.Transform(value, Parent.MatrixInverse);
	}

	public Vector2 LocalPosition { get; set; }

	public static Matrix3x2 GetTranslation(Vector2 localPosition) => Matrix3x2.CreateTranslation(localPosition);
	public Matrix3x2 Matrix
	{
		get
		{
			Matrix3x2 translationMatrix = GetTranslation(LocalPosition);
			if (Parent is null) return translationMatrix;
			else return translationMatrix * Parent.Matrix;
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
