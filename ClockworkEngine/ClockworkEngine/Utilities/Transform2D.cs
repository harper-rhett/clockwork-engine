using System.Numerics;

namespace Clockwork.Utilities;

public class Transform2D : ITranslation2D, IRotation2D
{
	public Transform2D Parent;

	public Transform2D() { }

	public Transform2D(Vector2 position, float rotation)
	{
		WorldPosition = position;
		WorldRotation = rotation;
	}

	public Vector2 WorldPosition
	{
		get => Parent is null ? LocalPosition : Vector2.Transform(LocalPosition, Parent.Matrix);
		set => LocalPosition = Parent is null ? value : Vector2.Transform(value, Parent.MatrixInverse);
	}

	public Vector2 Position
	{
		get => WorldPosition;
		set => WorldPosition = value;
	}

	public Vector2 LocalPosition { get; set; }

	public Vector2 Up => Vector2.TransformNormal(new(0, -1), Matrix);
	public Vector2 Down => Vector2.TransformNormal(new(0, 1), Matrix);
	public Vector2 Left => Vector2.TransformNormal(new(-1, 0), Matrix);
	public Vector2 Right => Vector2.TransformNormal(new(1, 0), Matrix);

	public float WorldRotation
	{
		get => Parent is null ? LocalRotation : Parent.WorldRotation + LocalRotation;
		set => LocalRotation = Parent is null ? value : value - Parent.WorldRotation;
	}
	public float Rotation
	{
		get => WorldRotation;
		set => WorldRotation = value;
	}

	public float LocalRotation { get; set; }

	public Matrix3x2 Matrix
	{
		get
		{
			Matrix3x2 translationMatrix = Translation2D.GetTranslation(LocalPosition);
			Matrix3x2 rotationMatrix = Rotation2D.GetRotation(LocalRotation);
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
}
