using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Clockwork.Graphics;
using Clockwork.Shapes;

namespace Clockwork.Utilities;

internal class QuadtreeNode<ValueType>
{
	// Structure
	private readonly List<QuadtreeItem<ValueType>> treeItems = new();
	public IReadOnlyList<QuadtreeItem<ValueType>> Items => treeItems;
	private QuadtreeNode<ValueType> northWest;
	private QuadtreeNode<ValueType> northEast;
	private QuadtreeNode<ValueType> southWest;
	private QuadtreeNode<ValueType> southEast;

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
	internal int nodeCapacity;

	public QuadtreeNode(Vector2 position, float size, int nodeCapacity)
	{
		Rectangle = new(position.X, position.Y, size, size);
		this.nodeCapacity = nodeCapacity;

		westX = position.X;
		eastX = position.X + size;
		northY = position.Y;
		southY = position.Y + size;
	}

	public void Add(QuadtreeItem<ValueType> value)
	{
		if (isLeafNode)
		{
			treeItems.Add(value);
			if (treeItems.Count > nodeCapacity) Split();
		}
		else SortItem(value);
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
		foreach (QuadtreeItem<ValueType> item in treeItems) SortItem(item);
		treeItems.Clear();
		isLeafNode = false;
	}

	private void SortItem(QuadtreeItem<ValueType> item)
	{
		if (item.Position.X < centerX) // west
		{
			if (item.Position.Y < centerY) northWest.Add(item); // north
			else southWest.Add(item); // south
		}
		else // east
		{
			if (item.Position.Y < centerY) northEast.Add(item); // north
			else southEast.Add(item); // south
		}
	}

	public void CollectLeafNodes(List<QuadtreeNode<ValueType>> leafNodes)
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

	public void CollectNodesIntersectingRadius(Vector2 position, float radius, List<QuadtreeNode<ValueType>> nodes)
	{
		if (isLeafNode)
		{
			nodes.Add(this);
			return;
		}

		bool northWestIntersects = Intersection2D.CircleOnRectangle(position, radius, northWest.Rectangle);
		bool northEastIntersects = Intersection2D.CircleOnRectangle(position, radius, northEast.Rectangle);
		bool southWestIntersects = Intersection2D.CircleOnRectangle(position, radius, southWest.Rectangle);
		bool southEastIntersects = Intersection2D.CircleOnRectangle(position, radius, southEast.Rectangle);

		if (northWestIntersects) northWest.CollectNodesIntersectingRadius(position, radius, nodes);
		if (northEastIntersects) northEast.CollectNodesIntersectingRadius(position, radius, nodes);
		if (southWestIntersects) southWest.CollectNodesIntersectingRadius(position, radius, nodes);
		if (southEastIntersects) southEast.CollectNodesIntersectingRadius(position, radius, nodes);
	}
}
