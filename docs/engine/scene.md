# Scene

A scene is an entity management system. Entities are added to the scene, and then the scene manages their update and draw loops.

The [game](game.md) class should be used to manage scenes. If you are prototyping a game loop, you could just have one scene and then add your entities like so:

```csharp
internal class MyGame : Game
{
	private Scene scene = new();

	public MyGame()
	{
		scene.AddEntity(new CustomEntity());
	}

	public override void OnUpdate()
	{
		scene.Update();
	}

	public override void OnDraw()
	{
		scene.Draw();
	}
}
```

But, if you are beyond prototyping, you should create custom scenes:

```csharp title="GameScene.cs"
internal class GameScene : Scene
{
	public GameScene()
	{
		AddEntity(new GameManager());
	}
}
```

Then those scenes are managed in `Game` but all of the game logic exists within the scene nested in entities.

A scene can also be constructed with a background color:

```csharp
Scene scene = new(Colors.Black);
```

P.S. Scenes also contain a field for a camera, if your game uses one. More on this in the [camera](camera.md) docs.

## SimpleScene

If you have a collection of entities and don't need a custom scene class, `SimpleScene` has you covered:

```csharp
Entity[] entities = { new Player(), new Enemy(), new Ground() };
SimpleScene scene = new(entities);
```

This is especially handy when combined with `Engine.Start`:

```csharp
Engine.Start(new Entity[] { new Player(), new Enemy() });
```

## Timing

Scenes have their own timing system that starts when a scene is created and is measured in seconds. What's so great about this is that the system is pausable and distortable. The calls are as simple as this:

```csharp
Console.WriteLine(scene.Time); // in seconds
scene.IsPaused = true;
scene.TimeModifier = 2;
```

This means if a game scene and a pause menu are required, both can be run at once and the game scene can be paused with leisure. Unpausing will pick up right where it left off. No time passes for a scene when it is paused. And, of course all entities are paused and live in this system, but they also all have a reference to scene. So, they can use that reference for any time related needs. Check out the [timers](../utilities/timers.md) for an example of this.

## DrawGUI

Scenes have an additional `DrawGUI()` method, which can be called alongside `Draw()`. This loop is separate from the camera-transformed draw loop and is intended for HUD elements, debug text, and overlays:

```csharp
public override void OnDraw()
{
	scene.Draw();
}

public override void OnDrawGUI()
{
	scene.DrawGUI();
}
```

Entities that override `OnDrawGUI()` will have their GUI drawing called in this loop.

## Entities

`Entities` is an actual class that each scene contains a public instance of. It's the actual collection of entities and handles update and draw order.

You can iterate through the entities in their update or draw order:

```csharp
foreach (Entity entity in scene.Entities.InUpdateOrder) { }
foreach (Entity entity in scene.Entities.InDrawOrder) { }
```