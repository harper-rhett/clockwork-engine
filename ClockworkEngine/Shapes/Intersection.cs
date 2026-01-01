namespace Clockwork.Shapes;

public static class Intersection
{
	public static bool PointInCircle(Vector2 pointPosition, Vector2 circlePosition, float radius)
	{
		float distance = Vector2.Distance(pointPosition, circlePosition);
		return distance < radius;
	}

	public static bool PointInCircleSquared(Vector2 pointPosition, Vector2 circlePosition, float radiusSquared)
	{
		float distanceSquared = Vector2.DistanceSquared(pointPosition, circlePosition);
		return distanceSquared < radiusSquared;
	}

	public static bool CircleOnCircle(Vector2 positionA, float radiusA, Vector2 positionB, float radiusB)
	{
		float distance = Vector2.Distance(positionA, positionB);
		return distance < radiusA + radiusB;
	}

	public static bool CircleOnCircleSquared(Vector2 positionA, float radiusSquaredA, Vector2 positionB, float radiusSquaredB)
	{
		float distanceSquared = Vector2.DistanceSquared(positionA, positionB);
		return distanceSquared < radiusSquaredA + radiusSquaredB;
	}

	public static bool CircleInCircle(Vector2 positionA, float radiusA, Vector2 positionB, float radiusB)
	{
		float distance = Vector2.Distance(positionA, positionB);
		return distance < radiusB - radiusA;
	}

	public static bool CircleInCircleSquared(Vector2 positionA, float radiusSquaredA, Vector2 positionB, float radiusSquaredB)
	{
		float distanceSquared = Vector2.DistanceSquared(positionA, positionB);
		return distanceSquared < radiusSquaredB - radiusSquaredA;
	}

	public static bool PointInRectangle(Vector2 pointPosition, Rectangle rectangle)
	{
		bool xIntersects = pointPosition.X >= rectangle.X && pointPosition.X <= rectangle.X + rectangle.Width;
		bool yIntersects = pointPosition.Y >= rectangle.Y && pointPosition.Y <= rectangle.Y + rectangle.Height;
		return xIntersects && yIntersects;
	}

	public static bool RectangleOnRectangle(Rectangle rectangleA, Rectangle rectangleB)
	{
		float rightEdgeA = rectangleA.X + rectangleA.Width;
		float bottomEdgeA = rectangleA.Y + rectangleA.Height;
		float rightEdgeB = rectangleB.X + rectangleB.Width;
		float bottomEdgeB = rectangleB.Y + rectangleB.Height;

		bool leftEdgePastRightEdge = rectangleA.X >= rightEdgeB;
		bool rightEdgeBeforeLeftEdge = rightEdgeA <= rectangleB.X;
		bool topEdgePastBottomEdge = rectangleA.Y >= bottomEdgeB;
		bool bottomEdgeBeforeTopEdge = bottomEdgeA <= rectangleB.Y;

		bool doesNotIntersect = leftEdgePastRightEdge || rightEdgeBeforeLeftEdge || topEdgePastBottomEdge || bottomEdgeBeforeTopEdge;
		return !doesNotIntersect;
	}

	public static bool CircleOnRectangle(Vector2 circlePosition, float circleRadius, Rectangle rectangle)
	{
		// Precalculate edges
		float rightEdge = rectangle.X + rectangle.Width;
		float bottomEdge = rectangle.Y + rectangle.Height;

		// Get left or right edge to check
		float xEdge;
		if (circlePosition.X < rectangle.X) xEdge = rectangle.X;
		else if (circlePosition.X > rightEdge) xEdge = rightEdge;
		else xEdge = circlePosition.X;

		// Get top or bottom edge to check
		float yEdge;
		if (circlePosition.Y < rectangle.Y) yEdge = rectangle.Y;
		else if (circlePosition.Y > bottomEdge) yEdge = bottomEdge;
		else yEdge = circlePosition.Y;

		// Get distance
		float xDistance = circlePosition.X - xEdge;
		float yDistance = circlePosition.Y - yEdge;
		float distance = float.Sqrt(xDistance * xDistance + yDistance * yDistance);

		// Check for intersection
		return distance <= circleRadius;
	}

