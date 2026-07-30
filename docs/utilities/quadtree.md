# Quadtree

> `using Clockwork.Utilities;`

> **Example:** See `QuadtreeExample` in the [examples repository](https://github.com/harper-rhett/clockwork-examples), which benchmarks a quadtree against a brute-force search and visualizes its cells.

A `Quadtree` is a spatial partitioning structure. When you have lots of objects and need to ask "what's near this point?", checking every object every frame gets expensive fast. A quadtree subdivides space into cells so those queries only consider nearby objects.

It's generic over whatever type you want to store:

```csharp
Quadtree<Enemy> tree = new(position, size, minCellSize);
```

- `position` — the top-left corner of the region the tree covers
- `size` — the width and height of that region
- `minCellSize` — the smallest a cell will subdivide to
- `nodeCapacity` (optional) — how many items a cell holds before it splits (default `4`)

## Rebuilding Each Frame

Quadtrees are cheap to build, so the common pattern is to clear and repopulate the tree every frame from your moving objects, rather than trying to keep it updated incrementally:

```csharp
public override void OnUpdate()
{
	tree.Clear();
	foreach (Enemy enemy in enemies) tree.Add(enemy, enemy.Position);
}
```

## Querying

All radius-based queries take a **squared** radius. This avoids a square root per check, which adds up when you're querying constantly. Just square your radius before passing it in:

```csharp
float radius = 50f;
float radiusSquared = radius * radius;
```

To collect every item within a radius, pass a list for the results to be written into. Reusing a buffer list avoids per-frame allocations:

```csharp
List<Enemy> nearby = new();
tree.QueryItems(playerPosition, radiusSquared, nearby);
```

There are richer overloads that also hand back the distance (squared) and offset to each item, which saves you recomputing them:

```csharp
tree.QueryItems(playerPosition, radiusSquared, nearby, distancesSquared);
tree.QueryItems(playerPosition, radiusSquared, nearby, differences, distancesSquared);
```

For the single nearest item, or just a yes/no proximity check:

```csharp
Enemy closest = tree.QueryClosestItem(playerPosition);
bool anyClose = tree.AnyItemInRadius(playerPosition, radiusSquared);
```

## A Spatial Index

A clean way to use a quadtree is to wrap it in an entity that rebuilds itself early each frame (note the negative `UpdateLayer`, so it runs before everything that queries it), then exposes query methods:

```csharp
public class SpatialIndex : Entity
{
	private Quadtree<Enemy> tree;
	private List<Enemy> buffer = new();
	private ICollection<Enemy> enemies;

	public SpatialIndex(ICollection<Enemy> enemies, Vector2 position, float size)
	{
		UpdateLayer = -10; // rebuild before other entities update
		this.enemies = enemies;
		tree = new(position, size, minCellSize: 16);
	}

	public override void OnUpdate()
	{
		tree.Clear();
		foreach (Enemy enemy in enemies) tree.Add(enemy, enemy.Position);
	}

	public List<Enemy> Query(Vector2 position, float radiusSquared)
	{
		buffer.Clear();
		tree.QueryItems(position, radiusSquared, buffer);
		return buffer;
	}
}
```

## Debugging

To see the structure while developing, the tree can draw its cell boundaries and the points it holds:

```csharp
tree.DrawBounds(1f, Colors.Green);
tree.DrawPoints(2f, Colors.Red);
```

You can also retrieve the cell bounds yourself with the `QueryBounds` overloads if you'd rather visualize them differently.
