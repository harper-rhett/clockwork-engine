# Tiled World

> `using HarpEngine.Tiles`

Let's say you're trying to make a Metroidvania. The first thing you would need is a world to manage your tiled areas or "levels" in. `TiledWorld` is an entity that does that. Add your tiled areas to the world, add the world to the scene, and viola! You now have a set of tools for managing your world.

`TiledWorld` contains many useful methods:
- `AddArea`
- `DoesAreaExist`
- `GetArea`
- `GetTileCoordinate`
- `SnapPosition`
- Etcetera

Set the "focus area" to determine which area is being actively rendered. The previous focus area will also be drawn for camera transitions. This functionality will likely change soon to support more rendering options.