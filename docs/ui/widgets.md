# Widgets

> `using Clockwork.UI;`

Widgets are the interactive and content elements you place inside [containers](containers.md). Each is an [`Element`](ui.md#element), so it inherits position, styling, and events, and many come in a plain form and a text-labeled form.

## TextElement

`TextElement` draws a string. It exposes the font, size, spacing, color, and alignment within its own bounds:

```csharp
TextElement label = new("Score: 0", 20, Colors.White); // content, font size, color
label.Font = myFont;
label.CharacterSpacing = 1;
label.HorizontalAlignment = HorizontalAlignment.Center;
label.VerticalAlignment = VerticalAlignment.Center;
```

Update `Text` at any time; `TextWidth` and `TextHeight` report the rendered size, and a disabled element uses `DisabledTextColor`.

## TextureElement

`TextureElement` displays an image loaded from a path, tinted by `Color`. It owns its texture, so it's disposable:

```csharp
TextureElement logo = new("logo.png");
logo.Color = Colors.White;
```

## Button

`Button` is a clickable frame with three styles it swaps between automatically: `DefaultStyle`, `HoverStyle`, and `PressedStyle`. It also tracks `IsHovered` and `IsPressed`.

The simplest way to respond is to subscribe to the inherited `Pressed` event:

```csharp
Button button = new(0, 0, 120, 40);
button.Pressed += () => StartGame();
```

For reusable buttons, subclass and override the virtual handlers instead — `OnPressed`, `OnReleased`, `OnHoverEntered`, `OnHoverExited`. Call `base` to keep the automatic style swapping:

```csharp
public class PlayButton : TextButton
{
	public PlayButton() : base("Play", 0, 0, 120, 40) { }

	public override void OnPressed()
	{
		base.OnPressed();
		Game.Start();
	}
}
```

If the pointer is pressed on a button but then dragged off before release, the click is abandoned and the `Cancelled` event fires.

## TextButton

`TextButton` is a `Button` with a centered `TextElement` built in. Set the label through `Text`, and the font through `Font`:

```csharp
TextButton button = new("Options", 0, 0, 160, 48);
button.Font = myFont;
button.Pressed += OpenOptions;
```

## Toggle

`Toggle` is a checkbox. It holds an `IsChecked` state, swaps between `CheckStyle` and `UncheckedStyle` for its check mark, and raises `ValueChanged` when flipped:

```csharp
Toggle toggle = new(new Vector2(0, 0), new Vector2(40, 40));
toggle.ValueChanged += (isChecked) => SetMuted(isChecked);
```

`TextToggle` pairs a toggle with a label:

```csharp
TextToggle toggle = new("Fullscreen");
toggle.ValueChanged += (isChecked) => Window.SetFullscreen(isChecked);
```

## Slider

`HorizontalSlider` drags a handle along a rail to pick a `Value`. Subscribe to `ValueChanged` to react as the user drags:

```csharp
HorizontalSlider slider = new();
slider.Width = 300;
slider.ValueChanged += (value) => SetVolume(value);
```

The slider exposes its `Rail`, `Handle`, and a `ValueText` element (hidden by default) if you want to show the current value, plus `IsDragging` and `ValueTextOffset`.

`HorizontalTextSlider` adds a label alongside the slider:

```csharp
HorizontalTextSlider slider = new("Volume");
slider.ValueChanged += (value) => SetVolume(value);
```

## UploadBox

`UploadBox` is a button that opens a native file or folder dialog when clicked, using the platform dialogs described in [windowing](../windowing/windowing.md). Choose what it selects with `Type`:

```csharp
UploadBox uploadBox = new(0, 0, 200, 50);
uploadBox.Type = UploadBoxType.SingleFile;
uploadBox.ExtensionFilters = new[] { "png", "jpg" };
uploadBox.DefaultPath = "assets";
uploadBox.ItemPathSelected += (path) => LoadImage(path);
```

`UploadBoxType` is `SingleFile`, `MultipleFiles`, or `Folder`. Single selections raise `ItemPathSelected`; multiple selections raise `ItemPathsSelected` with an array.

`TextUploadBox` shows the selected path (or a prompt) as a label:

```csharp
TextUploadBox uploadBox = new("Choose a file...");
uploadBox.ItemPathSelected += (path) => Load(path);
```
