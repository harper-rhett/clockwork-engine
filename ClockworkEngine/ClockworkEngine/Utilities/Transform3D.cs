using System.Numerics;

namespace Clockwork.Utilities;

public class Transform3D
{
	public Transform3D Parent;

	public Vector3 WorldPosition
	{
		get
		{
			if (Parent is null) return LocalPosition;
			else return Vector3.Transform(LocalPosition, Parent.Matrix);
		}

		set
		{
			if (Parent is null) LocalPosition = value;
			else LocalPosition = Vector3.Transform(value, Parent.MatrixInverse);
		}
	}

	public Vector3 LocalPosition;

	public Quaternion WorldRotation
	{
		get
		{
			if (Parent is null) return LocalRotation;
			else return Parent.WorldRotation * LocalRotation;
		}

		set
		{
			if (Parent is null) LocalRotation = value;
			else LocalRotation = Quaternion.Inverse(Parent.WorldRotation) * value;
		}
	}

	public Quaternion LocalRotation;

	public Matrix4x4 Matrix
	{
		get
		{
			Matrix4x4 translationMatrix = Matrix4x4.CreateTranslation(WorldPosition);
			Matrix4x4 rotationMatrix = Matrix4x4.CreateFromQuaternion(WorldRotation);
			Matrix4x4 localToWorld = rotationMatrix * translationMatrix;
			if (Parent is null) return localToWorld;
			else return Parent.Matrix * localToWorld;
		}
	}

	public Matrix4x4 MatrixInverse
	{
		get
		{
			Matrix4x4.Invert(Matrix, out Matrix4x4 WorldToLocalMatrix);
			return WorldToLocalMatrix;
		}
	}

	public Vector3 Forward => WorldRotation.GetForward();
	public Vector3 Back => WorldRotation.GetBack();
	public Vector3 Right => WorldRotation.GetRight();
	public Vector3 Left => WorldRotation.GetLeft();
	public Vector3 Up => WorldRotation.GetUp();
	public Vector3 Down => WorldRotation.GetDown();
}
