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
	private readonly List<QuadtreePoint<ItemType>> points = new();
	public IReadOnlyList<QuadtreePoint<ItemType>> Points => points;
	private QuadtreeNode<ItemType> northWest;
	private QuadtreeNode<ItemType> northEast;
	private QuadtreeNode<ItemType> southWest;
	private QuadtreeNode<ItemType> southEast;

	// Positioning
	public readonly Rectangle Rectangle;
	private float x => Rectangle.X;
	private float y => Rectangle.Y;
	private float size => Rectangle.Width;
	private float westX;
	private float eastX;
	private float northY;
	private float southY;
	private float centerX;
	private float centerY;

	// Settings
	private bool isLeafNode = true;
	private int nodeCapacity;

	public QuadtreeNode(Vector2 position, float size, int nodeCapacity)
	{
		Rectangle = new(position.X, position.Y, size, size);
		this.nodeCapacity = nodeCapacity;

		westX = position.X;
		eastX = position.X + size;
		northY = position.Y;
		southY = position.Y + size;
	}

	public void Add(QuadtreePoint<ItemType> point)
	{
		if (isLeafNode)
		{
			points.Add(point);
			if (points.Count > nodeCapacity) Split();
		}
		else SortPoint(point);
	}

	private void Split()
	{
		// Initialize positional values
		centerX = x + (eastX - westX) / 2f;
		centerY = y + (southY - northY) / 2f;
		float halfSize = size / 2f;

		// Create sub nodes
		northWest = new(new Vector2(x, y), halfSize, nodeCapacity);
		northEast = new(new Vector2(centerX, y), halfSize, nodeCapacity);
		southWest = new(new Vector2(x, centerY), halfSize, nodeCapacity);
		southEast = new(new Vector2(centerX, centerY), halfSize, nodeCapacity);

		// Sort and clear
		foreach (QuadtreePoint<ItemType> point in points) SortPoint(point);
		points.Clear();
		isLeafNode = false;
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
