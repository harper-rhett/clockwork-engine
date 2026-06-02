# Tiled Area

> `using Clockwork.Tiles`

A `TiledArea` is like a level for your tiled game. You must populate it with tiles, and the tiles will automatically be rendered to a texture. You may then draw and query your tiles with ease.

```csharp
TiledArea area = new(position, widthInTiles, heightInTiles, tileSize);
area.Tiles = myTileArray; // renders tiles to an internal texture
area.IsActive = true;
```

The area exposes useful size information: `WidthInTiles`, `HeightInTiles`, `WidthInPixels`, `HeightInPixels`, and `TileSize`.

## TiledGameArea

`TiledGameArea` extends `TiledArea` with game-specific functionality. It adds tile type lookups, bounds checking, and entity/area registration:

```csharp
TiledGameArea gameArea = new(position, widthInTiles, heightInTiles, tileSize);
gameArea.TilesByID = tileIDGrid; // int[,] of tile type IDs

bool inBounds = gameArea.InBounds(pixelX, pixelY);
MyTileType tileType = gameArea.GetTileType<MyTileType>(pixelX, pixelY);
```

Entities can be registered to a `TiledGameArea`, which ties their `IsUpdating` and `IsDrawing` to the area's `IsActive` state. When a registered entity is removed from the scene, it automatically unregisters:

```csharp
gameArea.RegisterEntity(myEnemy);
gameArea.IsActive = false; // disables all registered entities
```

Sub-areas (like decoration layers) can also be registered:

```csharp
gameArea.RegisterArea(foregroundDecoration);
```