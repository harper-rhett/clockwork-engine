# Engine

The "engine" itself initializes a window and runs the main update and draw loop. It also maintains a game render texture. When draw commands are called, they are never actually drawn to the screen immediately. First they are drawn to a render texture, which is then scaled to fit the window and then drawn to the screen. This allows the game resolution to stay the same size while the window resolution changes. More on this in the [windowing](../windowing/windowing.md) section.

The engine class should be initialized with an `EngineSettings` struct which contains some basic window information:

```csharp
Engine.Initialize("The Greatest Game Ever", 256, 256); // window title, game width, game height
MyGame myGame = new();
Engine.Start(myGame);
```

The `Engine` class also has some useful public properties and methods you can use during runtime:
- `Engine.GameWidth`
- `Engine.GameHeight`
- `Engine.HalfGameWidth`
- `Engine.HalfGameHeight`
- `Engine.FrameTime`
- `Engine.SetTargetFPS(int fps)`
- `Engine.TakeScreenshot(string fileName)`

Frame time is the time between frames, often called delta time. It's a useful variable for syncing actions and animations with frame rate. Though, you will primarily use it when writing entities. For instance:

```csharp
myEntity.position += velocity * Engine.FrameTime;
```