# Extensions

> `using Clockwork.Utilities;`

Clockwork includes several extension classes that add useful methods to common numeric and vector types. These are small quality-of-life additions that come up all the time in game code.

## Vector Extensions

```csharp
Vector2 projected = velocity.Projected(wallNormal);
Vector2 snapped = position.Rounded();
Vector2 grid = position.Floored();
Vector2 normalized = direction.Normalized();
```

Component manipulation:

```csharp
Vector2 grounded = velocity.SetY(0);
Vector2 flippedX = direction.NegateX();
Vector2 flippedY = direction.NegateY();
```

There's also a static method for averaging two vectors:

```csharp
Vector2 midpoint = VectorExtensions.Averaged(positionA, positionB);
```

## Float Extensions

```csharp
int rounded = someFloat.Rounded();
int floored = someFloat.Floored();
int ceiled = someFloat.Ceiled();
float wrapped = angle.Wrapped(360f);
```

The `Wrapped` overload with an `out` parameter tells you how many times the value wrapped:

```csharp
float wrapped = value.Wrapped(max, out float wraps);
```

## Integer Extensions

```csharp
int wrapped = index.Wrapped(arrayLength);
int wrapped = index.Wrapped(max, out int wraps);
```

## Quaternion Extensions

For 3D rotation work, quaternion extensions provide directional vectors and rotation helpers:

```csharp
Vector3 forward = rotation.GetForward();
Vector3 right = rotation.GetRight();
Vector3 up = rotation.GetUp();
```

And rotation methods:

```csharp
Quaternion rotated = rotation.RotateWorldAxis(Vector3.UnitY, radians);
Quaternion rotated = rotation.RotateLocalAxis(localAxis, radians);
Quaternion fresh = QuaternionExtensions.CreateRotation(Vector3.UnitY, radians);
```

## Collection Extensions

`GetIndices` returns a list of every valid index in a collection, which is handy for iterating or shuffling indices rather than items:

```csharp
List<int> indices = myList.GetIndices(); // [0, 1, 2, ...]
```

## Scope

`Scope` is a small helper for running paired enter/exit actions using a `using` block. The exit action runs automatically when the scope is disposed, even if you return or throw early:

```csharp
using (new Scope(() => RenderTexture.BeginDrawing(target), RenderTexture.EndDrawing))
{
	// draw to the render texture here
}
// EndDrawing has now been called
```

This keeps "begin/end" style APIs balanced without having to remember the closing call.

