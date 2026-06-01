# Graphics

> `using Clockwork.Graphics;`

The graphics namespace contains everything needed to draw to the screen.

## 2D Primitives

> `using Clockwork.Graphics.Draw2D;`

A circle, drawn at (0, 0), with a radius of 8, is drawn like so:

```csharp
Primitives2D.DrawCircle(0, 0, 8, Colors.Blue);
```

or as the following:

```csharp
Primitives2D.DrawCircle(Vector2.Zero, 8, Colors.Blue);
```

Many draw methods have overloads that allow for additional options. `Primitives2D` covers lines, circles, rectangles, triangles, polygons, and more. Splines have their own class:

```csharp
Spline.DrawLinear(splinePositions, splineThickness, splineColor);
```

## 3D Primitives

> `using Clockwork.Graphics.Draw3D;`

> **Note:** 3D support is still under active development. The primitives and model APIs below work, but expect rough edges and changes as 3D matures. The engine's primary focus today is 2D.

> **Example:** See `Primitives3DExample` in the [examples repository](https://github.com/harper-rhett/clockwork-examples) for a 3D scene with a free-flying camera.

For 3D rendering, `Primitives3D` provides spheres, cubes, capsules, and other shapes:

```csharp
Primitives3D.DrawSphere(position, radius, Colors.White);
Primitives3D.DrawCapsule(start, end, radius, slices, rings, color);
```

3D models can also be loaded and drawn:

```csharp
Model model = Model.Load("spaceship.obj");
model.Draw(position, scale, Colors.White);
```

## Text

Text has its own class as well. Drawing horizontally centered text might look like this:

```csharp
string text = "Eat my shorts!";
int textWidth = Text.MeasureWidth(text, fontSize);
int textX = Engine.HalfGameWidth - textWidth / 2;
Text.Draw(text, textX, textY, fontSize, Colors.White);
```

## Textures

Of course, you will need to be able to draw textures as well. That process is as follows:

```csharp
Texture alligatorTexture = Texture.Load("alligator.png");
alligatorTexture.Draw(x, y, Colors.White);
```

It is recommended textures be loaded at the beginning of a scene or at the launch of a game. Loading textures at runtime may slow down performance.

There is such a thing as a `RenderTexture` as well, which can be drawn to and has a texture of its own:

```csharp
RenderTexture.BeginDrawing(myRenderTexture);
Primitives2D.DrawPolygon(position, sides, radius, rotation, color);
RenderTexture.EndDrawing();

myRenderTexture.Texture.Draw(x, y, Colors.White);
```

When textures are no longer needed, they should be cleaned up with `texture.Dispose()` to release them from memory. This is not necessary if you are okay with your textures persisting in memory until the game exits.

## Colors

The `Color` struct supports multiple constructor formats:

```csharp
Color red = new(255, 0, 0);         // byte RGB
Color blue = new(0, 0, 255, 128);   // byte RGBA
Color green = new(0f, 1f, 0f);      // float RGB (0.0 to 1.0)
```

Colors have some useful methods for manipulation:

```csharp
Color transparent = color.SetAlpha(0.5f);
Color invisible = color.DropAlpha();
Color blended = Color.Lerp(Colors.Red, Colors.Blue, 0.5f);
```

The `Colors` class contains a large set of predefined colors like `Colors.White`, `Colors.Red`, and so on.

## Gradients

A `Gradient` blends across several colors, and `Sample` returns the color at a position from `0` to `1`. It's handy for health bars, skies, heatmaps, and animating colors over time:

```csharp
Gradient gradient = new(Colors.Red, Colors.Yellow, Colors.Green);
Color midpoint = gradient.Sample(0.5f);
```

> **Example:** See `GradientExample` in the [examples repository](https://github.com/harper-rhett/clockwork-examples), which samples a gradient across the width of the screen.

## Parallax

The `Parallax` entity creates multi-layered scrolling backgrounds that move relative to a camera:

```csharp
Parallax parallax = scene.AddEntity(new Parallax(camera, originPosition, startPosition));
parallax.AddLayer(skyTexture, Vector2.Zero, 0.1f, 0.1f);
parallax.AddLayer(mountainTexture, Vector2.Zero, 0.3f, 0.3f);
parallax.AddLayer(treesTexture, Vector2.Zero, 0.6f, 0.6f);
```

Each layer has its own speed multiplier for horizontal and vertical scrolling. Set `RepeatX` or `RepeatY` to `false` if you don't want the layer to tile in that direction.

## Other Features

Check out the source code to find out more information about this namespace. Other features include:

- Shaders and shader data
- Images (bitmap manipulation)
- Blend modes
- Nine-patch sprites