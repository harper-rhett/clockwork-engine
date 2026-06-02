# Tiled Collider

> `using Clockwork.Tiles`

The `TiledCollider` was created with platforming in mind. It is a generic class that works with your tile type enum, and can be used alongside tiled game areas to query for specific types of collisions most useful for platforming. Primarily, inner collisions and side collisions.

```csharp
TiledCollider<TileType> collider = new(playerWidth, playerHeight);
```

The collider must be updated with `CaptureState` before making collision checks. This samples the tiles around the collider's position:

```csharp
collider.CaptureState(gameArea, playerPosition);
```

After capturing state, you can check which tile types are touching each side:

```csharp
bool standingOnGround = collider.IsTileBottom(TileType.Solid);
bool hittingWallLeft = collider.IsTileLeft(TileType.Solid);
bool insideLadder = collider.IsTileInner(TileType.Ladder);
```

The collider also exposes pixel coordinates for each side (`LeftX`, `RightX`, `TopY`, `BottomY`, `CenterX`, `CenterY`), the center tile type, and bounds information for each direction. There's a `Draw` method for debug visualization:

```csharp
collider.Draw(playerPosition, Colors.Green);
```