using System.Numerics;
using System.Runtime.InteropServices;

namespace Clockwork.Graphics;

[StructLayout(LayoutKind.Sequential)]
public struct Camera2DInternal
{
	public Vector2 Offset = Vector2.Zero;
	public Vector2 Position = Vector2.Zero;
	public float Rotation = 0;
	public float Zoom = 1;

	public Camera2DInternal(Vector2 position, float rotation, float zoom)
	{
		Position = position;
		Rotation = rotation;
		Zoom = zoom;
	}

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "BeginMode2D")]
	public static extern void BeginRendering(Camera2DInternal camera2D);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "EndMode2D")]
	public static extern void EndRendering();

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetCameraMatrix2D")]
	private static extern Matrix4x4 GetMatrix(Camera2DInternal camera2D);
	public Matrix4x4 Matrix => GetMatrix(this);
}