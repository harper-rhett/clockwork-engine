# Easer

> `using Clockwork.Animation`

The Easer class was created to help with simple programatic animations, and uses the [Curves](curves.md) class to support it. Check it out:

```csharp
Easer starEaser = new Easer(scene, easeSeconds);
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

There is also a `Transform2DEaser` class that inherits from easer and makes it super simple to apply easing to any objects with a `Transform2D` field.