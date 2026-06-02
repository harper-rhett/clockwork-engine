# <a id="Clockwork_Tiles_TiledGameArea"></a> Class TiledGameArea

Namespace: [Clockwork.Tiles](Clockwork.Tiles.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class TiledGameArea : TiledArea
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TiledArea](Clockwork.Tiles.TiledArea.md) ← 
[TiledGameArea](Clockwork.Tiles.TiledGameArea.md)

#### Inherited Members

[TiledArea.Position](Clockwork.Tiles.TiledArea.md\#Clockwork\_Tiles\_TiledArea\_Position), 
[TiledArea.WidthInTiles](Clockwork.Tiles.TiledArea.md\#Clockwork\_Tiles\_TiledArea\_WidthInTiles), 
[TiledArea.HeightInTiles](Clockwork.Tiles.TiledArea.md\#Clockwork\_Tiles\_TiledArea\_HeightInTiles), 
[TiledArea.WidthInPixels](Clockwork.Tiles.TiledArea.md\#Clockwork\_Tiles\_TiledArea\_WidthInPixels), 
[TiledArea.HeightInPixels](Clockwork.Tiles.TiledArea.md\#Clockwork\_Tiles\_TiledArea\_HeightInPixels), 
[TiledArea.TileSize](Clockwork.Tiles.TiledArea.md\#Clockwork\_Tiles\_TiledArea\_TileSize), 
[TiledArea.IsActive](Clockwork.Tiles.TiledArea.md\#Clockwork\_Tiles\_TiledArea\_IsActive), 
[TiledArea.Tiles](Clockwork.Tiles.TiledArea.md\#Clockwork\_Tiles\_TiledArea\_Tiles), 
[TiledArea.Draw\(\)](Clockwork.Tiles.TiledArea.md\#Clockwork\_Tiles\_TiledArea\_Draw), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Clockwork_Tiles_TiledGameArea__ctor_System_Numerics_Vector2_System_Int32_System_Int32_System_Int32_"></a> TiledGameArea\(Vector2, int, int, int\)

```csharp
public TiledGameArea(Vector2 position, int widthInTiles, int heightInTiles, int tileSize)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`widthInTiles` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`heightInTiles` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`tileSize` [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Clockwork_Tiles_TiledGameArea_IsActive"></a> IsActive

```csharp
public override bool IsActive { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Tiles_TiledGameArea_RegisteredAreas"></a> RegisteredAreas

```csharp
public IReadOnlyList<TiledArea> RegisteredAreas { get; }
```

#### Property Value

 [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<[TiledArea](Clockwork.Tiles.TiledArea.md)\>

### <a id="Clockwork_Tiles_TiledGameArea_RegisteredEntities"></a> RegisteredEntities

```csharp
public IReadOnlyList<Entity> RegisteredEntities { get; }
```

#### Property Value

 [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<[Entity](Clockwork.Entity.md)\>

### <a id="Clockwork_Tiles_TiledGameArea_TilesByID"></a> TilesByID

```csharp
public int[,] TilesByID { set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)\[,\]

## Methods

### <a id="Clockwork_Tiles_TiledGameArea_GetTileLocalCoordinate_System_Int32_System_Int32_"></a> GetTileLocalCoordinate\(int, int\)

```csharp
public Coordinate GetTileLocalCoordinate(int pixelX, int pixelY)
```

#### Parameters

`pixelX` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`pixelY` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [Coordinate](Clockwork.Utilities.Coordinate.md)

### <a id="Clockwork_Tiles_TiledGameArea_GetTileType__1_System_Int32_System_Int32_"></a> GetTileType<TileType\>\(int, int\)

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

### <a id="Clockwork_Tiles_TiledGameArea_GetTileTypeID_System_Int32_System_Int32_"></a> GetTileTypeID\(int, int\)

```csharp
public int GetTileTypeID(int pixelX, int pixelY)
```

#### Parameters

`pixelX` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`pixelY` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Tiles_TiledGameArea_InBounds_System_Int32_System_Int32_"></a> InBounds\(int, int\)

```csharp
public bool InBounds(int pixelX, int pixelY)
```

#### Parameters

`pixelX` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`pixelY` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Tiles_TiledGameArea_RegisterArea_Clockwork_Tiles_TiledArea_"></a> RegisterArea\(TiledArea\)

```csharp
public void RegisterArea(TiledArea area)
```

#### Parameters

`area` [TiledArea](Clockwork.Tiles.TiledArea.md)

### <a id="Clockwork_Tiles_TiledGameArea_RegisterEntity_Clockwork_Entity_"></a> RegisterEntity\(Entity\)

```csharp
public void RegisterEntity(Entity entity)
```

#### Parameters

`entity` [Entity](Clockwork.Entity.md)

### <a id="Clockwork_Tiles_TiledGameArea_UnregisterArea_Clockwork_Tiles_TiledArea_"></a> UnregisterArea\(TiledArea\)

```csharp
public void UnregisterArea(TiledArea area)
```

#### Parameters

`area` [TiledArea](Clockwork.Tiles.TiledArea.md)

### <a id="Clockwork_Tiles_TiledGameArea_UnregisterEntity_Clockwork_Entity_"></a> UnregisterEntity\(Entity\)

```csharp
public void UnregisterEntity(Entity entity)
```

#### Parameters

`entity` [Entity](Clockwork.Entity.md)

