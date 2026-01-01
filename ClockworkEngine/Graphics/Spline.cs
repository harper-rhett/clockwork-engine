namespace Clockwork.Graphics;

public static class Spline
{
	// Drawing

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawSplineLinear")]
	private static extern void DrawLinear(Vector2[] positions, int positionCount, float thickness, Color color);
	public static void DrawLinear(Vector2[] positions, float thickness, Color color) => DrawLinear(positions, positions.Length, thickness, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawSplineBasis")]
	private static extern void DrawBasis(Vector2[] positions, int positionCount, float thickness, Color color);
	public static void DrawBasis(Vector2[] positions, float thickness, Color color) => DrawBasis(positions, positions.Length, thickness, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawSplineCatmullRom")]
	private static extern void DrawCatmullRom(Vector2[] positions, int positionCount, float thickness, Color color);
	public static void DrawCatmullRom(Vector2[] positions, float thickness, Color color) => DrawCatmullRom(positions, positions.Length, thickness, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawSplineBezierQuadratic")]
	private static extern void DrawBezierQuadratic(Vector2[] positions, int positionCount, float thickness, Color color);
	public static void DrawBezierQuadratic(Vector2[] positions, float thickness, Color color) => DrawBezierQuadratic(positions, positions.Length, thickness, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawSplineBezierCubic")]
	private static extern void DrawBezierCubic(Vector2[] positions, int positionCount, float thickness, Color color);
	public static void DrawBezierCubic(Vector2[] positions, float thickness, Color color) => DrawBezierCubic(positions, positions.Length, thickness, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawSplineSegmentLinear")]
	public static extern void DrawSegmentLinear(Vector2 startPosition, Vector2 endPosition, float thickness, Color color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawSplineSegmentBasis")]
	public static extern void DrawSegmentBasis(Vector2 positionOne, Vector2 positionTwo, Vector2 positionThree, Vector2 positionFour, float thickness, Color color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawSplineSegmentCatmullRom")]
	public static extern void DrawSegmentCatmullRom(Vector2 positionOne, Vector2 positionTwo, Vector2 positionThree, Vector2 positionFour, float thickness, Color color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawSplineSegmentBezierQuadratic")]
	public static extern void DrawSegmentBezierQuadratic(Vector2 positionOne, Vector2 controlPosition, Vector2 positionTwo, float thickness, Color color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawSplineSegmentBezierCubic")]
	public static extern void DrawSegmentBezierCubic(Vector2 positionOne, Vector2 controlPositionOne, Vector2 controlPositionTwo, Vector2 positionTwo, float thickness, Color color);

	// Math

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetSplinePointLinear")]
	public static extern Vector2 GetPointLinear(Vector2 startPosition, Vector2 endPosition, float progress);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetSplinePointBasis")]
	public static extern Vector2 GetPointBasis(Vector2 positionOne, Vector2 positionTwo, Vector2 positionThree, Vector2 positionFour, float progress);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetSplinePointCatmullRom")]
	public static extern Vector2 GetPointCatmullRom(Vector2 positionOne, Vector2 positionTwo, Vector2 positionThree, Vector2 positionFour, float progress);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetSplinePointBezierQuad")]
	public static extern Vector2 GetPointBezierQuad(Vector2 positionOne, Vector2 controlPosition, Vector2 positionTwo, float progress);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetSplinePointBezierCubic")]
	public static extern Vector2 GetPointBezierCubic(Vector2 positionOne, Vector2 controlPositionOne, Vector2 controlPositionTwo, Vector2 positionTwo, float progress);
}
