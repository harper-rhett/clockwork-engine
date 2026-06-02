# Shapes

> `using Clockwork.Shapes;`

> **Example:** See `CollisionExample` in the [examples repository](https://github.com/harper-rhett/clockwork-examples) for shapes used as interactive colliders, and `PolygonExample` for animated polygons.

Primitive shapes can be drawn from `Primitives2D` and `Primitives3D`. Shape entities are similar, but different. They are pre-built entities useful for prototyping that draw themselves.

## 2D Shapes

- `PointShape`
- `CircleShape`
- `LineShape`
- `RectangleShape`
- `PolygonShape`

Use is as simple as this:

```csharp
PolygonShape myPolygon = scene.AddEntity(new PolygonShape(radius, sideCount, color));
myPolygon.Position = customPosition;
```

Most shape entities have a `Transform` for position and rotation, and convenience `Position` and `Rotation` properties that wrap it.

These entities can also be inherited from for more control. Additionally, they have built-in intersection tests, which means you can treat them as colliders through inheritance:

```csharp
public class Player : RectangleShape
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

## 3D Shapes

- `SphereShape`

3D shapes work similarly, but use `Transform3D` instead:

```csharp
SphereShape sphere = scene.AddEntity(new SphereShape(position, radius, Colors.Red));
```

`SphereShape` implements `IIntersectsWithRay`, making it useful for ray-based selection and collision.

## Soft-Body Physics

Shapes also serve as the foundation for Verlet physics. `VerletJoint` and `VerletBone` build on `CircleShape` and `LineShape` to simulate ropes, chains, and cloth. These live in the `Clockwork.Simulation` namespace — see the [simulation](../simulation/simulation.md) docs.

More on collision detection in the [intersections](intersections.md) section.