	public static bool PointOnLine(Vector2 pointPosition, Vector2 lineStartPosition, Vector2 lineEndPosition, float tolerance)
	{
		// It may be better to project the point onto the line with the dot product,
		// then check the distance the original point is from the projected point,
		// determine if that distance falls within tolerance,
		// and finally determine if that projected point falls within the line start and end.

		// That is what CircleOnLine is doing.
		// The current method is inconsistent. It triggers more easily at the line's center than it does on its edge points.

		float lineLength = Vector2.Distance(lineStartPosition, lineEndPosition);
		float distanceToStart = Vector2.Distance(pointPosition, lineStartPosition);
		float distanceToEnd = Vector2.Distance(pointPosition, lineEndPosition);
		float distanceToBoth = distanceToStart + distanceToEnd;
		return distanceToBoth <= lineLength + tolerance;
	}

	// https://stackoverflow.com/a/1079478/13591389
	public static bool CircleOnLine(Vector2 circlePosition, float radius, Vector2 lineStartPosition, Vector2 lineEndPosition)
	{
		Vector2 lineStartToCircle = circlePosition - lineStartPosition; // AC
		Vector2 lineStartToEnd = lineEndPosition - lineStartPosition; // AB
		Vector2 projectedPosition = lineStartPosition + lineStartToCircle.Project(lineStartToEnd); // D

		float distanceToLine = Vector2.Distance(circlePosition, projectedPosition); // CD
		if (distanceToLine > radius) return false;

		float distanceToStart = Vector2.Distance(circlePosition, lineStartPosition);
		float distanceToEnd = Vector2.Distance(circlePosition, lineEndPosition);
		float distanceToBoth = distanceToStart + distanceToEnd - radius * 2;
		return distanceToBoth < lineStartToEnd.Length();
	}

	// https://paulbourke.net/geometry/pointlineplane/
	public static bool LineOnLine(Vector2 startPositionA, Vector2 endPositionA, Vector2 startPositionB, Vector2 endPositionB)
	{
		// Get differences
		float xDiffStart = startPositionA.X - startPositionB.X; // x1 - x3
		float yDiffStart = startPositionA.Y - startPositionB.Y; // y1 - y3
		float xDiffA = endPositionA.X - startPositionA.X; // x2 - x1
		float yDiffA = endPositionA.Y - startPositionA.Y; // y2 - y1
		float xDiffB = endPositionB.X - startPositionB.X; // x4 - x3
		float yDiffB = endPositionB.Y - startPositionB.Y; // y4 - y3

		// Denominator: (y4 - y3) * (x2 - x1) - (x4 - x3) * (y2 - y1)
		float denominator = yDiffB * xDiffA - xDiffB * yDiffA;
		if (denominator == 0) return false;

		// First Numerator: (x4 - x3) * (y1 - y3) - (y4 - y3) * (x1 - x3)
		float firstNumerator = xDiffB * yDiffStart - yDiffB * xDiffStart;
		float firstIntersection = firstNumerator / denominator;
		bool firstIntersects = firstIntersection >= 0 && firstIntersection <= 1;
		if (!firstIntersects) return false;

		// Second Numerator: (x2 - x1) * (y1 - y3) - (y2 - y1) * (x1 - x3)
		float secondNumerator = xDiffA * yDiffStart - yDiffA * xDiffStart;
		float secondIntersection = secondNumerator / denominator;
		bool secondIntersects = secondIntersection >= 0 && secondIntersection <= 1;

		// Check for intersection
		return secondIntersects;
	}

	public static bool LineOnRectangle(Vector2 lineStartPosition, Vector2 lineEndPosition, Rectangle rectangle)
	{
		// I am not happy with this method, but it is the easiest to implement for now.
		// Refer to Cohen–Sutherland and Liang–Barsky for more efficient algorithms.
		// https://en.wikipedia.org/w/index.php?title=Line_clipping&useskin=vector#Fast_clipping

		if (PointInRectangle(lineStartPosition, rectangle) || PointInRectangle(lineEndPosition, rectangle)) return true;

		float right = rectangle.X + rectangle.Width;
		float bottom = rectangle.Y + rectangle.Height;
		Vector2 topLeft = rectangle.Position;
		Vector2 topRight = new(right, rectangle.Y);
		Vector2 bottomLeft = new(rectangle.X, bottom);
		Vector2 bottomRight = new(right, bottom);

		return LineOnLine(lineStartPosition, lineEndPosition, topLeft, bottomLeft)
			|| LineOnLine(lineStartPosition, lineEndPosition, topRight, bottomRight)
			|| LineOnLine(lineStartPosition, lineEndPosition, topLeft, topRight)
			|| LineOnLine(lineStartPosition, lineEndPosition, bottomLeft, bottomRight);
	}
}
