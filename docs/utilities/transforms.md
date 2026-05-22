# Transforms

> `using Clockwork.Utilities;`

## Transform2D

The `Transform2D` class contains properties for:

- `WorldPosition` / `LocalPosition`
- `WorldRotation` / `LocalRotation`
- `Parent`
- `Matrix` / `MatrixInverse`
- `Up` / `Down` / `Left` / `Right` — directional vectors based on current rotation

`Transform2D` should be added to entities if they require position/rotation child-parent relationships. It should be used in place of `Vector2 Position` or `float Rotation`, unless it is not needed. Transformation calculations are not super cheap, and this class has not been super optimized.

```csharp
Transform2D transform = new();
transform.LocalPosition = new Vector2(100, 50);
transform.LocalRotation = 0.5f;
```

You can also construct a transform with initial values:

```csharp
Transform2D transform = new(new Vector2(100, 50), 0.5f);
```

When a parent is assigned, `WorldPosition` and `WorldRotation` are calculated relative to the parent's transform. `LocalPosition` and `LocalRotation` are the offsets from the parent. The directional properties (`Up`, `Down`, `Left`, `Right`) return unit vectors based on the current world rotation, which is useful for movement:

```csharp
position += transform.Right * speed * Engine.FrameTime;
```

## Transform3D

The `Transform3D` class is the 3D equivalent. It uses `Vector3` for position and `Quaternion` for rotation:

- `WorldPosition` / `LocalPosition`
- `WorldRotation` / `LocalRotation`
- `Parent`
- `Matrix` / `MatrixInverse`
- `Forward` / `Back` / `Right` / `Left` / `Up` / `Down`

```csharp
Transform3D transform = new(new Vector3(0, 1, 0), Quaternion.Identity);
Vector3 forward = transform.Forward;
```

Parent-child relationships work the same as `Transform2D`.