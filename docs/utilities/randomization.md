# Randomization

> `using Clockwork.Utilities;`

C#'s random class is lacking in many features. Especially for a game engine. So, Clockwork reinvents this system.

## Generate

The `Generate` class is a static utility for quick random values. For example, to generate a random unit `Vector2`:

```csharp
Vector2 launchDirection = Generate.UnitVector2();
```

Or to generate random degrees from 0 to 360, which is almost silly but still saves enough boilerplate to be worth it:

```csharp
float degrees = Generate.Degrees();
```

There are plenty more methods available:

```csharp
int number = Generate.Integer(0, 100);
float value = Generate.Float(0.5f, 1.5f);
bool coinFlip = Generate.Bool();
bool weighted = Generate.Bool(0.75f); // 75% chance of true
Vector3 direction3D = Generate.UnitVector3();
```

You can also work with collections:

```csharp
Generate.Shuffle(myList);
int randomIndex = Generate.Index(myCollection);
Enemy randomEnemy = Generate.Item(enemies);
```

There are extension method variants too, for a more natural syntax:

```csharp
int index = myCollection.GetRandomIndex();
Enemy enemy = enemies.GetRandomItem();
```

## Seed

If you need deterministic randomization, you can either change the seed of the `Generate` class or use the `Seed` class for independent random streams:

```csharp
Generate.Seed = 42;

Seed seed = new(12345);
bool isEvil = seed.NextBool();
float speed = seed.NextFloat(1f, 5f);
Vector2 direction = seed.NextUnitVector2();
```

`Seed` has all of the same methods as `Generate`, just prefixed with `Next`. This is useful for procedural generation where you want reproducible results.