# Texture Animation

> `using Clockwork.Animation`

Texture animation is pretty simple, and is done like so:

```csharp
Texture walkingTexture = Texture.Load("sprites/player/walking.png");
TextureAnimation walkingAnimation = new(walkingTexture, 4, 16, 16, 0.2f);
```

The arguments are the texture, frame count, frame width, frame height, and time per frame. Frames are read left-to-right, top-to-bottom from the sprite sheet.

```csharp
public override void OnDraw()
{
	walkingAnimation.Draw(position, direction, Colors.White);
}
```

Animations loop by default. Set `PlayOnce` to `true` if the animation should stop on the last frame. You can also pause, reset, or manually set the animation time:

```csharp
walkingAnimation.IsPaused = true;
walkingAnimation.Reset();
walkingAnimation.AnimationTime = 0.5f;
```

But probably, you want multiple animations all in one convenient system. Fear not:

```csharp
public enum Animation
{
	Idle,
	Walking
}

TextureAnimationManager<Animation> animationManager = new();
animationManager.RegisterAnimation(idleAnimation, Animation.Idle);
animationManager.RegisterAnimation(walkAnimation, Animation.Walking);
```

```csharp
public void Walk(float direction)
{
	position.X += direction * walkSpeed;
	animationManager.State = Animation.Walking;
}
```

```csharp
public override void OnDraw()
{
	animationManager.Draw(position, direction, Colors.White);
}
```

You can also access the current `TextureAnimation` directly through `animationManager.CurrentAnimation` if you need finer control.