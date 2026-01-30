using System.Runtime.InteropServices;
using System.Numerics;
using Clockwork.Utilities;

namespace Clockwork.Graphics;

[StructLayout(LayoutKind.Sequential)]
public struct Camera3DInternal
{
	public Vector3 Position;
	public Vector3 Target;
	public Vector3 Up;
	public float FOVY;
	public CameraProjection Projection;

	public Camera3DInternal(Vector3 position, Vector3 target, Vector3 up, float fovy, CameraProjection projection)
	{
		Position = position;
		Target = target;
		Up = up;
		FOVY = fovy;
		Projection = projection;

		direction = Vector3.Normalize(target - position);
	}

	public Camera3DInternal(Vector3 position, Quaternion rotation, float fovy, CameraProjection projection)
	{
		Position = position;
		Rotation = rotation;
		FOVY = fovy;
		Projection = projection;
	}

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "BeginMode3D")]
	public static extern void BeginRendering(Camera3DInternal camera3D);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "EndMode3D")]
	public static extern void EndRendering();

	private Vector3 direction;
	public Quaternion Rotation
	{
		get => throw new NotImplementedException();
		set
		{
			direction = value.GetForward();
			Up = value.GetUp();
			Target = Position + direction;
		}
	}
}