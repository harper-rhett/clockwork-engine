# Entity

An entity is an object that exists physically in your game. Entities can be a player, or a wall, or a magic potion. The implementation is pretty simple, and leaves all of the fun work up to you:

```csharp
public class CustomEntity : Entity
{
	public CustomEntity()
	{
		// Initialize
	}

	public override void OnUpdate()
	{
		// Movement, animation, input, etc.
	}

	public override void OnDraw()
	{
		// Shapes, textures, text, etc.
	}

	public override void OnDrawGUI()
	{
		// HUD elements, debug text, etc.
	}
}
```

Entities do not require a scene reference in their constructor. Instead, the `Scene` field is set automatically when the entity is added to a scene. You can access it at any time after the entity has been added:

```csharp
public override void OnUpdate()
{
	if (Scene.Time > 5) Explode();
}
```

## Lifecycle

Entities have two lifecycle callbacks for when they enter or leave a scene:

```csharp
public override void OnAddedToScene()
{
	// Scene is now accessible. Create child entities, start timers, etc.
}

public override void OnRemovedFromScene()
{
	// Clean up child entities or other resources.
}
```

`OnAddedToScene` is the right place for any initialization that depends on `Scene` being available, such as adding child entities to the same scene. `OnRemovedFromScene` replaces the old `OnRemove` callback.

Entities can also add or remove themselves from scenes:

```csharp
myEntity.AddToScene(scene);
myEntity.RemoveFromScene();
```

There's also a `Removed` event you can subscribe to:

```csharp
myEntity.Removed += () => Console.WriteLine("Goodbye!");
```

The `IsInScene` property tells you whether an entity is currently in a scene.

## Custom Scene References

If your entity belongs to a custom scene with useful methods, it might be a good idea to save the scene's reference for later:

```csharp
private GameScene gameScene;
private int health;

public CustomEntity(GameScene gameScene)
{
	this.gameScene = gameScene;
}

public override void OnUpdate()
{
	if (health <= 0) gameScene.GameOver();
}
```

## Properties

`Entity` has several very useful public properties:
- `Entity.IsUpdating`: Pause the update loop.
- `Entity.IsDrawing`: Pause the draw loop.
- `Entity.UpdateLayer`: Change the update layer.
- `Entity.DrawLayer`: Change the draw layer.
- `Entity.IsInScene`: Whether the entity is currently in a scene.
- `Entity.FrameTime`: The scene's frame time, respecting pause and time scaling.
- `Entity.Time`: The scene's elapsed time in seconds.

`FrameTime` and `Time` are conveniences that read from the entity's scene, so you don't have to write `Scene.FrameTime` everywhere:

```csharp
public override void OnUpdate()
{
	position += velocity * FrameTime;
	if (Time > deathTime) RemoveFromScene();
}
```

## Viewport Culling

The scene skips drawing entities that aren't visible. By default `IsVisible()` returns `true`, but you can override it to cull entities outside the camera's view. This is a big win in large worlds where most entities are off-screen at any moment:

```csharp
public override bool IsVisible()
{
	return Intersection2D.PointInRectangle(Position, gameScene.Camera.GetAxisAlignedViewport());
}
```

Culling only affects drawing. Entities continue to update even when not visible, so game logic stays correct. See the [camera](camera.md) docs for `GetAxisAlignedViewport`.