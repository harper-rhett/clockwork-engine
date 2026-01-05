using System.Numerics;
using System.Runtime.InteropServices;

namespace Clockwork.Graphics;

public static class Primitives
{
	private static IBackendPrimitives backendPrimitives => Engine.Graphics.Primitives;

	// Pixels
	public static void DrawPixel(int x, int y, Color color) => backendPrimitives.DrawPixel(x, y, color);
	public static void DrawPixel(Vector2 position, Color color) => backendPrimitives.DrawPixel(position, color);

	// Lines
	public static void DrawLine(int startX, int startY, int endX, int endY, float thickness, Color color) => backendPrimitives.DrawLine(startX, startY, endX, endY, thickness, color);
	public static void DrawLine(Vector2 startPosition, Vector2 endPosition, float thickness, Color color) => backendPrimitives.DrawLine(startPosition, endPosition, thickness, color);
	public static void DrawLines(Vector2[] positions, float thickness, Color color) => backendPrimitives.DrawLines(positions, thickness, color);

	// Circles
	public static void DrawCircle(int x, int y, float radius, Color color) => backendPrimitives.DrawCircle(x, y, radius, color);
	public static void DrawCircle(Vector2 position, float radius, Color color) => backendPrimitives.DrawCircle(position, radius, color);
	public static void DrawCircleOutline(Vector2 position, float radius, float lineThickness, Color color) => backendPrimitives.DrawCircleOutline(position, radius, lineThickness, color);
	public static void DrawEllipse(int x, int y, float horizontalRadius, float verticalRadius, Color color) => backendPrimitives.DrawEllipse(x, y, horizontalRadius, verticalRadius, color);
	public static void DrawEllipse(Vector2 position, float horizontalRadius, float verticalRadius, Color color) => backendPrimitives.DrawEllipse(position, horizontalRadius, verticalRadius, color);
	public static void DrawEllipseOutline(Vector2 position, float horizontalRadius, float verticalRadius, float lineThickness, Color color) => backendPrimitives.DrawEllipseOutline(position, horizontalRadius, verticalRadius, lineThickness, color);

	// Rectangles
	public static void DrawRectangle(int x, int y, int width, int height, Color color) => backendPrimitives.DrawRectangle(x, y, width, height, color);
	public static void DrawRectangle(Vector2 position, Vector2 size, Color color) => backendPrimitives.DrawRectangle(position, size, color);
	public static void DrawRectangle(Rectangle rectangle, Color color) => backendPrimitives.DrawRectangle(rectangle, color);
	public static void DrawRectangle(Rectangle rectangle, Vector2 origin, float rotation, Color color) => backendPrimitives.DrawRectangle(rectangle, origin, rotation, color);
	public static void DrawRectangleOutline(Rectangle rectangle, Vector2 origin, float rotation, float lineThickness, Color color) => backendPrimitives.DrawRectangleOutline(rectangle, origin, rotation, lineThickness, color);
	public static void DrawSquare(int x, int y, int size, Color color) => backendPrimitives.DrawSquare(x, y, size, color);
	public static void DrawSquare(Vector2 position, int size, Color color) => backendPrimitives.DrawSquare(position, size, color);
	public static void DrawSquareOutline(Vector2 position, int size, float lineThickness, Color color) => backendPrimitives.DrawSquareOutline(position, size, lineThickness, color);

	// Triangles
	public static void DrawTriangle(Vector2 cornerOne, Vector2 cornerTwo, Vector2 cornerThree, Color color) => backendPrimitives.DrawTriangle(cornerOne, cornerTwo, cornerThree, color);
	public static void DrawTriangleOutline(Vector2 cornerOne, Vector2 cornerTwo, Vector2 cornerThree, float lineThickness, Color color) => backendPrimitives.DrawTriangleOutline(cornerOne, cornerTwo, cornerThree, lineThickness, color);

	// Polygons
	public static void DrawPolygon(Vector2 position, int sides, float radius, float rotation, Color color) => backendPrimitives.DrawPolygon(position, sides, radius, rotation, color);
	public static void DrawPolygonOutline(Vector2 position, int sides, float radius, float rotation, float lineThickness, Color color) => backendPrimitives.DrawPolygonOutline(position, sides, radius, rotation, lineThickness, color);
}
