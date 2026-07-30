# Containers

> `using Clockwork.UI;`

A `Container` is an element that holds other elements. Containers own the layout of their children — where they sit and, in some cases, how big they are. The base `Container` doesn't reposition anything by itself; you'll usually reach for one of its layout-aware subclasses below.

## Container Basics

Every container manages a list of children and supports padding, either uniform or per-side:

```csharp
Container container = new(0, 0, 300, 200);
container.Padding = 8;        // all sides
container.PaddingLeft = 16;   // or set sides individually
container.AddChild(element);
container.InsertChild(0, header);
container.RemoveChild(element);
```

Children are laid out automatically as they're added and whenever the container moves or resizes. If you change something the container can't observe on its own, call `ForceLayoutUpdate()` to re-run the layout.

Because containers are elements, they nest freely — a container can hold other containers, letting you compose complex interfaces from simple pieces.

## FrameContainer

`FrameContainer` stretches each child to fill the container, minus padding. It's useful as a background frame or padded wrapper around a single element:

```csharp
FrameContainer frame = new(0, 0, 200, 60, new Style(Colors.DarkSlateGray, Colors.White, 2));
frame.Padding = 4;
frame.AddChild(new TextElement("Title"));
```

## AlignmentContainer

`AlignmentContainer` places each child according to an `Alignment` you assign — a horizontal and vertical anchor. It's the go-to for centering things or pinning them to a corner or edge:

```csharp
AlignmentContainer container = new(0, 0, Engine.GameWidth, Engine.GameHeight);
container.AddChild(title);
container.AddChild(quitButton);

container.SetAlignment(title, new Alignment(HorizontalAlignment.Center, VerticalAlignment.Top));
container.SetAlignment(quitButton, new Alignment(HorizontalAlignment.Right, VerticalAlignment.Bottom));
```

`HorizontalAlignment` is `Left`, `Center`, or `Right`; `VerticalAlignment` is `Top`, `Center`, or `Bottom`. Padding is respected, so a `Right`-aligned child sits inside the right padding rather than flush against the edge.

## Stack Containers

Stack containers arrange children in a row or column, one after another, separated by `Spacing`.

`HorizontalStackContainer` lays children left to right:

```csharp
HorizontalStackContainer row = new(0, 0, 400, 40);
row.Spacing = 8;
row.AddChild(new TextButton("Back"));
row.AddChild(new TextButton("Next"));
```

`VerticalStackContainer` lays them top to bottom:

```csharp
VerticalStackContainer menu = new(0, 0, 200, 300);
menu.Spacing = 12;
menu.AddChild(new TextButton("Resume"));
menu.AddChild(new TextButton("Options"));
menu.AddChild(new TextButton("Quit"));
```

By default, children keep their own size along the stacking axis. Set `StretchChildrenWidth` (horizontal) or `StretchChildrenHeight` (vertical) to divide the available space evenly among the children instead:

```csharp
row.StretchChildrenWidth = true; // every child gets an equal slice of the width
```
