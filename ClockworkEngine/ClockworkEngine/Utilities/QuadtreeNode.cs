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
	private float minCellSize;

	public QuadtreeNode(Vector2 position, float size, float minCellSize, int nodeCapacity, Stack<QuadtreeNode<ItemType>> nodePool)
	{
		Initialize(position, size);
		this.minCellSize = minCellSize;
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
			if (pointCount == points.Length) Array.Resize(ref points, points.Length * 2);
			points[pointCount] = point;
			pointCount++;
			if (pointCount > nodeCapacity && size > minCellSize) Split();
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
		else node = new(position, size, minCellSize, nodeCapacity, nodePool);

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

	public void QueryLeafNodes(IList<QuadtreeNode<ItemType>> queriedNodes)
	{
		if (isLeafNode) queriedNodes.Add(this);
		else
		{
			northWest.QueryLeafNodes(queriedNodes);
			northEast.QueryLeafNodes(queriedNodes);
			southWest.QueryLeafNodes(queriedNodes);
			southEast.QueryLeafNodes(queriedNodes);
		}
	}

	public void QueryBounds(IList<Rectangle> queriedBounds)
	{
		if (isLeafNode) queriedBounds.Add(Rectangle);
		else
		{
			northWest.QueryBounds(queriedBounds);
			northEast.QueryBounds(queriedBounds);
			southWest.QueryBounds(queriedBounds);
			southEast.QueryBounds(queriedBounds);
		}
	}

	public void QueryLeafNodes(Vector2 position, float radius, IList<QuadtreeNode<ItemType>> queriedNodes)
	{
		if (!Intersects(position, radius)) return;

		if (isLeafNode)
		{
			queriedNodes.Add(this);
			return;
		}

		northWest.QueryLeafNodes(position, radius, queriedNodes);
		northEast.QueryLeafNodes(position, radius, queriedNodes);
		southWest.QueryLeafNodes(position, radius, queriedNodes);
		southEast.QueryLeafNodes(position, radius, queriedNodes);
	}

	public void QueryBounds(Vector2 position, float radius, IList<Rectangle> queriedBounds)
	{
		if (!Intersects(position, radius)) return;

		if (isLeafNode)
		{
			queriedBounds.Add(Rectangle);
			return;
		}

		northWest.QueryBounds(position, radius, queriedBounds);
		northEast.QueryBounds(position, radius, queriedBounds);
		southWest.QueryBounds(position, radius, queriedBounds);
		southEast.QueryBounds(position, radius, queriedBounds);
	}

	public void QueryPoints(Vector2 position, float radius, float radiusSquared, IList<QuadtreePoint<ItemType>> queriedPoints)
	{
		if (!Intersects(position, radius)) return;

		if (isLeafNode)
		{
			for (int pointIndex = 0; pointIndex < pointCount; pointIndex++)
			{
				QuadtreePoint<ItemType> point = points[pointIndex];
				float distanceSquared = Vector2.DistanceSquared(position, point.Position);
				if (distanceSquared < radiusSquared) queriedPoints.Add(point);
			}
			return;
		}

		northWest.QueryPoints(position, radius, radiusSquared, queriedPoints);
		northEast.QueryPoints(position, radius, radiusSquared, queriedPoints);
		southWest.QueryPoints(position, radius, radiusSquared, queriedPoints);
		southEast.QueryPoints(position, radius, radiusSquared, queriedPoints);
	}

	public void QueryPoints(IList<QuadtreePoint<ItemType>> queriedPoints)
	{
		if (isLeafNode)
		{
			for (int pointIndex = 0; pointIndex < pointCount; pointIndex++) queriedPoints.Add(points[pointIndex]);
			return;
		}

		northWest.QueryPoints(queriedPoints);
		northEast.QueryPoints(queriedPoints);
		southWest.QueryPoints(queriedPoints);
		southEast.QueryPoints(queriedPoints);
	}

	public void QueryItems(Vector2 position, float radius, float radiusSquared, IList<ItemType> queriedItems)
	{
		if (!Intersects(position, radius)) return;

		if (isLeafNode)
		{
			for (int pointIndex = 0; pointIndex < pointCount; pointIndex++)
			{
				QuadtreePoint<ItemType> point = points[pointIndex];
				float distanceSquared = Vector2.DistanceSquared(position, point.Position);
				if (distanceSquared < radiusSquared) queriedItems.Add(point.Item);
			}
			return;
		}

		northWest.QueryItems(position, radius, radiusSquared, queriedItems);
		northEast.QueryItems(position, radius, radiusSquared, queriedItems);
		southWest.QueryItems(position, radius, radiusSquared, queriedItems);
		southEast.QueryItems(position, radius, radiusSquared, queriedItems);
	}

	public void QueryItems(Vector2 position, float radius, float radiusSquared, IList<ItemType> queriedItems, IList<float> distancesSquared)
	{
		if (!Intersects(position, radius)) return;

		if (isLeafNode)
		{
			for (int pointIndex = 0; pointIndex < pointCount; pointIndex++)
			{
				QuadtreePoint<ItemType> point = points[pointIndex];
				float distanceSquared = Vector2.DistanceSquared(position, point.Position);
				if (distanceSquared < radiusSquared)
				{
					queriedItems.Add(point.Item);
					distancesSquared.Add(distanceSquared);
				}
			}
			return;
		}

		northWest.QueryItems(position, radius, radiusSquared, queriedItems, distancesSquared);
		northEast.QueryItems(position, radius, radiusSquared, queriedItems, distancesSquared);
		southWest.QueryItems(position, radius, radiusSquared, queriedItems, distancesSquared);
		southEast.QueryItems(position, radius, radiusSquared, queriedItems, distancesSquared);
	}

	public void QueryItems(Vector2 position, float radius, float radiusSquared, IList<ItemType> queriedItems, IList<Vector2> differences, IList<float> distancesSquared)
	{
		if (!Intersects(position, radius)) return;

		if (isLeafNode)
		{
			for (int pointIndex = 0; pointIndex < pointCount; pointIndex++)
			{
				QuadtreePoint<ItemType> point = points[pointIndex];
				Vector2 difference = point.Position - position;
				float distanceSquared = difference.LengthSquared();
				if (distanceSquared < radiusSquared)
				{
					queriedItems.Add(point.Item);
					differences.Add(difference);
					distancesSquared.Add(distanceSquared);
				}
			}
			return;
		}

		northWest.QueryItems(position, radius, radiusSquared, queriedItems, differences, distancesSquared);
		northEast.QueryItems(position, radius, radiusSquared, queriedItems, differences, distancesSquared);
		southWest.QueryItems(position, radius, radiusSquared, queriedItems, differences, distancesSquared);
		southEast.QueryItems(position, radius, radiusSquared, queriedItems, differences, distancesSquared);
	}

	public void QueryClosestItem(Vector2 position, ref float minDistance, ref ItemType closestItem)
	{
		if (!Intersects(position, minDistance)) return;

		if (isLeafNode)
		{
			float minDistanceSquared = minDistance * minDistance;
			for (int pointIndex = 0; pointIndex < pointCount; pointIndex++)
			{
				QuadtreePoint<ItemType> point = points[pointIndex];
				float distanceSquared = Vector2.DistanceSquared(position, point.Position);
				if (distanceSquared < minDistanceSquared)
				{
					minDistance = float.Sqrt(distanceSquared);
					closestItem = point.Item;
					minDistanceSquared = distanceSquared;
				}
			}
		}
		else
		{
			northWest.QueryClosestItem(position, ref minDistance, ref closestItem);
			northEast.QueryClosestItem(position, ref minDistance, ref closestItem);
			southWest.QueryClosestItem(position, ref minDistance, ref closestItem);
			southEast.QueryClosestItem(position, ref minDistance, ref closestItem);
		}
	}

	public bool AnyItemInRadius(Vector2 position, float radius, float radiusSquared)
	{
		if (!Intersects(position, radius)) return false;
		if (isLeafNode)
		{
			for (int pointIndex = 0; pointIndex < pointCount; pointIndex++)
			{
				QuadtreePoint<ItemType> point = points[pointIndex];
				float distanceSquared = Vector2.DistanceSquared(position, point.Position);
				if (distanceSquared < radiusSquared) return true;
			}
			return false;
		}
		
		return
			northWest.AnyItemInRadius(position, radius, radiusSquared)
			|| northEast.AnyItemInRadius(position, radius, radiusSquared)
			|| southWest.AnyItemInRadius(position, radius, radiusSquared)
			|| southEast.AnyItemInRadius(position, radius, radiusSquared);
	}

	private bool Intersects(Vector2 position, float radius)
	{
		return Intersection2D.CircleOnRectangle(position, radius, Rectangle);
	}
}
