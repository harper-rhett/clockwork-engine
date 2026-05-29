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

	private void QueryLeafNodes(IList<QuadtreeNode<ItemType>> queriedNodes) => rootNode.QueryLeafNodes(queriedNodes);

	public void QueryBounds(IList<Rectangle> queriedBounds) => rootNode.QueryBounds(queriedBounds);

	private void QueryLeafNodes(Vector2 position, float radius, IList<QuadtreeNode<ItemType>> queriedNodes) => rootNode.QueryLeafNodes(position, radius, queriedNodes);

	public void QueryBounds(Vector2 position, float radius, IList<Rectangle> queriedBounds) => rootNode.QueryBounds(position, radius, queriedBounds);

	private void QueryPoints(Vector2 position, float radius, float radiusSquared, IList<QuadtreePoint<ItemType>> queriedPoints) => rootNode.QueryPoints(position, radius, radiusSquared, queriedPoints);

	public void QueryItems(Vector2 position, float radius, float radiusSquared, IList<ItemType> queriedItems) => rootNode.QueryItems(position, radius, radiusSquared, queriedItems);

	public void QueryItems(Vector2 position, float radius, float radiusSquared, IList<ItemType> queriedItems, IList<float> distancesSquared) => rootNode.QueryItems(position, radius, radiusSquared, queriedItems, distancesSquared);

	public void QueryItems(Vector2 position, float radius, float radiusSquared, IList<ItemType> queriedItems, IList<Vector2> differences, IList<float> distancesSquared) => rootNode.QueryItems(position, radius, radiusSquared, queriedItems, differences, distancesSquared);

	private void QueryPoints(IList<QuadtreePoint<ItemType>> queriedPoints) => rootNode.QueryPoints(queriedPoints);

	public ItemType QueryClosestItem(Vector2 position)
	{
		ItemType closestItem = default;
		float minDistance = float.PositiveInfinity;
		rootNode.QueryClosestItem(position, ref minDistance, ref closestItem);
		return closestItem;
	}

	public bool AnyItemInRadius(Vector2 position, float radius, float radiusSquared) => rootNode.AnyItemInRadius(position, radius, radiusSquared);

	public void DrawBounds(float lineThickness, Color color)
	{
		List<Rectangle> bounds = new();
		QueryBounds(bounds);
		foreach (Rectangle rectangle in bounds)
		{
			Primitives2D.DrawRectangleLines(rectangle, lineThickness, color);
		}
	}

	public void DrawPoints(float pointRadius, Color color)
	{
		List<QuadtreePoint<ItemType>> points = new();
		QueryPoints(points);
		foreach (QuadtreePoint<ItemType> point in points)
		{
			Primitives2D.DrawCircle(point.Position, pointRadius, color);
		}
	}
}