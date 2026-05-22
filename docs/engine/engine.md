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
- `Engine.GameSize` — a `Coordinate` containing the width and height
- `Engine.FrameTime`
- `Engine.FPS`
- `Engine.TargetFPS`
- `Engine.TakeScreenshot(string folderPath)`
- `Engine.StartScreenshotBurst(string folderPath)` / `Engine.StopScreenshotBurst()`
- `Engine.DrawDebug(int fontSize, int spacing)`

Frame time is the time between frames, often called delta time. It's a useful variable for syncing actions and animations with frame rate. Though, you will primarily use it when writing entities. For instance:

```csharp
myEntity.position += velocity * Engine.FrameTime;
```

Screenshot burst is handy for capturing sequences of frames. While bursting, `Engine.IsScreenshotBursting` will be `true`.