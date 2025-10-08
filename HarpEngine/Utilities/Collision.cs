namespace HarpEngine.Utilities;

public static class Collision
{
	public static bool PointInCircleSquared(Vector2 pointPosition, Vector2 circlePosition, float radiusSquared)
	{
		float distanceSquared = Vector2.DistanceSquared(pointPosition, circlePosition);
		return distanceSquared < radiusSquared;
	}

	public static bool CircleOnCircleSquared(Vector2 positionA, float radiusSquaredA, Vector2 positionB, float radiusSquaredB)
	{
		float distanceSquared = Vector2.DistanceSquared(positionA, positionB);
		return distanceSquared < radiusSquaredA + radiusSquaredB;
	}

	public static bool CircleInCircleSquared(Vector2 positionA, float radiusSquaredA, Vector2 positionB, float radiusSquaredB)
	{
		float distanceSquared = Vector2.DistanceSquared(positionA, positionB);
		return distanceSquared < radiusSquaredB - radiusSquaredA;
	}

	public static bool PointInRectangle(Vector2 pointPosition, Rectangle rectangle)
	{
		bool xCollides = pointPosition.X >= rectangle.X && pointPosition.X <= rectangle.X + rectangle.Width;
		bool yCollides = pointPosition.Y >= rectangle.Y && pointPosition.Y <= rectangle.Y + rectangle.Height;
		return xCollides && yCollides;
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

		bool doesNotCollide = leftEdgePastRightEdge || rightEdgeBeforeLeftEdge || topEdgePastBottomEdge || bottomEdgeBeforeTopEdge;
		return !doesNotCollide;
	}
}
