# Randomization

> `using Clockwork.Utilities;`

C#'s random class is lacking in many features. Especially for a game engine. So, Clockwork reinvents this system. For example, to generate a random unit `Vector2`:

```csharp
Vector2 launchDirection = Generate.UnitVector2();
```

Or to generate random degrees from 0 to 360, which is almost silly but still saves enough boilerplate to be worth it:

```csharp
float degrees = Generate.Degrees();
```

And if you need more control over the generation, you can either change the seed of the `Generate` class or use the `Seed` class:

```csharp
Seed seed = new(12345);
bool isEvil = seed.NextBool();
```