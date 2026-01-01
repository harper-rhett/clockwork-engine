![Logo](logo.png)
# Clockwork Engine
Clockwork Engine is a (currently) 2D C# game development framework built on the [Raylib Graphics Library](https://www.raylib.com/). It is outfitted with tools designed to make prototyping simple, projects scalable, and scope-creep manageable.

Currently there is only support for x64 systems, but that will change. Raylib executables for other runtimes just need to be added to the project (so far as I understand).

## Resources
- [NuGet Package](https://www.nuget.org/packages/ClockworkEngine)
- [Template](https://github.com/harper-rhett/clockwork-template)
- [Examples](https://github.com/harper-rhett/clockwork-examples)
- [Documentation](https://clockwork-engine.readthedocs.io/en/latest/)
- [Discord](https://discord.gg/7qsRSKSYU8)

## Features
- Scene management system (with entities, update loops, and layers)
- Window resolution management (scale or clip game content automatically)
- Particle engine (simple, manageable, and extendible)
- Extended randomization (C#'s `Random` class is simply not enough)
- Time control (pause scenes, distort time, and create intuitive timers)
- Easing tools (interpolation has never been simpler)
- Transforms (opt-in parent-child system)
- Collision helpers (with extensions built into the entity system)
- Texture animation (including an animation manager)
- Tiling systems (forgot documentation, patience please)

## Roadmap
- Noise generation (Simplex, Perlin, Cellular, Drum and Bass)
- UI utilities (flexing my layout on you)
- Physics engines (boing, clank, smack)
- 3D (1.5x more dimensions!)

## Raylib Bindings
If you are familiar with Raylib, Clockwork's Raylib bindings may feel somewhat alien to you. They have been carefully adapted to flow better with C#. Drawing a texture, for instance:
### In Raylib
```c
Texture2D myTexture = LoadTexture(filePath);
DrawTexture(myTexture, x, y, color);
```
### In Clockwork
```csharp
using Clockwork.Graphics;
Texture myTexture = Texture.Load(filePath);
myTexture.Draw(x, y, color);
```

Some bindings are less obvious than others. Not all bindings are implemented. Check the documenation and source code.

## Getting Started
Clockwork was created in Visual Studio, and so it is recommended you use Visual Studio. Other IDEs should work fine, but there is not a recommended set up process for them.

The best way to start is probably with the [template](https://github.com/harper-rhett/clockwork-template) to see a minimal project structure. Then, jump into the [documentation](https://app.readthedocs.org/projects/harp-engine/builds/29567953/) for more information. If you'd like to start a project from scratch, I promise you it's stupid simple. Install the [NuGet package](https://www.nuget.org/packages/ClockworkEngine) and take a look at the [examples](https://github.com/harper-rhett/clockwork-examples). Ultimately, however, you will need the [documentation](https://harp-engine.readthedocs.io/en/latest/). The engine may currently be small, but the codebase is becoming quite large.

## Minimal Example
In `Program.cs`:
```csharp
using Clockwork;

Engine.Initialize("My Game", 256, 256); // title, game width, game height
MyGame myGame = new();
Engine.Start(myGame);
```

In `MyGame.cs`:
```csharp
using Clockwork;

internal class MyGame : Game // the game class handles scenes
{
	Scene scene = new(); // the scene class handles entities (their layers, update loops, and registry)

	public MyGame()
	{
    // Initialize game here

    // If you are only using one scene (such as for prototyping) you can add entities to the scene in your game class.
    MyEntity myEntity = AddEntity(new MyEntity()); // added to the scene
    // For larger projects it is recommended you create your own scene classes (inheriting from Scene).
    // For instance, MenuScene.cs, GameScene.cs, etc.

    // If you'd like, you don't have to use scenes at all. You can create your own entity management logic.
    // Though, that would defeat the purpose of this framework.
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

## Building
A basic build for your own machine is simple. Just press F5. For a release build, however, there are a few more steps.

Right click on your project in the Solution Explorer, and select publish. For the build target, choose folder. Set the output location to wherever you desire your build land. Congratulations! You have just created a publish profile.

Click "show all settings" and change the configuration to "release" and the deployment mode to "self-contained." Drop down "file publish options" and enable "produce single file." Now save your changes and slap that big ol' "publish" button. The build folder should be generated in the location you defined, and you can zip the folder up and send it out!

## Contributing
I am largely open to suggestions and criticisms, but __I am not open to pull requests__. This is a learning opportunity, and so building this framework line-by-line is important to me. In the __very distant__ future I may even replace Raylib with my own graphics library, and create a custom physics engine. Along the way, I would like to make 2D and 3D level editors, and possibly node-based shader and texture editors as well. If you are frustrated with any aspect of this engine, I encourage you to submit an issue. I intend to listen to all criticisms and adjust my engine accordingly.

Otherwise, the best way to support my development is by [supporting my work financially](https://github.com/sponsors/harper-rhett). The contribution will directly fund my open-source projects, ultimately benefiting you and the open-source community.
