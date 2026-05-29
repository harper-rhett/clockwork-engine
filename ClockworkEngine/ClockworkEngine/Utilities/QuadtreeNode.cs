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
	public ReadOnlySpan<QuadtreePoint<ItemType>> Points => points.AsSpan(0, pointCount);
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
	private float size;
	private float halfSize;
	private float centerX;
	private float centerY;

	// Settings
	private bool isLeafNode = true;
	private int nodeCapacity;

	public QuadtreeNode(Vector2 position, float size, int nodeCapacity, Stack<QuadtreeNode<ItemType>> nodePool)
	{
		Initialize(position, size);
		this.nodeCapacity = nodeCapacity;
		points = new QuadtreePoint<ItemType>[nodeCapacity + 1];
		this.nodePool = nodePool;
	}

	public void Initialize(Vector2 position, float size)
	{
		Rectangle = new(position.X, position.Y, size, size);
		this.size = size;
		halfSize = size / 2f;
		centerX = x + halfSize;
		centerY = y + halfSize;
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
		// Reclaim children
		if (!isLeafNode)
		{
			northWest.Reclaim(false);
			northEast.Reclaim(false);
			southWest.Reclaim(false);
			southEast.Reclaim(false);

			northWest = null;
			northEast = null;
			southWest = null;
			southEast = null;

			isLeafNode = true;
		}

		// Reset and reclaim
		if (!isRootNode) nodePool.Push(this);
		pointCount = 0;
	}

	private void Split()
	{
		// Create sub nodes
		northWest = GetSubNode(new Vector2(x, y), halfSize);
		northEast = GetSubNode(new Vector2(centerX, y), halfSize);
		southWest = GetSubNode(new Vector2(x, centerY), halfSize);
		southEast = GetSubNode(new Vector2(centerX, centerY), halfSize);

		// Sort and clear
		for (int pointIndex = 0; pointIndex < pointCount; pointIndex++)
		{
			QuadtreePoint<ItemType> point = points[pointIndex];
			SortPoint(point);
		}
		isLeafNode = false;
	}

	private QuadtreeNode<ItemType> GetSubNode(Vector2 position, float size)
	{
		QuadtreeNode<ItemType> node;

		if (nodePool.Count > 0)
		{
			node = nodePool.Pop();
			node.Initialize(position, size);
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

	public void CollectNodesWithin(Vector2 position, float radius, List<QuadtreeNode<ItemType>> collectedNodes)
	{
		if (!IntersectWithRadius(position, radius)) return;

		if (isLeafNode)
		{
			collectedNodes.Add(this);
			return;
		}

		northWest.CollectNodesWithin(position, radius, collectedNodes);
		northEast.CollectNodesWithin(position, radius, collectedNodes);
		southWest.CollectNodesWithin(position, radius, collectedNodes);
		southEast.CollectNodesWithin(position, radius, collectedNodes);
	}

	public void CollectBoundsWithin(Vector2 position, float radius, List<Rectangle> collectedBounds)
	{
		if (!IntersectWithRadius(position, radius)) return;

		if (isLeafNode)
		{
			collectedBounds.Add(Rectangle);
			return;
		}

		northWest.CollectBoundsWithin(position, radius, collectedBounds);
		northEast.CollectBoundsWithin(position, radius, collectedBounds);
		southWest.CollectBoundsWithin(position, radius, collectedBounds);
		southEast.CollectBoundsWithin(position, radius, collectedBounds);
	}

	public void CollectPointsWithin(Vector2 position, float radius, float radiusSquared, List<QuadtreePoint<ItemType>> collectedPoints)
	{
		if (!IntersectWithRadius(position, radius)) return;

		if (isLeafNode)
		{
			for (int pointIndex = 0; pointIndex < pointCount; pointIndex++)
			{
				QuadtreePoint<ItemType> point = points[pointIndex];
				float distanceSquared = Vector2.DistanceSquared(position, point.Position);
				if (distanceSquared < radiusSquared) collectedPoints.Add(point);
			}
			return;
		}

		northWest.CollectPointsWithin(position, radius, radiusSquared, collectedPoints);
		northEast.CollectPointsWithin(position, radius, radiusSquared, collectedPoints);
		southWest.CollectPointsWithin(position, radius, radiusSquared, collectedPoints);
		southEast.CollectPointsWithin(position, radius, radiusSquared, collectedPoints);
	}

	public void CollectItemsWithin(Vector2 position, float radius, float radiusSquared, List<ItemType> collectedItems)
	{
		if (!IntersectWithRadius(position, radius)) return;

		if (isLeafNode)
		{
			for (int pointIndex = 0; pointIndex < pointCount; pointIndex++)
			{
				QuadtreePoint<ItemType> point = points[pointIndex];
				float distanceSquared = Vector2.DistanceSquared(position, point.Position);
				if (distanceSquared < radiusSquared) collectedItems.Add(point.Item);
			}
			return;
		}

		northWest.CollectItemsWithin(position, radius, radiusSquared, collectedItems);
		northEast.CollectItemsWithin(position, radius, radiusSquared, collectedItems);
		southWest.CollectItemsWithin(position, radius, radiusSquared, collectedItems);
		southEast.CollectItemsWithin(position, radius, radiusSquared, collectedItems);
	}

	private bool IntersectWithRadius(Vector2 position, float radius)
	{
		return Intersection2D.CircleOnRectangle(position, radius, Rectangle);
	}
}
