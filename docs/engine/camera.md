# Camera

> `using Clockwork.Graphics.Cameras;`

> **Example:** See `OrbitsExample` in the [examples repository](https://github.com/harper-rhett/clockwork-examples), which pairs a `Camera2D` with parented transforms to build a sun-earth-moon system.

A scene's camera can be set like so:

```csharp
scene.Camera = scene.AddEntity(new Camera2D());
```

The camera is an entity, which means it must be added to the scene. Setting `scene.Camera` tells the scene to use that camera for rendering. The camera has a [transform](../utilities/transforms.md) which you can access to move and rotate it, with `Position` and `Rotation` shortcuts for convenience:

```csharp
camera.Transform.WorldPosition = new Vector2(100, 50);
camera.Position = new Vector2(100, 50); // equivalent shortcut
camera.Zoom = 2f;                       // zoom in 2x
```

Use `Transform2DEaser` to animate camera transitions smoothly. This is handy for things like area transitions in a platformer:

```csharp
Transform2DEaser cameraEaser = scene.AddEntity(new Transform2DEaser(camera.Transform, 1f));
cameraEaser.Curve = Curves.SmoothStep;
cameraEaser.TargetWorldPosition = targetPosition;
cameraEaser.Start();
```

## Mouse World Position

`Camera2D` resolves the mouse position into world coordinates, accounting for camera position, rotation, and zoom:

```csharp
float mouseX = camera.GetMouseWorldX();
float mouseY = camera.GetMouseWorldY();
Vector2 mousePosition = new(camera.GetMouseWorldX(), camera.GetMouseWorldY());
```

## Viewport and Culling

`GetAxisAlignedViewport()` returns a `Rectangle` covering the area the camera can currently see. This is the basis for [viewport culling](entity.md) — entities can test against it to skip drawing when off-screen:

```csharp
Rectangle viewport = camera.GetAxisAlignedViewport();

// inside an entity's IsVisible override:
public override bool IsVisible()
{
	return Intersection2D.PointInRectangle(Position, gameScene.Camera.GetAxisAlignedViewport());
}
```

The viewport is "axis-aligned," meaning it's a bounding box. If the camera is rotated, the rectangle expands to contain the rotated view, so culling stays conservative (never hiding something that should be visible).

## FreeCamera2D

For quick prototyping or debug purposes, `FreeCamera2D` extends `Camera2D` with built-in keyboard controls for panning and zooming:

```csharp
FreeCamera2D camera = scene.AddEntity(new FreeCamera2D());
scene.Camera = camera;
```

It exposes several tunable fields:

- `MovementSpeed` — pan speed (default `50`)
- `ZoomSpeed` — zoom speed (default `1`)
- `MinZoomOut` — furthest zoom-out (default `0.1`)
- `MaxZoomIn` — closest zoom-in (default `10`)

## Camera3D

For 3D scenes, use `Camera3D` instead. It works similarly but uses a `Transform3D`:

```csharp
FreeCamera3D camera = scene.AddEntity(new FreeCamera3D(new Vector3(0, 1, 7.5f)));
scene.Camera = camera;
```

> **Note:** 3D support is still in active development. Expect the 3D camera and rendering APIs to change as the engine matures.