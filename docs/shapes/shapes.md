# Shapes

> `using Clockwork.Shapes;`

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

## Verlet Physics

Clockwork also includes Verlet integration shapes for soft-body physics simulations like ropes and cloth:

- `VerletJoint`: Extends `CircleShape` with velocity-based Verlet integration. Joints move according to their velocity each frame.
- `VerletBone`: Extends `LineShape` and connects two `VerletJoint` instances. Calling `Tighten()` enforces the desired length between joints.

```csharp
VerletJoint jointA = scene.AddEntity(new VerletJoint(radius, Colors.White));
VerletJoint jointB = scene.AddEntity(new VerletJoint(radius, Colors.White));
VerletBone bone = scene.AddEntity(new VerletBone(jointA, jointB, tolerance, thickness, Colors.Gray));
```

To simulate a rope or chain, create a series of joints connected by bones and call `Tighten()` on each bone during the update loop. Apply forces to joints with `AddVelocity()`:

```csharp
joint.AddVelocity(new Vector2(0, gravity * Engine.FrameTime));
```

More on collision detection in the [intersections](intersections.md) section.