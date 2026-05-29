using Clockwork.Graphics;
using Clockwork.Graphics.Draw2D;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

namespace Clockwork.Utilities;

public class Quadtree<ItemType>
{
	private QuadtreeNode<ItemType> rootNode;
	private Stack<QuadtreeNode<ItemType>> nodePool = new();

	public Quadtree(Vector2 position, float size, int nodeCapacity = 4)
	{
		rootNode = new(position, size, nodeCapacity, nodePool);
	}

	public void Add(ItemType item, Vector2 position)
	{
		QuadtreePoint<ItemType> quadtreeItem = new(item, position);
		rootNode.Add(quadtreeItem);
	}

	public void Clear()
	{
		rootNode.Reclaim(true);
	}

	private void CollectLeafNodes(ICollection<QuadtreeNode<ItemType>> collectedNodes) => rootNode.CollectLeafNodes(collectedNodes);

	public void CollectLeafBounds(ICollection<Rectangle> collectedBounds) => rootNode.CollectLeafBounds(collectedBounds);

	private void CollectNodesIntersectingRadius(Vector2 position, float radius, ICollection<QuadtreeNode<ItemType>> collectedNodes) => rootNode.CollectNodesIntersecting(position, radius, collectedNodes);

	public void CollectBoundsIntersectingRadius(Vector2 position, float radius, ICollection<Rectangle> collectedBounds) => rootNode.CollectBoundsIntersecting(position, radius, collectedBounds);

	private void CollectPointsWithinRadius(Vector2 position, float radius, float radiusSquared, ICollection<QuadtreePoint<ItemType>> collectedPoints) => rootNode.CollectPointsWithin(position, radius, radiusSquared, collectedPoints);

	public void CollectItemsWithinRadius(Vector2 position, float radius, float radiusSquared, ICollection<ItemType> collectedItems) => rootNode.CollectItemsWithin(position, radius, radiusSquared, collectedItems);

	private void CollectPoints(ICollection<QuadtreePoint<ItemType>> collectedPoints) => rootNode.CollectPoints(collectedPoints);

	private bool AnyItemInRadius(Vector2 position, float radius, float radiusSquared) => rootNode.AnyItemWithin(position, radius, radiusSquared);

	public void DrawBounds(float lineThickness, Color color)
	{
		List<Rectangle> bounds = new();
		CollectLeafBounds(bounds);
		foreach (Rectangle rectangle in bounds)
		{
			Primitives2D.DrawRectangleLines(rectangle, lineThickness, color);
		}
	}

	public void DrawPoints(float pointRadius, Color color)
	{
		List<QuadtreePoint<ItemType>> points = new();
		CollectPoints(points);
		foreach (QuadtreePoint<ItemType> point in points)
		{
			Primitives2D.DrawCircle(point.Position, pointRadius, color);
		}
	}
}