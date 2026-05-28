using Clockwork.Graphics;
using Clockwork.Graphics.Draw2D;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Clockwork.Utilities;

public class Quadtree<ValueType> : IEnumerable
{
	private QuadtreeNode<ValueType> rootNode;
	private int nodeCapacity;
	public int NodeCapacity
	{
		get => nodeCapacity;
		set
		{
			nodeCapacity = value;
			List<QuadtreeNode<ValueType>> leafNodes = GetLeafNodes();
			foreach (QuadtreeNode<ValueType> leafNode in leafNodes) leafNode.nodeCapacity = nodeCapacity;
		}
	}

	public Quadtree(Vector2 position, float size)
	{
		rootNode = new(position, size, nodeCapacity);
		NodeCapacity = 4;
	}

	public void Add(ValueType value, Vector2 position)
	{
		QuadtreeItem<ValueType> quadtreeItem = new(value, position);
		rootNode.Add(quadtreeItem);
	}

	private List<QuadtreeNode<ValueType>> GetLeafNodes()
	{
		List<QuadtreeNode<ValueType>> leafNodes = new();
		rootNode.CollectLeafNodes(leafNodes);
		return leafNodes;
	}

	public Rectangle[] GetLeafBounds()
	{
		List<QuadtreeNode<ValueType>> leafNodes = GetLeafNodes();

		Rectangle[] rectangles = new Rectangle[leafNodes.Count];
		for (int leafIndex = 0; leafIndex < leafNodes.Count; leafIndex++)
		{
			rectangles[leafIndex] = leafNodes[leafIndex].Rectangle;
		}

		return rectangles;
	}

	private List<QuadtreeNode<ValueType>> GetNodesIntersectingRadius(Vector2 position, float radius)
	{
		List<QuadtreeNode<ValueType>> nodes = new();
		rootNode.CollectNodesIntersectingRadius(position, radius, nodes);
		return nodes;
	}

	private List<QuadtreeItem<ValueType>> GetItemsInRadius(Vector2 position, float radius)
	{
		List<QuadtreeNode<ValueType>> nodes = GetNodesIntersectingRadius(position, radius);
		List<QuadtreeItem<ValueType>> items = new();
		float radiusSquared = radius * radius;
		foreach (QuadtreeNode<ValueType> node in nodes)
		{
			foreach (QuadtreeItem<ValueType> item in node.Items)
			{
				float distanceSquared = Vector2.DistanceSquared(position, item.Position);
				if (distanceSquared < radiusSquared) items.Add(item);
			}
		}

		return items;
	}

	public List<ValueType> GetValuesInRadius(Vector2 position, float radius)
	{
		List<QuadtreeItem<ValueType>> itemsInRadius = GetItemsInRadius(position, radius);
		return itemsInRadius.Select(item => item.Value).ToList();
	}

	private IEnumerable<QuadtreeItem<ValueType>> GetItems()
	{
		List<QuadtreeNode<ValueType>> leafNodes = GetLeafNodes();
		foreach (QuadtreeNode<ValueType> node in leafNodes)
			foreach (QuadtreeItem<ValueType> item in node.Items) yield return item;
	}

	public IEnumerator<ValueType> GetEnumerator()
	{
		List<QuadtreeNode<ValueType>> leafNodes = GetLeafNodes();
		foreach (QuadtreeNode<ValueType> node in leafNodes)
			foreach (QuadtreeItem<ValueType> item in node.Items) yield return item.Value;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public void DrawBounds(float lineThickness)
	{
		Rectangle[] rectangles = GetLeafBounds();
		foreach (Rectangle rectangle in rectangles)
		{
			Primitives2D.DrawRectangleLines(rectangle, lineThickness, Colors.Green);
		}
	}

	public void DrawPoints(float pointRadius)
	{
		foreach (QuadtreeItem<ValueType> item in GetItems())
		{
			Primitives2D.DrawCircle(item.Position, pointRadius, Colors.White);
		}
	}
}