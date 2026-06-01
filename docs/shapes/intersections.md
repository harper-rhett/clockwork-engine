# Intersections

> **Example:** See `CollisionExample` in the [examples repository](https://github.com/harper-rhett/clockwork-examples) for cross-shape intersection tests in action.

If you want to check for collisions between two shapes, intersections might be a good choice for your calculations.

## 2D Intersections

The `Intersection2D` class has nifty static methods for doing just that:

```csharp
bool isGrounded = Intersection2D.RectangleOnRectangle(playerRectangle, groundRectangle);
bool inRange = Intersection2D.CircleOnCircle(positionA, radiusA, positionB, radiusB);
bool clicked = Intersection2D.PointInRectangle(mousePosition, buttonRectangle);
```

The full list of 2D intersection tests includes:
- `PointInCircle` / `PointInCircleSquared`
- `CircleOnCircle` / `CircleOnCircleSquared`
- `CircleInCircle` / `CircleInCircleSquared`
- `PointInRectangle`
- `RectangleOnRectangle`
- `CircleOnRectangle`
- `PointOnLine`
- `CircleOnLine`
- `LineOnLine`
- `LineOnRectangle`

The "Squared" variants skip the square root calculation and are faster when you only need a boolean result.

## 3D Intersections

`Intersection3D` provides ray-based collision tests:

```csharp
RayCollision collision = Intersection3D.RayInSphereCollision(ray, spherePosition, sphereRadius);
if (collision.DidHit)
{
	Vector3 hitPoint = collision.Point;
	float distance = collision.Distance;
}
```

There's also a simpler boolean check:

```csharp
bool hit = Intersection3D.RayInSphere(ray, spherePosition, sphereRadius);
```

## Interfaces

Clockwork provides interfaces such as `IIntersectsWithRectangle`, `IIntersectsWithCircle`, `IIntersectsWithLine`, `IIntersectsWithPoint`, and `IIntersectsWithRay` which can be implemented in classes to create a collision system between objects. Clockwork already has a few cases of this with [shapes](shapes.md):

```csharp
LineShape laser = new(3, Colors.Red);
RectangleShape enemy = new(10, 10, Colors.Orange);
bool doesHit = enemy.IntersectsWithLine(laser.StartPosition, laser.EndPosition);
```