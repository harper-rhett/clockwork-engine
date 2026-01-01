# Intersections

If you want to check for collisions between two shapes, intersections might be a good choice for your calculations. The `Intersection` class has nifty methods for doing just that:

```csharp
bool isGrounded = Intersection.RectangleOnRectangle(playerRectangle, groundRectangle);
```

Additionally, Clockwork provides interfaces such as `IIntersectsWithRectangle` which can be implemented in classes to create a collision system between objects. Clockwork already has a few cases of this with [shapes](shapes.md).

```csharp
LineShape laser = new(3, Colors.Red); // implements IIntersectsWithRectangle
RectangleShape enemy = new(10, 10, Colors.Orange); // implements IIntersectsWithLine
bool doesHit = laser.IntersectsWithRectangle(enemy);
```