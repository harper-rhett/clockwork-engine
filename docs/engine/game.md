# Game

The game class is a starting point for your game code to be called by [Engine](engine.md), and nothing else:

```csharp
internal class MyGame : Game
{
	public MyGame()
	{

	}

	public override void OnUpdate()
	{
		
	}

	public override void OnDraw()
	{
		
	}

	public override void OnDrawGUI()
	{

	}
}
```

`OnUpdate` and `OnDraw` are abstract and must be implemented. `OnDrawGUI` is virtual and optional — it's called after the main draw loop, outside of any camera transformations, making it ideal for HUD elements and debug text.

It is recommended that the `Game` class be treated as a scene management system, as opposed to hosting any actual game logic. Most of your game logic will be written into entities. More on this in the [scene](scene.md) and [entity](entity.md) docs.

## SimpleGame

If your game only needs a single scene, `SimpleGame` wraps it for you:

```csharp
Engine.Initialize("My Game", 256, 256);
Engine.Start(new MyScene());
```

Under the hood, `Engine.Start(Scene)` creates a `SimpleGame` that calls `Update`, `Draw`, and `DrawGUI` on that scene. You can also pass an `IEnumerable<Entity>` to `Engine.Start`, which wraps everything in a `SimpleScene` and then a `SimpleGame`.