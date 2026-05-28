using Clockwork.Graphics;
using Clockwork.Graphics.Draw2D;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Clockwork.Utilities;

public class Quadtree<ItemType> : IEnumerable
{
	private QuadtreeNode<ItemType> rootNode;

	public Quadtree(Vector2 position, float size, int nodeCapacity = 4)
	{
		rootNode = new(position, size, nodeCapacity);
	}

	public void Add(ItemType item, Vector2 position)
	{
		QuadtreePoint<ItemType> quadtreeItem = new(item, position);
		rootNode.Add(quadtreeItem);
	}

	private List<QuadtreeNode<ItemType>> GetLeafNodes()
	{
		List<QuadtreeNode<ItemType>> leafNodes = new();
		rootNode.CollectLeafNodes(leafNodes);
		return leafNodes;
	}

	public Rectangle[] GetLeafBounds()
	{
		List<QuadtreeNode<ItemType>> leafNodes = GetLeafNodes();

		Rectangle[] rectangles = new Rectangle[leafNodes.Count];
		for (int leafIndex = 0; leafIndex < leafNodes.Count; leafIndex++)
		{
			rectangles[leafIndex] = leafNodes[leafIndex].Rectangle;
		}

		return rectangles;
	}

	private List<QuadtreeNode<ItemType>> GetNodesIntersectingRadius(Vector2 position, float radius)
	{
		List<QuadtreeNode<ItemType>> nodes = new();
		rootNode.CollectNodesIntersectingRadius(position, radius, nodes);
		return nodes;
	}

	public List<Rectangle> GetBoundsIntersectingRadius(Vector2 position, float radius)
	{
		List<Rectangle> bounds = new();
		rootNode.CollectBoundsIntersectingRadius(position, radius, bounds);
		return bounds;
	}

	private List<QuadtreePoint<ItemType>> GetPointsInRadius(Vector2 position, float radius)
	{
		List<QuadtreePoint<ItemType>> points = new();
		rootNode.CollectPointsIntersectingRadius(position, radius, radius * radius, points);
		return points;
	}

	public List<ItemType> GetItemsInRadius(Vector2 position, float radius)
	{
		List<ItemType> items = new();
		rootNode.CollectItemsIntersectingRadius(position, radius, radius * radius, items);
		return items;
	}

	private IEnumerable<QuadtreePoint<ItemType>> GetPoints()
	{
		List<QuadtreeNode<ItemType>> leafNodes = GetLeafNodes();
		foreach (QuadtreeNode<ItemType> node in leafNodes)
			foreach (QuadtreePoint<ItemType> point in node.Points) yield return point;
	}

	public IEnumerator<ItemType> GetEnumerator()
	{
		List<QuadtreeNode<ItemType>> leafNodes = GetLeafNodes();
		foreach (QuadtreeNode<ItemType> node in leafNodes)
			foreach (QuadtreePoint<ItemType> point in node.Points) yield return point.Item;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public void DrawBounds(float lineThickness, Color color)
	{
		Rectangle[] rectangles = GetLeafBounds();
		foreach (Rectangle rectangle in rectangles)
		{
			Primitives2D.DrawRectangleLines(rectangle, lineThickness, color);
		}
	}

	public void DrawPoints(float pointRadius, Color color)
	{
		foreach (QuadtreePoint<ItemType> point in GetPoints())
		{
			Primitives2D.DrawCircle(point.Position, pointRadius, color);
		}
	}
}