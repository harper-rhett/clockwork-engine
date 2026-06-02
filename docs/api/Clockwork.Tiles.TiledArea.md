# <a id="Clockwork_Tiles_TiledArea"></a> Class TiledArea

Namespace: [Clockwork.Tiles](Clockwork.Tiles.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class TiledArea
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TiledArea](Clockwork.Tiles.TiledArea.md)

#### Derived

[TiledGameArea](Clockwork.Tiles.TiledGameArea.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Clockwork_Tiles_TiledArea__ctor_System_Numerics_Vector2_System_Int32_System_Int32_System_Int32_"></a> TiledArea\(Vector2, int, int, int\)

```csharp
public TiledArea(Vector2 position, int widthInTiles, int heightInTiles, int tileSize)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`widthInTiles` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`heightInTiles` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`tileSize` [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Fields

### <a id="Clockwork_Tiles_TiledArea_HeightInPixels"></a> HeightInPixels

```csharp
public readonly int HeightInPixels
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Tiles_TiledArea_HeightInTiles"></a> HeightInTiles

```csharp
public readonly int HeightInTiles
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Tiles_TiledArea_Position"></a> Position

```csharp
public readonly Vector2 Position
```

#### Field Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_Tiles_TiledArea_TileSize"></a> TileSize

```csharp
public readonly int TileSize
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Tiles_TiledArea_WidthInPixels"></a> WidthInPixels

```csharp
public readonly int WidthInPixels
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Tiles_TiledArea_WidthInTiles"></a> WidthInTiles

```csharp
public readonly int WidthInTiles
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Clockwork_Tiles_TiledArea_IsActive"></a> IsActive

```csharp
public virtual bool IsActive { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Tiles_TiledArea_Tiles"></a> Tiles

```csharp
public Tile[] Tiles { set; }
```

#### Property Value

 [Tile](Clockwork.Tiles.Tile.md)\[\]

## Methods

### <a id="Clockwork_Tiles_TiledArea_Draw"></a> Draw\(\)

```csharp
public void Draw()
```

