# UI

> `using Clockwork.UI;`

> **Note:** The UI system is under active development. It covers a solid range of widgets and layout containers, but the API is still evolving and may change between versions.

Clockwork's UI is a tree of elements hosted by a `Panel`. You build a tree — containers holding buttons, text, sliders, and so on — hand the root to a panel, and add the panel to your scene. The panel handles rendering the whole tree and routing mouse input to it.

Here's a minimal example: a centered button that prints when clicked.

```csharp
// Build the tree, sized to fill the game viewport
TextButton button = new("Play", 0, 0, 120, 40);
button.Pressed += () => Console.WriteLine("Clicked!");

AlignmentContainer root = new(0, 0, Engine.GameWidth, Engine.GameHeight);
root.AddChild(button);
root.SetAlignment(button, new Alignment(HorizontalAlignment.Center, VerticalAlignment.Center));

// Host it in a panel and add to the scene
Panel panel = scene.AddEntity(new Panel(root, DrawContext.Game));
```

The root element fills the panel's canvas — here the game viewport, since this is a `DrawContext.Game` panel. A `DrawContext.GUI` panel fills the window instead, so you'd size the root to `Window.Width` and `Window.Height`. More on that below.

## Panel

The `Panel` is the only part of the UI that's an [entity](../engine/entity.md) — it's the bridge between your UI tree and the scene. It renders its `RootElement` to an internal texture, then draws that texture each frame.

A panel is created with a **draw context**, which decides what space the UI lives in:

- `DrawContext.GUI` — the UI is drawn in window space, on top of everything, at the window's resolution. Use this for menus, HUDs, and tools. Mouse input uses window coordinates.
- `DrawContext.Game` — the UI is drawn inside the game's render texture, so it scales with your game resolution like everything else. Mouse input uses game-viewport coordinates.

```csharp
Panel guiPanel = scene.AddEntity(new Panel(rootElement, DrawContext.GUI));
Panel gamePanel = scene.AddEntity(new Panel(rootElement, DrawContext.Game));
```

The panel tracks its context's size and resizes automatically — a `GUI` panel follows the window, a `Game` panel follows the game resolution. You can scale and align the whole panel within its context:

```csharp
panel.Scale = 2f;
panel.HorizontalAlignment = HorizontalAlignment.Right;
panel.VerticalAlignment = VerticalAlignment.Bottom;
```

Because a panel owns a render texture, it's disposable. Removing it from the scene detaches its resize handlers, and you can call `Dispose()` to release the texture when you're truly done with it.

## Element

Every piece of UI derives from `Element`. On its own an element is just a styled rectangle, but it's the foundation for everything else. Elements have integer position and size, with convenient read-only accessors:

```csharp
Element element = new(10, 10, 100, 30); // x, y, width, height
element.X = 20;
Vector2 center = element.Position + new Vector2(element.GetHalfWidth(), element.GetHalfHeight());
Rectangle bounds = element.Rectangle;
```

### Styling

An element's look comes from a [`Style`](#style). The `BackgroundColor`, `BorderColor`, and `BorderThickness` properties are shortcuts that write to the element's active style:

```csharp
element.BackgroundColor = Colors.SlateGray;
element.BorderColor = Colors.White;
element.BorderThickness = 2;
```

### Events

Elements raise events for mouse interaction:

```csharp
element.HoverEntered += () => element.BackgroundColor = Colors.LightGray;
element.HoverExited += () => element.BackgroundColor = Colors.SlateGray;
element.Pressed += () => Fire();
element.Released += () => Release();
```

### Enabled and Visible

`Enabled` toggles interactivity — a disabled element ignores input and renders with a dimmed style. `Visible` toggles drawing without affecting layout:

```csharp
button.Enabled = false; // greyed out, ignores clicks
label.Visible = false;  // hidden, still occupies its space
```

## Style

`Style` is a small struct bundling a background color, border color, and border thickness. Widgets use styles to describe their different states (default, hover, pressed):

```csharp
Style style = new(Colors.DarkBlue, Colors.White, 2); // background, border, thickness
Style hidden = Style.Invisible;                       // fully transparent
```

## Next Steps

- [Containers](containers.md) — arranging elements with layout containers.
- [Widgets](widgets.md) — buttons, toggles, sliders, text, textures, and file pickers.
