# Camera

A scene's camera can be set like so:

```csharp
scene.Camera = scene.AddEntity(new Camera2D());
```

The camera has a [transform](../utilities/transforms.md) which you can access to move and rotate it. Use `Transform2DEaser` to animate transitions.