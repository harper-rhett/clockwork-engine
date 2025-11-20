# <a id="HarpEngine_Tiles_TiledArea"></a> Class TiledArea

Namespace: [HarpEngine.Tiles](HarpEngine.Tiles.md)  
Assembly: HarpEngine.dll  

```csharp
public class TiledArea
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TiledArea](HarpEngine.Tiles.TiledArea.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="HarpEngine_Tiles_TiledArea__ctor_System_Numerics_Vector2_System_Int32_System_Int32_System_Int32_"></a> TiledArea\(Vector2, int, int, int\)

```csharp
public TiledArea(Vector2 position, int widthInTiles, int heightInTiles, int tileSize)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`widthInTiles` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`heightInTiles` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`tileSize` [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Fields

### <a id="HarpEngine_Tiles_TiledArea_HeightInPixels"></a> HeightInPixels

```csharp
public readonly int HeightInPixels
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Tiles_TiledArea_HeightInTiles"></a> HeightInTiles

```csharp
public readonly int HeightInTiles
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Tiles_TiledArea_Position"></a> Position

```csharp
public readonly Vector2 Position
```

#### Field Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="HarpEngine_Tiles_TiledArea_TileSize"></a> TileSize

```csharp
public readonly int TileSize
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Tiles_TiledArea_WidthInPixels"></a> WidthInPixels

```csharp
public readonly int WidthInPixels
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Tiles_TiledArea_WidthInTiles"></a> WidthInTiles

```csharp
public readonly int WidthInTiles
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="HarpEngine_Tiles_TiledArea_Tiles"></a> Tiles

```csharp
public Tile[] Tiles { set; }
```

#### Property Value

 [Tile](HarpEngine.Tiles.Tile.md)\[\]

### <a id="HarpEngine_Tiles_TiledArea_TilesByID"></a> TilesByID

```csharp
public int[,] TilesByID { set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)\[,\]

## Methods

### <a id="HarpEngine_Tiles_TiledArea_Draw"></a> Draw\(\)

```csharp
public void Draw()
```

### <a id="HarpEngine_Tiles_TiledArea_GetTileLocalCoordinate_System_Int32_System_Int32_"></a> GetTileLocalCoordinate\(int, int\)

```csharp
public Coordinate GetTileLocalCoordinate(int pixelX, int pixelY)
```

#### Parameters

`pixelX` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`pixelY` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [Coordinate](HarpEngine.Utilities.Coordinate.md)

### <a id="HarpEngine_Tiles_TiledArea_GetTileType__1_System_Int32_System_Int32_"></a> GetTileType<TileType\>\(int, int\)

```csharp
public TileType GetTileType<TileType>(int pixelX, int pixelY) where TileType : Enum
```

#### Parameters

`pixelX` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`pixelY` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 TileType

#### Type Parameters

`TileType` 

### <a id="HarpEngine_Tiles_TiledArea_GetTileTypeID_System_Int32_System_Int32_"></a> GetTileTypeID\(int, int\)

```csharp
public int GetTileTypeID(int pixelX, int pixelY)
```

#### Parameters

`pixelX` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`pixelY` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Tiles_TiledArea_InBounds_System_Int32_System_Int32_"></a> InBounds\(int, int\)

```csharp
public bool InBounds(int pixelX, int pixelY)
```

#### Parameters

`pixelX` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`pixelY` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

