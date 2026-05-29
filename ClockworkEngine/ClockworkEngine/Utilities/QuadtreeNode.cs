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
		// Calculate positional variables
		halfSize = size / 2f;
		centerX = x + halfSize;
		centerY = y + halfSize;

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

	public void CollectLeafNodes(ICollection<QuadtreeNode<ItemType>> collectedNodes)
	{
		if (isLeafNode) collectedNodes.Add(this);
		else
		{
			northWest.CollectLeafNodes(collectedNodes);
			northEast.CollectLeafNodes(collectedNodes);
			southWest.CollectLeafNodes(collectedNodes);
			southEast.CollectLeafNodes(collectedNodes);
		}
	}

	public void CollectLeafBounds(ICollection<Rectangle> collectedBounds)
	{
		if (isLeafNode) collectedBounds.Add(Rectangle);
		else
		{
			northWest.CollectLeafBounds(collectedBounds);
			northEast.CollectLeafBounds(collectedBounds);
			southWest.CollectLeafBounds(collectedBounds);
			southEast.CollectLeafBounds(collectedBounds);
		}
	}

	public void CollectNodesIntersecting(Vector2 position, float radius, ICollection<QuadtreeNode<ItemType>> collectedNodes)
	{
		if (!IntersectWithRadius(position, radius)) return;

		if (isLeafNode)
		{
			collectedNodes.Add(this);
			return;
		}

		northWest.CollectNodesIntersecting(position, radius, collectedNodes);
		northEast.CollectNodesIntersecting(position, radius, collectedNodes);
		southWest.CollectNodesIntersecting(position, radius, collectedNodes);
		southEast.CollectNodesIntersecting(position, radius, collectedNodes);
	}

	public void CollectBoundsIntersecting(Vector2 position, float radius, ICollection<Rectangle> collectedBounds)
	{
		if (!IntersectWithRadius(position, radius)) return;

		if (isLeafNode)
		{
			collectedBounds.Add(Rectangle);
			return;
		}

		northWest.CollectBoundsIntersecting(position, radius, collectedBounds);
		northEast.CollectBoundsIntersecting(position, radius, collectedBounds);
		southWest.CollectBoundsIntersecting(position, radius, collectedBounds);
		southEast.CollectBoundsIntersecting(position, radius, collectedBounds);
	}

	public void CollectPointsWithin(Vector2 position, float radius, float radiusSquared, ICollection<QuadtreePoint<ItemType>> collectedPoints)
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

	public void CollectPoints(ICollection<QuadtreePoint<ItemType>> collectedPoints)
	{
		for (int pointIndex = 0; pointIndex < pointCount; pointIndex++) collectedPoints.Add(points[pointIndex]);
		northWest.CollectPoints(collectedPoints);
		northEast.CollectPoints(collectedPoints);
		southWest.CollectPoints(collectedPoints);
		southEast.CollectPoints(collectedPoints);
	}

	public void CollectItemsWithin(Vector2 position, float radius, float radiusSquared, ICollection<ItemType> collectedItems)
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
