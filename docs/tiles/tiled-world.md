# Tiled Layer

> `using Clockwork.Tiles`

Let's say you're trying to make a Metroidvania. The first thing you would need is a world to manage your tiled areas or "levels" in. `TiledLayer` is an entity that does that. Add your tiled areas to the layer, add the layer to the scene, and voila! You now have a set of tools for managing your world.

```csharp
TiledLayer world = scene.AddEntity(new TiledLayer(tileSize));
world.AddArea(area);
```

`TiledLayer` contains many useful methods:
- `AddArea(area)` — register an area into the layer
- `DoesAreaExist(pixelX, pixelY)` — check if an area exists at pixel coordinates
- `GetArea(pixelX, pixelY)` — retrieve the area at pixel coordinates
- `SnapPosition(pixelX, pixelY)` — snap a pixel position to the tile grid

All areas in the layer are drawn automatically during the layer's `OnDraw`.

`TiledLayer` is also generic. If you need to work with `TiledGameArea` instances (or your own subclass), use `TiledLayer<TiledGameArea>` and the `GetArea` method will return the correct type:

```csharp
TiledLayer<TiledGameArea> world = scene.AddEntity(new TiledLayer<TiledGameArea>(tileSize));
TiledGameArea area = world.GetArea(pixelX, pixelY);
```

## Building Levels

You can populate tiled areas yourself in code, but for real levels you'll likely want a visual editor. The [LDtk importer](ldtk.md) loads levels authored in [LDtk](https://ldtk.io/) straight into a `TiledLayer`, including tiles and entity placement.