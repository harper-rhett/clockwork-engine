# Windowing

> `using Clockwork.Windowing;`

Use the static `Window` class to change several window properties. For instance:

```csharp
Window.SetFullscreen(true);
Window.SetVsync(true);
Window.SetMSAA4x(true);
```

And the class has other useful properties and methods as well:

```csharp
int windowWidth = Window.Width;
Window.Resize(900, 800);
Window.SetExitKey(KeyboardKey.Escape);
Window.RemoveExitKey();
Window.Close();
```

## Fullscreen

There are two flavors of fullscreen. `SetFullscreen` uses a borderless window at the desktop resolution, which is quick to toggle and plays nicely with alt-tabbing. `SetExclusiveFullscreen` takes over the display at the game's resolution:

```csharp
Window.SetFullscreen(true);            // borderless
Window.SetExclusiveFullscreen(true);   // exclusive

bool borderless = Window.IsFullscreen;
bool exclusive = Window.IsExclusiveFullscreen;
```

## State and Resizing

The window exposes its current state, including whether it was resized this frame and whether it's focused:

```csharp
if (Window.WasResized) RebuildLayout();
bool focused = Window.IsFocused;
int renderWidth = Window.RenderWidth; // actual framebuffer size, useful on high-DPI displays
```

You can also subscribe to the `Resized` event, which fires with the new dimensions:

```csharp
Window.Resized += (width, height) => Console.WriteLine($"Resized to {width}x{height}");
```

## Drag and Drop

When the user drops files onto the window, `ItemPathsDropped` becomes true. Consume the paths to handle them:

```csharp
if (Window.ItemPathsDropped)
{
	string[] paths = Window.ConsumeDroppedItemPaths();
	foreach (string path in paths) LoadFile(path);
}
```

## File Dialogs

`WindowDialogs` opens the operating system's native file and folder pickers. Each method follows the `Try` pattern, returning `false` if the user cancels:

```csharp
if (WindowDialogs.TrySelectFile("Open Image", out string[] paths, extensionfilters: new[] { "png", "jpg" }))
{
	LoadImage(paths[0]);
}

if (WindowDialogs.TrySelectFolder("Choose Output Folder", out string folder))
{
	outputPath = folder;
}

if (WindowDialogs.TrySaveFile("Save As", out string savePath, extensionFilters: new[] { "sav" }))
{
	Save(savePath);
}
```

`TrySelectFile` can allow multiple selections with `allowMultipleSelections: true`. The [`UploadBox`](../ui/widgets.md#uploadbox) widget wraps these dialogs in a clickable UI element.

# Window Rendering

When creating a game in Clockwork, you must decide what your game's resolution will be, regardless of the window's resolution. This is so that the resolution of the game may be scaled accordingly to the window's settings. There are currently 2 options for window rendering, and there will be more in the future.

## Unclipped Renderer

Set the window renderer unclipped if you would like your game's full resolution visible at all times. This will not clip the horizontal or vertical dimension of your game and will instead add borders. This is optimal for arcade-style gameplay.

```csharp
Window.SetRendererUnclipped(borderColor);
```

## Clipped Renderer

Set the window clipped if you are okay with losing some resolution depending on the window aspect ratio. A wide window will lose game height, and a tall window will lost game width.

```csharp
Window.SetRendererClipped();
```

## Future Renderers

These two options are not enough for many game types. Allow the engine some time to develop, and more options will come along.