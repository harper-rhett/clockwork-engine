# Engine

The "engine" itself initializes a window and runs the main update and draw loop. It also maintains a game render texture. When draw commands are called, they are never actually drawn to the screen immediately. First they are drawn to a render texture, which is then scaled to fit the window and then drawn to the screen. This allows the game resolution to stay the same size while the window resolution changes. More on this in the [windowing](../windowing/windowing.md) section.

The engine class should be initialized with a window title and game resolution:

```csharp
Engine.Initialize("The Greatest Game Ever", 256, 256); // window title, game width, game height
MyGame myGame = new();
Engine.Start(myGame);
```

There are multiple `Start` overloads depending on how much scaffolding you need. You can pass a `Game`, a `Scene`, or even just an `IEnumerable<Entity>`:

```csharp
Engine.Start(new MyGame());       // full control
Engine.Start(new MyScene());      // wraps in a SimpleGame
Engine.Start(new Entity[] { });   // wraps in a SimpleScene, then a SimpleGame
```

The `Engine` class also has some useful public properties and methods you can use during runtime:
- `Engine.GameWidth`
- `Engine.GameHeight`
- `Engine.HalfGameWidth`
- `Engine.HalfGameHeight`
- `Engine.GameSize` — a `Vector2` containing the width and height
- `Engine.GlobalFrameTime`
- `Engine.ActualFPS`
- `Engine.TargetFPS`
- `Engine.TakeScreenshot(string folderPath)`
- `Engine.StartScreenshotBurst(string folderPath)` / `Engine.StopScreenshotBurst()`
- `Engine.DrawDebug(int fontSize, Color color, params string[] extraLogs)`

## Frame Time

Frame time is the time between frames, often called delta time. It's a useful variable for syncing actions and animations with frame rate. `Engine.GlobalFrameTime` gives the raw, unscaled frame time:

```csharp
myEntity.position += velocity * Engine.GlobalFrameTime;
```

In practice, you'll rarely reach for `Engine.GlobalFrameTime` directly. When writing entities, prefer the `FrameTime` property on `Entity` or `Scene`, which respects the scene's pause state and time scaling:

```csharp
myEntity.position += velocity * FrameTime; // inside an entity
```

See the [scene](scene.md) docs for more on the timing system.

## Debug Overlay

`Engine.DrawDebug` renders the current FPS, plus any extra log lines you pass in. It's a quick way to surface runtime values without building a UI:

```csharp
Engine.DrawDebug(16, Colors.Lime, $"Enemies: {enemyCount}", $"Score: {score}");
```

## Screenshots

`Engine.TakeScreenshot` captures a single frame to the given folder, and the burst methods capture a continuous sequence. While bursting, `Engine.IsScreenshotBursting` will be `true`:

```csharp
Engine.StartScreenshotBurst("captures");
// ...several frames later...
Engine.StopScreenshotBurst();
```

If you'd rather drive screenshots from the keyboard, set `Engine.ScreenshotCommands = true` to enable built-in hotkeys:

- `=` — take a single screenshot (saved to `screenshots`)
- `[` — start a burst (saved to `burst-screenshots`)
- `]` — stop the burst

## Viewport Culling

The engine only draws entities that report themselves as visible, which keeps large scenes performant. By default every entity is visible, but you can override `Entity.IsVisible()` to cull off-screen entities. See the [entity](entity.md) and [camera](camera.md) docs for details.