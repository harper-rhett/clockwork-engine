# Easer

> `using Clockwork.Animation`

The Easer class was created to help with simple programmatic animations, and uses the [Curves](curves.md) class to support it. Check it out:

```csharp
Easer starEaser = scene.AddEntity(new Easer(easeSeconds));
starEaser.Curve = Curves.SmoothStep;
starEaser.Easing += EaseShootingStar;
starEaser.Start();

void EaseShootingStar(Easer easer)
{
	star.Position = easer.EaseVector2(startPosition, endPosition);
	star.Rotation = easer.EaseFloat(startRotation, endRotation);
	star.Color = easer.EaseColor(startColor, endColor);
}
```

This moves a star, rotates it, and interpolates its color. Then the easer kills itself when it is finished (or not, if you set `RemoveOnFinished` to `false`). You can also tell the easer to repeat itself with the `Rewind` property.

The easer exposes `Progress` (0 to 1, linear) and `CurveProgress` (curve-adjusted), and has interpolation helpers for common types:

- `EaseFloat(from, to)`
- `EaseVector2(from, to)`
- `EaseVector3(from, to)`
- `EaseQuaternion(from, to)`
- `EaseColor(from, to)`

You can also `Skip()` an easer to jump it to the end on the next update, or subscribe to the `Finished` event:

```csharp
starEaser.Finished += OnStarArrived;
```

## Transform2DEaser

There is also a `Transform2DEaser` class that inherits from easer and makes it super simple to apply easing to any objects with a `Transform2D` field:

```csharp
Transform2DEaser mover = scene.AddEntity(new Transform2DEaser(myEntity.Transform, 1f));
mover.Curve = Curves.SmoothStep;
mover.TargetWorldPosition = destination;
mover.Start();
```

It automatically captures the transform's current state when constructed. If you need to recapture (for instance, chaining multiple eases), call `SerializeTransform()`. The easer handles parent-child transform relationships correctly.