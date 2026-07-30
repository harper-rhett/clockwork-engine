# Simulation

> `using Clockwork.Simulation;`

The simulation namespace contains tools for physics-based motion. Right now that means Verlet integration, which is a simple and stable way to simulate ropes, chains, cloth, and other soft bodies.

The system is built from two pieces:

- `VerletJoint`: A point mass. It extends [`CircleShape`](../shapes/shapes.md), moves according to its velocity each frame, and slows over time based on its `Damping`.
- `VerletBone`: A constraint between two joints. It extends [`LineShape`](../shapes/shapes.md) and tries to hold its two joints a fixed distance apart.

## Verlet Joints

A joint is just a movable point with velocity. Add velocity to push it around — gravity, wind, an explosion, whatever you like:

```csharp
VerletJoint joint = scene.AddEntity(new VerletJoint(radius, Colors.White));
joint.Damping = 0.98f; // loses 2% of velocity each step
joint.AddVelocity(new Vector2(0, gravity * FrameTime));
```

Joints update themselves once added to the scene, so you don't have to move them manually.

## Verlet Bones

A bone connects two joints and keeps them roughly `DesiredLength` apart, where the desired length is the distance between the joints when the bone is created. The `tolerance` controls how much slack is allowed before the bone corrects itself:

```csharp
VerletJoint anchor = scene.AddEntity(new VerletJoint(radius, Colors.Gray));
VerletJoint weight = scene.AddEntity(new VerletJoint(radius, Colors.White));
VerletBone bone = scene.AddEntity(new VerletBone(anchor, weight, tolerance, thickness, Colors.Gray));
```

Call `Tighten()` to enforce the constraint. Each call nudges the joints back toward their desired distance, so calling it during the update loop keeps the structure together.

## A Rope

Putting it together, a rope is a chain of joints connected by bones. Anchor the first joint, apply gravity to the rest, and tighten every bone each frame:

```csharp
public class Rope : Entity
{
	private List<VerletJoint> joints = new();
	private List<VerletBone> bones = new();
	private const float gravity = 980f;

	public Rope(Vector2 origin, int segments, float segmentLength)
	{
		// Create the joints
		for (int index = 0; index < segments; index++)
		{
			VerletJoint joint = new(2f, Colors.White);
			joint.Position = origin + new Vector2(0, index * segmentLength);
			joints.Add(joint);
		}

		// Connect them with bones
		for (int index = 0; index < segments - 1; index++)
		{
			VerletBone bone = new(joints[index], joints[index + 1], 0.1f, 1f, Colors.Gray);
			bones.Add(bone);
		}
	}

	public override void OnAddedToScene()
	{
		foreach (VerletJoint joint in joints) Scene.AddEntity(joint);
		foreach (VerletBone bone in bones) Scene.AddEntity(bone);
	}

	public override void OnUpdate()
	{
		// Apply gravity to every joint except the anchor
		for (int index = 1; index < joints.Count; index++)
			joints[index].AddVelocity(new Vector2(0, gravity * FrameTime));

		// Pin the first joint in place
		joints[0].Velocity = Vector2.Zero;

		// Hold the rope together
		foreach (VerletBone bone in bones) bone.Tighten();
	}
}
```

Because joints and bones are themselves shapes, they draw automatically and can be used in [intersection](../shapes/intersections.md) tests. A bone also exposes its `CenterPosition`, `StartPosition`, and `EndPosition`, which is convenient for attaching sprites or running collision checks along its length.
