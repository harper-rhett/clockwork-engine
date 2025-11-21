# Texture Animation

> `using HarpEngine.Animation`

Texture animation is pretty simple, and is done like so:

```csharp
Texture walkingTexture = Texture.Load("sprites/player/walking.png");
TextureAnimation walkingAnimation = new(walkingTexture, 4, 16, 16, 0.2f);
```

```csharp
private override void OnDraw()
{
	walkingAnimation.Draw(position, direction, Colors.White);
}
```

But probably, you want multiple animations all in one convenient system. Fear not:

```csharp
public enum Animation
{
	Idle,
	Walking
}

TextureAnimationManager<Animation> animationManager = new();
animationManager.Register(idleAnimation, Animation.Idle);
animationManager.Register(walkAnimation, Animation.Walking);
```

```csharp
public void Walk(float direction)
{
	position.X += direction * walkSpeed;
	animationManager.CurrentAnimationID = Animation.Walking;
}
```

```csharp
public override void OnDraw()
{
	animationManager.Draw(position, direction, Colors.White);
}
```