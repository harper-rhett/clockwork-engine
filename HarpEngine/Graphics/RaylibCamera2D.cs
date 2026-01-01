namespace Clockwork.Graphics;

[StructLayout(LayoutKind.Sequential)]
internal struct RaylibCamera2D
{
	public Vector2 Offset;
	public Vector2 Target;
	public float Rotation;
	public float Zoom;

	public RaylibCamera2D(Vector2 offset, Vector2 target, float rotation, float zoom)
	{
		Offset = offset;
		Target = target;
		Rotation = rotation;
		Zoom = zoom;
	}

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "BeginMode2D")]
	public static extern void BeginRendering(RaylibCamera2D camera2D);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "EndMode2D")]
	public static extern void EndRendering();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetCameraMatrix2D")]
	private static extern Matrix4x4 GetMatrix(RaylibCamera2D camera2D);
	public Matrix4x4 Matrix => GetMatrix(this);
}