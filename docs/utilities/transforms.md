# Transforms

> `using Clockwork.Utilities;`

> **Example:** `OrbitsExample` in the [examples repository](https://github.com/harper-rhett/clockwork-examples) demonstrates parent-child transforms with nested orbits.

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
position += transform.Right * speed * FrameTime;
```

## Translation2D and Rotation2D

A full `Transform2D` handles both position and rotation, but sometimes you only need one. `Translation2D` and `Rotation2D` are lighter-weight components that each handle a single concern, and each supports its own parent hierarchy:

```csharp
Translation2D translation = new();
translation.LocalPosition = new Vector2(100, 50);

Rotation2D rotation = new();
rotation.LocalRotation = 0.5f;
```

Both expose `Parent`, `WorldPosition`/`WorldRotation`, `LocalPosition`/`LocalRotation`, and `Matrix`/`MatrixInverse`, mirroring `Transform2D`.

They're backed by the `ITranslation2D` and `IRotation2D` interfaces, which `Transform2D` also implements. This lets you write code that operates on "anything with a position" or "anything with a rotation" without caring about the concrete type:

```csharp
void Recenter(ITranslation2D translation)
{
	translation.WorldPosition = Vector2.Zero;
}
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