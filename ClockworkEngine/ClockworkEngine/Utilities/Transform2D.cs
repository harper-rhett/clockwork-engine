using System.Numerics;

namespace Clockwork.Utilities;

public class Transform2D
{
	public Transform2D Parent;

	public Vector2 WorldPosition
	{
		get => Parent is null ? LocalPosition : Vector2.Transform(LocalPosition, Parent.Matrix);
		set => LocalPosition = Parent is null ? value : Vector2.Transform(value, Parent.MatrixInverse);
	}

	public Vector2 LocalPosition;

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
			Matrix3x2 translationMatrix = Matrix3x2.CreateTranslation(LocalPosition);
			Matrix3x2 rotationMatrix = Matrix3x2.CreateRotation(float.DegreesToRadians(LocalRotation));
			Matrix3x2 localToWorld = rotationMatrix * translationMatrix;
			if (Parent is null) return localToWorld;
			else return localToWorld * Parent.Matrix;
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

	public Vector2 Up => Vector2.TransformNormal(new(0, -1), Matrix);
	public Vector2 Down => Vector2.TransformNormal(new(0, 1), Matrix);
	public Vector2 Left => Vector2.TransformNormal(new(-1, 0), Matrix);
	public Vector2 Right => Vector2.TransformNormal(new(1, 0), Matrix);

	public Transform2D() { }

	public Transform2D(Vector2 position, float rotation)
	{
		WorldPosition = position;
		WorldRotation = rotation;
	}
}
