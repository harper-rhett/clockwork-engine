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
- `Entity.IsRendering`: Pause the draw loop.
- `Entity.UpdateLayer`: Change the update layer.
- `Entity.DrawLayer`: Change the draw layer.
- `Entity.IsInScene`: Whether the entity is currently in a scene.