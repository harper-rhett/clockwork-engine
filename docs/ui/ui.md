# UI

> `using Clockwork.UI;`

Clockwork has a basic UI system built around the `Element` class, which extends `Entity`. An element is a rectangular, interactive region with built-in mouse handling.

> **Note:** The UI system is an early work in progress. The `Element`, `Container`, and `Button` classes cover common cases, but the API is expected to grow and change. For polished interfaces you may still want to draw your own widgets directly.

## Element

`Element` has constructors for the common ways you'd lay one out:

```csharp
Element element = scene.AddEntity(new Element(10, 10, 100, 30)); // x, y, width, height
Element element = scene.AddEntity(new Element(position, size));  // Vector2 position and size
```

Or configure it after construction:

```csharp
Element element = scene.AddEntity(new Element());
element.Rectangle = new Rectangle(10, 10, 100, 30);
element.BackgroundColor = Colors.Gray;
element.BorderColor = Colors.White;
element.BorderThickness = 2;
```

Elements fire events for mouse interaction:

```csharp
element.HoverEntered += (element) => element.BackgroundColor = Colors.LightGray;
element.HoverExited += (element) => element.BackgroundColor = Colors.Gray;
element.Pressed += (element) => StartGame();
element.Released += (element) => { };
```

## Container

`Container` extends `Element` and holds child elements. Adding children to a container groups them together, and the container's `Padding` insets its children:

```csharp
Container panel = scene.AddEntity(new Container(20, 20, 200, 120));
panel.Padding = 8;
panel.Children.Add(new Element(0, 0, 50, 20));
panel.Children.Add(new Element(0, 30, 50, 20));
```

## Button

`Button` extends `Container` and wraps the interaction events as overridable methods, which is cleaner than wiring up event handlers when you're subclassing. It also draws an `AccentColor` to reflect hover and press states:

```csharp
public class StartButton : Button
{
	public StartButton() : base(50, 80, 120, 40)
	{
		BackgroundColor = Colors.DarkBlue;
		BorderColor = Colors.White;
		BorderThickness = 1;
		AccentColor = Colors.SkyBlue;
	}

	public override void OnPressed(Element element)
	{
		// start the game
	}

	public override void OnDraw()
	{
		base.OnDraw();
		Text.Draw("Start", (int)Rectangle.X + 10, (int)Rectangle.Y + 10, 20, Colors.White);
	}
}
```

The overridable handlers are `OnHoverEntered`, `OnHoverExited`, `OnPressed`, and `OnReleased`.
