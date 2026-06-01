# Graphs

> `using Clockwork.Graphs;`

Clockwork includes a basic data visualization system, currently featuring a scatter plot. This is useful for debugging, simulations, and visualizing data in real time.

> **Note:** Graphs are an early, minimal feature. Only `ScatterPlot` exists today, and its styling options are limited. More chart types and customization are planned.

## ScatterPlot

`ScatterPlot` is an entity that implements `ICollection<Vector2>`, so you can add and remove data points just like a list:

```csharp
ScatterPlot plot = scene.AddEntity(new ScatterPlot("Generation", "Fitness"));
plot.Position = new Vector2(10, 10);
plot.Width = 200;
plot.Height = 150;
plot.PointRadius = 2;
plot.FontSize = 10;
```

Adding data is straightforward:

```csharp
plot.Add(new Vector2(generation, bestFitness));
```

The plot automatically calculates its visible range from the data. You can query the range at any time:

```csharp
float xRange = plot.HorizontalRange;
float yRange = plot.VerticalRange;
float maxFitness = plot.MaxYPoint;
```

Since it implements `ICollection<Vector2>`, you can also `Clear()`, `Remove()`, check `Count`, and iterate through points with `foreach`.
