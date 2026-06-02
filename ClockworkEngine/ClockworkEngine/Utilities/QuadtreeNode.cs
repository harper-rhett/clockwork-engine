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
	private float westX;
	private float northY;
	private float eastX;
	private float southY;
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
		westX = position.X;
		northY = position.Y;
		eastX = position.X + size;
		southY = position.Y + size;
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
		centerX = westX + halfSize;
		centerY = northY + halfSize;

		// Create sub nodes
		northWest = GetSubNode(new Vector2(westX, northY), halfSize);
		northEast = GetSubNode(new Vector2(centerX, northY), halfSize);
		southWest = GetSubNode(new Vector2(westX, centerY), halfSize);
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

	public void QueryLeafNodes(Vector2 position, float radiusSquared, IList<QuadtreeNode<ItemType>> queriedNodes)
	{
		if (!Intersects(position, radiusSquared)) return;

		if (isLeafNode)
		{
			queriedNodes.Add(this);
			return;
		}

		northWest.QueryLeafNodes(position, radiusSquared, queriedNodes);
		northEast.QueryLeafNodes(position, radiusSquared, queriedNodes);
		southWest.QueryLeafNodes(position, radiusSquared, queriedNodes);
		southEast.QueryLeafNodes(position, radiusSquared, queriedNodes);
	}

	public void QueryBounds(Vector2 position, float radiusSquared, IList<Rectangle> queriedBounds)
	{
		if (!Intersects(position, radiusSquared)) return;

		if (isLeafNode)
		{
			queriedBounds.Add(Rectangle);
			return;
		}

		northWest.QueryBounds(position, radiusSquared, queriedBounds);
		northEast.QueryBounds(position, radiusSquared, queriedBounds);
		southWest.QueryBounds(position, radiusSquared, queriedBounds);
		southEast.QueryBounds(position, radiusSquared, queriedBounds);
	}

	public void QueryPoints(Vector2 position, float radiusSquared, IList<QuadtreePoint<ItemType>> queriedPoints)
	{
		if (!Intersects(position, radiusSquared)) return;

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

		northWest.QueryPoints(position, radiusSquared, queriedPoints);
		northEast.QueryPoints(position, radiusSquared, queriedPoints);
		southWest.QueryPoints(position, radiusSquared, queriedPoints);
		southEast.QueryPoints(position, radiusSquared, queriedPoints);
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

	public void QueryItems(Vector2 position, float radiusSquared, IList<ItemType> queriedItems)
	{
		if (!Intersects(position, radiusSquared)) return;

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

		northWest.QueryItems(position, radiusSquared, queriedItems);
		northEast.QueryItems(position, radiusSquared, queriedItems);
		southWest.QueryItems(position, radiusSquared, queriedItems);
		southEast.QueryItems(position, radiusSquared, queriedItems);
	}

	public void QueryItems(Vector2 position, float radiusSquared, IList<ItemType> queriedItems, IList<float> distancesSquared)
	{
		if (!Intersects(position, radiusSquared)) return;

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

		northWest.QueryItems(position, radiusSquared, queriedItems, distancesSquared);
		northEast.QueryItems(position, radiusSquared, queriedItems, distancesSquared);
		southWest.QueryItems(position, radiusSquared, queriedItems, distancesSquared);
		southEast.QueryItems(position, radiusSquared, queriedItems, distancesSquared);
	}

	public void QueryItems(Vector2 position, float radiusSquared, IList<ItemType> queriedItems, IList<Vector2> differences, IList<float> distancesSquared)
	{
		if (!Intersects(position, radiusSquared)) return;

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

		northWest.QueryItems(position, radiusSquared, queriedItems, differences, distancesSquared);
		northEast.QueryItems(position, radiusSquared, queriedItems, differences, distancesSquared);
		southWest.QueryItems(position, radiusSquared, queriedItems, differences, distancesSquared);
		southEast.QueryItems(position, radiusSquared, queriedItems, differences, distancesSquared);
	}

	public void QueryClosestItem(Vector2 position, ref float minDistanceSquared, ref ItemType closestItem)
	{
		if (!Intersects(position, minDistanceSquared)) return;

		if (isLeafNode)
		{
			for (int pointIndex = 0; pointIndex < pointCount; pointIndex++)
			{
				QuadtreePoint<ItemType> point = points[pointIndex];
				float distanceSquared = Vector2.DistanceSquared(position, point.Position);
				if (distanceSquared < minDistanceSquared)
				{
					closestItem = point.Item;
					minDistanceSquared = distanceSquared;
				}
			}
			return;
		}

		if (position.X < centerX)
		{
			if (position.Y < centerY)
			{
				northWest.QueryClosestItem(position, ref minDistanceSquared, ref closestItem);
				northEast.QueryClosestItem(position, ref minDistanceSquared, ref closestItem);
				southWest.QueryClosestItem(position, ref minDistanceSquared, ref closestItem);
				southEast.QueryClosestItem(position, ref minDistanceSquared, ref closestItem);
			}
			else
			{
				northWest.QueryClosestItem(position, ref minDistanceSquared, ref closestItem);
				northEast.QueryClosestItem(position, ref minDistanceSquared, ref closestItem);
				southWest.QueryClosestItem(position, ref minDistanceSquared, ref closestItem);
				southEast.QueryClosestItem(position, ref minDistanceSquared, ref closestItem);
			}
		}
		else
		{
			if (position.Y < centerY)
			{
				northWest.QueryClosestItem(position, ref minDistanceSquared, ref closestItem);
				northEast.QueryClosestItem(position, ref minDistanceSquared, ref closestItem);
				southWest.QueryClosestItem(position, ref minDistanceSquared, ref closestItem);
				southEast.QueryClosestItem(position, ref minDistanceSquared, ref closestItem);
			}
			else
			{
				northWest.QueryClosestItem(position, ref minDistanceSquared, ref closestItem);
				northEast.QueryClosestItem(position, ref minDistanceSquared, ref closestItem);
				southWest.QueryClosestItem(position, ref minDistanceSquared, ref closestItem);
				southEast.QueryClosestItem(position, ref minDistanceSquared, ref closestItem);
			}
		}
	}

	public bool AnyItemInRadius(Vector2 position, float radiusSquared)
	{
		if (!Intersects(position, radiusSquared)) return false;
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
			northWest.AnyItemInRadius(position, radiusSquared)
			|| northEast.AnyItemInRadius(position, radiusSquared)
			|| southWest.AnyItemInRadius(position, radiusSquared)
			|| southEast.AnyItemInRadius(position, radiusSquared);
	}

	private bool Intersects(Vector2 position, float radiusSquared)
	{
		float xEdge = position.X < westX ? westX : (position.X > eastX ? eastX : position.X);
		float yEdge = position.Y < northY ? northY : (position.Y > southY ? southY : position.Y);
		float xDistance = position.X - xEdge;
		float yDistance = position.Y - yEdge;
		return xDistance * xDistance + yDistance * yDistance <= radiusSquared;
	}
}
