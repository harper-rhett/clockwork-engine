using System.Numerics;

namespace Clockwork.Utilities;

public class Transform3D
{
	public Transform3D Parent;

	public Vector3 WorldPosition
	{
		get => Parent is null ? LocalPosition : Vector3.Transform(LocalPosition, Parent.Matrix);
		set => LocalPosition = Parent is null ? value : Vector3.Transform(value, Parent.MatrixInverse);
	}
	public Vector3 Position
	{
		get => WorldPosition;
		set => WorldPosition = value;
	}

	public Vector3 LocalPosition;

	public Quaternion WorldRotation
	{
		get => Parent is null ? LocalRotation : Parent.WorldRotation * LocalRotation;
		set => LocalRotation = Parent is null ? value : Quaternion.Inverse(Parent.WorldRotation) * value;
	}
	public Quaternion Rotation
	{
		get => WorldRotation;
		set => WorldRotation = value;
	}

	public Quaternion LocalRotation = Quaternion.Identity;

	public Matrix4x4 Matrix
	{
		get
		{
			Matrix4x4 translationMatrix = Matrix4x4.CreateTranslation(WorldPosition);
			Matrix4x4 rotationMatrix = Matrix4x4.CreateFromQuaternion(WorldRotation);
			Matrix4x4 localToWorld = rotationMatrix * translationMatrix;
			if (Parent is null) return localToWorld;
			else return localToWorld * Parent.Matrix;
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

	public Transform3D() { }

	public Transform3D(Vector3 position, Quaternion rotation)
	{
		WorldPosition = position;
		WorldRotation = rotation;
	}
}
