using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Clockwork.Graphics;
using Clockwork.Shapes;

namespace Clockwork.Utilities;

internal class QuadtreeNode<ItemType>
{
	// Structure
	private QuadtreePoint<ItemType>[] points;
	public IReadOnlyList<QuadtreePoint<ItemType>> Points => points;
	private QuadtreeNode<ItemType> northWest;
	private QuadtreeNode<ItemType> northEast;
	private QuadtreeNode<ItemType> southWest;
	private QuadtreeNode<ItemType> southEast;
	private Stack<QuadtreeNode<ItemType>> nodePool;
	private int pointCount;

	// Positioning
	public Rectangle Rectangle { get; private set; }
	private float x => Rectangle.X;
	private float y => Rectangle.Y;
	private float size => Rectangle.Width;
	private float centerX;
	private float centerY;

	// Settings
	private bool isLeafNode = true;
	private int nodeCapacity;

	public QuadtreeNode(Vector2 position, float size, int nodeCapacity, Stack<QuadtreeNode<ItemType>> nodePool)
	{
		Rectangle = new(position.X, position.Y, size, size);
		this.nodeCapacity = nodeCapacity;
		points = new QuadtreePoint<ItemType>[nodeCapacity + 1];
		this.nodePool = nodePool;
	}

	public void Reinitialize(Vector2 position, float size)
	{
		Rectangle = new(position.X, position.Y, size, size);
	}

	public void Add(QuadtreePoint<ItemType> point)
	{
		if (isLeafNode)
		{
			points[pointCount] = point;
			pointCount++;
			if (pointCount > nodeCapacity) Split();
		}
		else SortPoint(point);
	}

	public void Reclaim(bool isRootNode)
	{
		isLeafNode = true;
		pointCount = 0;
		if (!isRootNode) nodePool.Push(this);

		northWest.Reclaim(false);
		northEast.Reclaim(false);
		southWest.Reclaim(false);
		southEast.Reclaim(false);

		northWest = null;
		northEast = null;
		southWest = null;
		southEast = null;
	}

	private void Split()
	{
		// Initialize positional values
		float halfSize = size / 2f;
		centerX = x + halfSize;
		centerY = y + halfSize;

		// Create sub nodes
		northWest = GetSubNode(new Vector2(x, y), halfSize);
		northEast = GetSubNode(new Vector2(centerX, y), halfSize);
		southWest = GetSubNode(new Vector2(x, centerY), halfSize);
		southEast = GetSubNode(new Vector2(centerX, centerY), halfSize);

		// Sort and clear
		foreach (QuadtreePoint<ItemType> point in points) SortPoint(point);
		isLeafNode = false;
	}

	private QuadtreeNode<ItemType> GetSubNode(Vector2 position, float size)
	{
		QuadtreeNode<ItemType> node;

		if (nodePool.Count > 0)
		{
			node = nodePool.Pop();
			node.Reinitialize(position, size);
		}
		else node = new(position, size, nodeCapacity, nodePool);

		return node;
	}

	private void SortPoint(QuadtreePoint<ItemType> point)
	{
		if (point.Position.X < centerX) // west
		{
			if (point.Position.Y < centerY) northWest.Add(point); // north
			else southWest.Add(point); // south
		}
		else // east
		{
			if (point.Position.Y < centerY) northEast.Add(point); // north
			else southEast.Add(point); // south
		}
	}

	public void CollectLeafNodes(List<QuadtreeNode<ItemType>> leafNodes)
	{
		if (isLeafNode) leafNodes.Add(this);
		else
		{
			northWest.CollectLeafNodes(leafNodes);
			northEast.CollectLeafNodes(leafNodes);
			southWest.CollectLeafNodes(leafNodes);
			southEast.CollectLeafNodes(leafNodes);
		}
	}

	private void CollectFromIntersectingRadius(Vector2 position, float radius, Action<QuadtreeNode<ItemType>> action)
	{
		if (isLeafNode)
		{
			action.Invoke(this);
			return;
		}

		if (northWest.IntersectWithRadius(position, radius)) northWest.CollectFromIntersectingRadius(position, radius, action);
		if (northEast.IntersectWithRadius(position, radius)) northEast.CollectFromIntersectingRadius(position, radius, action);
		if (southWest.IntersectWithRadius(position, radius)) southWest.CollectFromIntersectingRadius(position, radius, action);
		if (southEast.IntersectWithRadius(position, radius)) southEast.CollectFromIntersectingRadius(position, radius, action);
	}

	public void CollectNodesIntersectingRadius(Vector2 position, float radius, List<QuadtreeNode<ItemType>> nodes)
	{
		CollectFromIntersectingRadius(position, radius, nodes.Add);
	}

	public void CollectBoundsIntersectingRadius(Vector2 position, float radius, List<Rectangle> bounds)
	{
		CollectFromIntersectingRadius(position, radius, (node) => bounds.Add(node.Rectangle));
	}

	public void CollectPointsIntersectingRadius(Vector2 position, float radius, float radiusSquared, List<QuadtreePoint<ItemType>> points)
	{
		CollectFromIntersectingRadius(position, radius, (node) =>
		{
			foreach (QuadtreePoint<ItemType> point in node.points)
			{
				float distanceSquared = Vector2.DistanceSquared(position, point.Position);
				if (distanceSquared < radiusSquared) points.Add(point);
			}
		});
	}

	public void CollectItemsIntersectingRadius(Vector2 position, float radius, float radiusSquared, List<ItemType> items)
	{
		CollectFromIntersectingRadius(position, radius, (node) =>
		{
			foreach (QuadtreePoint<ItemType> point in node.points)
			{
				float distanceSquared = Vector2.DistanceSquared(position, point.Position);
				if (distanceSquared < radiusSquared) items.Add(point.Item);
			}
		});
	}

	private bool IntersectWithRadius(Vector2 position, float radius)
	{
		return Intersection2D.CircleOnRectangle(position, radius, Rectangle);
	}
}
