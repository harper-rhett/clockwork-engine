using System.Numerics;

namespace Clockwork.Utilities;

public class TranslationTransform2D
{
	public TranslationTransform2D Parent;

	public Vector2 WorldPosition
	{
		get => Parent is null ? LocalPosition : Vector2.Transform(LocalPosition, Parent.Matrix);
		set => LocalPosition = Parent is null ? value : Vector2.Transform(value, Parent.MatrixInverse);
	}

	public Vector2 LocalPosition;

	public Matrix3x2 Matrix
	{
		get
		{
			Matrix3x2 translationMatrix = Matrix3x2.CreateTranslation(LocalPosition);
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
