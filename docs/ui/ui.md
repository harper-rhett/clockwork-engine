# UI

> `using Clockwork.UI;`

Clockwork has a basic UI system built around the `Element` class, which extends `Entity`. An element is a rectangular, interactive region with built-in mouse handling.

## Element

```csharp
Element button = scene.AddEntity(new Element());
button.Rectangle = new Rectangle(10, 10, 100, 30);
button.BackgroundColor = Colors.Gray;
button.BorderColor = Colors.White;
button.BorderThickness = 2;
```

Elements fire events for mouse interaction:

```csharp
button.HoverEntered += (element) => element.BackgroundColor = Colors.LightGray;
button.HoverExited += (element) => element.BackgroundColor = Colors.Gray;
button.Pressed += (element) => StartGame();
button.Released += (element) => { };
```

Since `Element` extends `Entity`, it can be inherited from for more complex UI components:

```csharp
public class StartButton : Element
{
	public StartButton()
	{
		Rectangle = new Rectangle(50, 80, 120, 40);
		BackgroundColor = Colors.DarkBlue;
		BorderColor = Colors.White;
		BorderThickness = 1;
		Pressed += OnPressed;
	}

	private void OnPressed(Element element)
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
