using System.Numerics;
using System.Runtime.InteropServices;

namespace Clockwork.Graphics;

public static class Primitives
{
	// Pixels

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawPixel")]
	public static extern void DrawPixel(int x, int y, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawPixelV")]
	public static extern void DrawPixel(Vector2 position, Color color);

	// Lines

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawLine")]
	public static extern void DrawLine(int startX, int startY, int endX, int endY, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawLineV")]
	public static extern void DrawLine(Vector2 startPosition, Vector2 endPosition, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawLineEx")]
	public static extern void DrawLine(Vector2 startPosition, Vector2 endPosition, float thickness, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawLineStrip")]
	private static extern void DrawLine(Vector2[] positions, int positionCount, Color color);
	public static void DrawLine(Vector2[] positions, Color color) => DrawLine(positions, positions.Length, color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawLineBezier")]
	public static extern void DrawBezier(Vector2 startPosition, Vector2 endPosition, float thickness, Color color);

	// Circles

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawCircle")]
	public static extern void DrawCircle(int x, int y, float radius, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawCircleSector")]
	public static extern void DrawArc(Vector2 position, float radius, float startAngle, float endAngle, int segments, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawCircleSectorLines")]
	public static extern void DrawArcLines(Vector2 position, float radius, float startAngle, float endAngle, int segments, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawCircleGradient")]
	public static extern void DrawCircle(int x, int y, float radius, Color innerColor, Color outerColor);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawCircleV")]
	public static extern void DrawCircle(Vector2 position, float radius, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawCircleLines")]
	public static extern void DrawCircleLines(int x, int y, float radius, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawCircleLinesV")]
	public static extern void DrawCircleLines(Vector2 position, float radius, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawEllipse")]
	public static extern void DrawEllipse(int x, int y, float horizontalRadius, float verticalRadius, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawEllipseLines")]
	public static extern void DrawEllipseLines(int x, int y, float horizontalRadius, float verticalRadius, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawRings")]
	public static extern void DrawRing(Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawRingLines")]
	public static extern void DrawRingLines(Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Color color);

	// Rectangles

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawRectangle")]
	public static extern void DrawRectangle(int x, int y, int width, int height, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawRectangleV")]
	public static extern void DrawRectangle(Vector2 position, Vector2 size, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawRectangleRec")]
	public static extern void DrawRectangle(Rectangle rectangle, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawRectanglePro")]
	public static extern void DrawRectangle(Rectangle rectangle, Vector2 origin, float rotation, Color color);

	public static void DrawSquare(int x, int y, int size, Color color) => DrawRectangle(x, y, size, size, color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawRectangleGradientV")]
	public static extern void DrawRectangleGradientVertical(int x, int y, int width, int height, Color topColor, Color bottomColor);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawRectangleGradientH")]
	public static extern void DrawRectangleGradientHorizontal(int x, int y, int width, int height, Color leftColor, Color rightColor);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawRectangleGradientEx")]
	public static extern void DrawRectangleGradient(Rectangle rectangle, Color topLeftColor, Color bottomLeftColor, Color topRightColor, Color bottomRightColor);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawRectangleLines")]
	public static extern void DrawRectangleLines(int x, int y, int width, int height, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawRectangleLinesEx")]
	public static extern void DrawRectangleLines(Rectangle rectangle, float lineThickness, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawRectangleRounded")]
	public static extern void DrawRectangleRounded(Rectangle rectangle, float roundness, int segments, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawRectangleRoundedLines")]
	public static extern void DrawRectangleRoundedLines(Rectangle rectangle, float roundness, int segments, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawRectangleRoundedLinesEx")]
	public static extern void DrawRectangleRoundedLines(Rectangle rectangle, float roundness, int segments, float lineThickness, Color color);

	// Triangles

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawTriangle")]
	public static extern void DrawTriangle(Vector2 cornerOne, Vector2 cornerTwo, Vector2 cornerThree, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawTriangleLines")]
	public static extern void DrawTriangleLines(Vector2 cornerOne, Vector2 cornerTwo, Vector2 cornerThree, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawTriangleFan")]
	private static extern void DrawTriangleFan(Vector2[] positions, int positionCount, Color color);
	public static void DrawTriangleFan(Vector2[] positions, Color color) => DrawTriangleFan(positions, positions.Length, color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawTriangleStrip")]
	private static extern void DrawTriangleStrip(Vector2[] positions, int positionCount, Color color);
	public static void DrawTriangleStrip(Vector2[] positions, Color color) => DrawTriangleStrip(positions, positions.Length, color);

	// Polygons

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawPoly")]
	public static extern void DrawPolygon(Vector2 position, int sides, float radius, float rotation, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawPolyLines")]
	public static extern void DrawPolygonLines(Vector2 position, int sides, float radius, float rotation, Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawPolyLinesEx")]
	public static extern void DrawPolygonLines(Vector2 position, int sides, float radius, float rotation, float lineThickness, Color color);
}
