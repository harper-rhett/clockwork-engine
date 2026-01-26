using System.Numerics;
using System.Runtime.InteropServices;

namespace Clockwork.Graphics;

[StructLayout(LayoutKind.Sequential)]
public struct RaylibCamera2D
{
	public Vector2 Offset = Vector2.Zero;
	public Vector2 Position = Vector2.Zero;
	public float Rotation = 0;
	public float Zoom = 1;

	public RaylibCamera2D(Vector2 position, float rotation, float zoom)
	{
		Position = position;
		Rotation = rotation;
		Zoom = zoom;
	}

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "BeginMode2D")]
	public static extern void BeginRendering(RaylibCamera2D camera2D);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "EndMode2D")]
	public static extern void EndRendering();

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetCameraMatrix2D")]
	private static extern Matrix4x4 GetMatrix(RaylibCamera2D camera2D);
	public Matrix4x4 Matrix => GetMatrix(this);
}