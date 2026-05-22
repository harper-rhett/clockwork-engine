# Camera

> `using Clockwork.Graphics;`

A scene's camera can be set like so:

```csharp
scene.Camera = scene.AddEntity(new Camera2D());
```

The camera is an entity, which means it must be added to the scene. Setting `scene.Camera` tells the scene to use that camera for rendering. The camera has a [transform](../utilities/transforms.md) which you can access to move and rotate it:

```csharp
camera.Transform.WorldPosition = new Vector2(100, 50);
```

Use `Transform2DEaser` to animate camera transitions smoothly. This is handy for things like area transitions in a platformer:

```csharp
Transform2DEaser cameraEaser = scene.AddEntity(new Transform2DEaser(camera.Transform, 1f));
cameraEaser.Curve = Curves.SmoothStep;
cameraEaser.TargetWorldPosition = targetPosition;
cameraEaser.Start();
```

## Mouse World Position

`Camera2D` provides the mouse position in world coordinates, which accounts for camera offset and zoom:

```csharp
float mouseX = camera.MouseWorldX;
float mouseY = camera.MouseWorldY;
```

## FreeCamera2D

For quick prototyping or debug purposes, `FreeCamera2D` extends `Camera2D` with built-in keyboard controls for panning and zooming:

```csharp
FreeCamera2D camera = scene.AddEntity(new FreeCamera2D());
scene.Camera = camera;
```

It has configurable `MovementSpeed` and `ZoomSpeed` properties.

## Camera3D

For 3D scenes, use `Camera3D` instead. It works similarly but uses a `Transform3D`:

```csharp
FreeCamera3D camera = scene.AddEntity(new FreeCamera3D(new Vector3(0, 1, 7.5f)));
scene.Camera = camera;
```