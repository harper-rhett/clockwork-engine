namespace ClockworkEngine.Graphics.Draw3D;

public static class Primitives3D
{
	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawLine3D")]
	public static extern void DrawLine(Vector3 startPosition, Vector3 endPosition, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawPoint3D")]
	public static extern void DrawPoint(Vector3 position, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawCircle3D")]
	public static extern void DrawCircle(Vector3 center, float radius, Vector3 axis, float angle, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawTriangle3D")]
	public static extern void DrawTriangle(Vector3 corner1, Vector3 corner2, Vector3 corner3, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawTriangleStrip3D")]
	public static extern void DrawTriangleStrip(Vector3[] positions, int positionCount, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawCube")]
	public static extern void DrawCube(Vector3 position, float width, float height, float length, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawCubeV")]
	public static extern void DrawCube(Vector3 position, Vector3 size, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawCubeWires")]
	public static extern void DrawCubeWires(Vector3 position, float width, float height, float length, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawCubeWiresV")]
	public static extern void DrawCubeWires(Vector3 position, Vector3 size, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawSphere")]
	public static extern void DrawSphere(Vector3 center, float radius, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawSpherEx")]
	public static extern void DrawSphere(Vector3 center, float radius, int rings, int slices, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawSphereWires")]
	public static extern void DrawSphereWires(Vector3 center, float radius, int rings, int slices, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawCylinder")]
	public static extern void DrawCylinder(Vector3 position, float radiusTop, float radiusBottom, float height, int slices, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawCylinderEx")]
	public static extern void DrawCylinder(Vector3 startPosition, Vector3 endPosition, float startRadius, float endRadius, int sides, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawCylinderWires")]
	public static extern void DrawCylinderWires(Vector3 position, float radiusTop, float radiusBottom, float height, int slices, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawCylinderWiresEx")]
	public static extern void DrawCylinderWires(Vector3 startPosition, Vector3 endPosition, float startRadius, float endRadius, int sides, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawCapsule")]
	public static extern void DrawCapsule(Vector3 startPosition, Vector3 endPosition, float radius, int slices, int rings, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawCapsuleWires")]
	public static extern void DrawCapsuleWires(Vector3 startPosition, Vector3 endPosition, float radius, int slices, int rings, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawPlane")]
	public static extern void DrawPlane(Vector3 center, Vector2 size, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawGrid")]
	public static extern void DrawGrid(int slices, float spacing);
}
