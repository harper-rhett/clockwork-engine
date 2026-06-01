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

You can also generate a random position inside a region, which is handy for scattering things across the screen or within a bounding box:

```csharp
Vector2 spawn = Generate.Vector2(0, 0, Engine.GameWidth, Engine.GameHeight);
Vector2 inBounds = Generate.Vector2(areaRectangle); // within a Rectangle
```

And you can work with collections:

```csharp
Generate.Shuffle(myList);                  // shuffle in place
List<Enemy> shuffled = Generate.GetShuffled(enemies); // shuffled copy
int randomIndex = Generate.Index(myCollection);
Enemy randomEnemy = Generate.Item(enemies);
Generate.RemoveItem(enemies);              // remove a random item
```

Most collection methods have extension variants too, for a more natural syntax:

```csharp
myList.Shuffle();
int index = myCollection.GetRandomIndex();
Enemy enemy = enemies.GetRandomItem();
enemies.RemoveRandomItem();
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

`Seed` mirrors `Generate`, with method names prefixed by `Next` (`NextInteger`, `NextFloat`, `NextVector2`, `NextItem`, and so on). This is useful for procedural generation where you want reproducible results — the same seed always produces the same sequence:

```csharp
Seed seed = new(worldSeed);
Vector2 treePosition = seed.NextVector2(mapBounds);
Biome biome = seed.NextItem(biomes);
```