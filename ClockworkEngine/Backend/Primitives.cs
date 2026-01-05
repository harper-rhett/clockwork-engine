using System.Numerics;
using Clockwork.Graphics;

namespace Clockwork.Backend;

public interface IBackendPrimitives
{
	// Pixels
	public void DrawPixel(int x, int y, Color color);
	public void DrawPixel(Vector2 position, Color color);

	// Lines
	public void DrawLine(int startX, int startY, int endX, int endY, Color color);
	public void DrawLine(Vector2 startPosition, Vector2 endPosition, Color color);
	public void DrawLine(Vector2 startPosition, Vector2 endPosition, float thickness, Color color);
	//TODO: public void DrawLines(Vector2[] positions, Color color);

	// Circles
	public void DrawCircle(int x, int y, float radius, Color color);
	public void DrawCircle(Vector2 position, float radius, Color color);
	//TODO: public void DrawCircleOutline(Vector2 position, float radius, float lineThickness, Color color);
	public void DrawEllipse(int x, int y, float horizontalRadius, float verticalRadius, Color color);
	public void DrawEllipse(Vector2 position, float horizontalRadius, float verticalRadius, Color color);
	//TODO: public void DrawEllipseOutline(Vector2 position, float horizontalRadius, float verticalRadius, float lineThickness, Color color);

	// Rectangles
	public void DrawRectangle(int x, int y, int width, int height, Color color);
	public void DrawRectangle(Vector2 position, Vector2 size, Color color);
	public void DrawRectangle(Rectangle rectangle, Color color);
	public void DrawRectangle(Rectangle rectangle, Vector2 origin, float rotation, Color color);
	// TODO: public void DrawRectangleOutline(Rectangle rectangle, Vector2 origin, float rotation, float lineThickness, Color color);
	public void DrawSquare(int x, int y, int size, Color color);
	public void DrawSquare(Vector2 position, int size, Color color);
	// TODO: public void DrawSquareOutline(Vector2 position, int size, float lineThickness, Color color);

	// Triangles
	public void DrawTriangle(Vector2 cornerOne, Vector2 cornerTwo, Vector2 cornerThree, Color color);
	//TODO: public void DrawTriangleOutline(Vector2 cornerOne, Vector2 cornerTwo, Vector2 cornerThree, float lineThickness, Color color);

	// Polygons
	public void DrawPolygon(Vector2 position, int sides, float radius, float rotation, Color color);
	//TODO: public void DrawPolygonOutline(Vector2 position, int sides, float radius, float rotation, float lineThickness, Color color);
}
