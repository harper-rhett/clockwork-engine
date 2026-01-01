# <a id="Clockwork_Tiles_TiledCollider_1"></a> Class TiledCollider<TileType\>

Namespace: [Clockwork.Tiles](Clockwork.Tiles.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class TiledCollider<TileType> where TileType : Enum
```

#### Type Parameters

`TileType` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TiledCollider<TileType\>](Clockwork.Tiles.TiledCollider\-1.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Clockwork_Tiles_TiledCollider_1__ctor_System_Int32_System_Int32_"></a> TiledCollider\(int, int\)

```csharp
public TiledCollider(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Fields

### <a id="Clockwork_Tiles_TiledCollider_1_HalfHeight"></a> HalfHeight

```csharp
public readonly int HalfHeight
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Tiles_TiledCollider_1_HalfWidth"></a> HalfWidth

```csharp
public readonly int HalfWidth
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Tiles_TiledCollider_1_Height"></a> Height

```csharp
public readonly int Height
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Tiles_TiledCollider_1_Width"></a> Width

```csharp
public readonly int Width
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Clockwork_Tiles_TiledCollider_1_BottomCenterTile"></a> BottomCenterTile

```csharp
public TileType BottomCenterTile { get; }
```

#### Property Value

 TileType

### <a id="Clockwork_Tiles_TiledCollider_1_BottomInBounds"></a> BottomInBounds

```csharp
public bool BottomInBounds { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Tiles_TiledCollider_1_BottomY"></a> BottomY

```csharp
public int BottomY { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Tiles_TiledCollider_1_CenterInBounds"></a> CenterInBounds

```csharp
public bool CenterInBounds { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Tiles_TiledCollider_1_CenterTile"></a> CenterTile

```csharp
public TileType CenterTile { get; }
```

#### Property Value

 TileType

### <a id="Clockwork_Tiles_TiledCollider_1_CenterX"></a> CenterX

```csharp
public int CenterX { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Tiles_TiledCollider_1_CenterY"></a> CenterY

```csharp
public int CenterY { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Tiles_TiledCollider_1_LeftCenterTile"></a> LeftCenterTile

```csharp
public TileType LeftCenterTile { get; }
```

#### Property Value

 TileType

### <a id="Clockwork_Tiles_TiledCollider_1_LeftInBounds"></a> LeftInBounds

```csharp
public bool LeftInBounds { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Tiles_TiledCollider_1_LeftX"></a> LeftX

```csharp
public int LeftX { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Tiles_TiledCollider_1_RightCenterTile"></a> RightCenterTile

```csharp
public TileType RightCenterTile { get; }
```

#### Property Value

 TileType

### <a id="Clockwork_Tiles_TiledCollider_1_RightInBounds"></a> RightInBounds

```csharp
public bool RightInBounds { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Tiles_TiledCollider_1_RightX"></a> RightX

```csharp
public int RightX { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Tiles_TiledCollider_1_TopCenterTile"></a> TopCenterTile

```csharp
public TileType TopCenterTile { get; }
```

#### Property Value

 TileType

### <a id="Clockwork_Tiles_TiledCollider_1_TopInBounds"></a> TopInBounds

```csharp
public bool TopInBounds { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Tiles_TiledCollider_1_TopY"></a> TopY

```csharp
public int TopY { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Clockwork_Tiles_TiledCollider_1_Draw_System_Numerics_Vector2_Clockwork_Graphics_Color_"></a> Draw\(Vector2, Color\)

```csharp
public void Draw(Vector2 position, Color color)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`color` [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Tiles_TiledCollider_1_IsTileBottom__0_"></a> IsTileBottom\(TileType\)

```csharp
public bool IsTileBottom(TileType tileType)
```

#### Parameters

`tileType` TileType

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Tiles_TiledCollider_1_IsTileInner__0_"></a> IsTileInner\(TileType\)

```csharp
public bool IsTileInner(TileType tileType)
```

#### Parameters

`tileType` TileType

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Tiles_TiledCollider_1_IsTileLeft__0_"></a> IsTileLeft\(TileType\)

```csharp
public bool IsTileLeft(TileType tileType)
```

#### Parameters

`tileType` TileType

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Tiles_TiledCollider_1_IsTileRight__0_"></a> IsTileRight\(TileType\)

```csharp
public bool IsTileRight(TileType tileType)
```

#### Parameters

`tileType` TileType

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Tiles_TiledCollider_1_IsTileTop__0_"></a> IsTileTop\(TileType\)

```csharp
public bool IsTileTop(TileType tileType)
```

#### Parameters

`tileType` TileType

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Tiles_TiledCollider_1_Update_Clockwork_Tiles_TiledArea_System_Numerics_Vector2_"></a> Update\(TiledArea, Vector2\)

```csharp
public void Update(TiledArea area, Vector2 position)
```

#### Parameters

`area` [TiledArea](Clockwork.Tiles.TiledArea.md)

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

