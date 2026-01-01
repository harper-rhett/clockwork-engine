# Shapes

> `using Clockwork.Shapes;`

Primitive shapes can be drawn from the `Primitives` namespace. Shape entities are similar, but different. They are pre-built entities useful for prototyping that draw themselves.

- Point
- Circle
- Line
- Rectangle
- Polygon

Use is as simple as this:

```csharp
Polygon myPolygon = new(scene, radius, sideCount, color);
myPolygon.Position = customPosition;
```

These entities can also be inherited from for more control. Additionally, they have built in intersection tests, which means you can treat them as colliders through inheritance:

```csharp
public class Player : Rectangle
{
	private GameScene gameScene;
	private int health = 10;

	public Player(GameScene gameScene, int width, int height, Color color) : base(width, height, color)
	{
		this.gameScene = gameScene;
	}

	public override void OnUpdate()
	{
		foreach (Bullet bullet in gameScene.bullets)
		{
			if (IntersectsWithCircle(bullet.Position, bullet.Radius)) health--;
		}
	}
}
```

More on this in [intersections](intersection.md) section.