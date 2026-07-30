# <a id="Clockwork_Tiles_TiledLayer_1"></a> Class TiledLayer<TiledAreaType\>

Namespace: [Clockwork.Tiles](Clockwork.Tiles.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class TiledLayer<TiledAreaType> : Entity where TiledAreaType : TiledArea
```

#### Type Parameters

`TiledAreaType` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Clockwork.Entity.md) ← 
[TiledLayer<TiledAreaType\>](Clockwork.Tiles.TiledLayer\-1.md)

#### Inherited Members

[Entity.Scene](Clockwork.Entity.md\#Clockwork\_Entity\_Scene), 
[Entity.IsUpdating](Clockwork.Entity.md\#Clockwork\_Entity\_IsUpdating), 
[Entity.IsDrawing](Clockwork.Entity.md\#Clockwork\_Entity\_IsDrawing), 
[Entity.Removed](Clockwork.Entity.md\#Clockwork\_Entity\_Removed), 
[Entity.IsInScene](Clockwork.Entity.md\#Clockwork\_Entity\_IsInScene), 
[Entity.FrameTime](Clockwork.Entity.md\#Clockwork\_Entity\_FrameTime), 
[Entity.Time](Clockwork.Entity.md\#Clockwork\_Entity\_Time), 
[Entity.UpdateLayer](Clockwork.Entity.md\#Clockwork\_Entity\_UpdateLayer), 
[Entity.DrawLayer](Clockwork.Entity.md\#Clockwork\_Entity\_DrawLayer), 
[Entity.OnUpdate\(\)](Clockwork.Entity.md\#Clockwork\_Entity\_OnUpdate), 
[Entity.OnDraw\(\)](Clockwork.Entity.md\#Clockwork\_Entity\_OnDraw), 
[Entity.OnDrawGUI\(\)](Clockwork.Entity.md\#Clockwork\_Entity\_OnDrawGUI), 
[Entity.AddToScene\(Scene\)](Clockwork.Entity.md\#Clockwork\_Entity\_AddToScene\_Clockwork\_Scene\_), 
[Entity.RemoveFromScene\(\)](Clockwork.Entity.md\#Clockwork\_Entity\_RemoveFromScene), 
[Entity.OnAddedToScene\(\)](Clockwork.Entity.md\#Clockwork\_Entity\_OnAddedToScene), 
[Entity.OnRemovedFromScene\(\)](Clockwork.Entity.md\#Clockwork\_Entity\_OnRemovedFromScene), 
[Entity.IsVisible\(\)](Clockwork.Entity.md\#Clockwork\_Entity\_IsVisible), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Clockwork_Tiles_TiledLayer_1__ctor_System_Int32_"></a> TiledLayer\(int\)

```csharp
public TiledLayer(int tileSize)
```

#### Parameters

`tileSize` [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Clockwork_Tiles_TiledLayer_1_AddArea_Clockwork_Tiles_TiledArea_"></a> AddArea\(TiledArea\)

```csharp
public void AddArea(TiledArea area)
```

#### Parameters

`area` [TiledArea](Clockwork.Tiles.TiledArea.md)

### <a id="Clockwork_Tiles_TiledLayer_1_DoesAreaExist_System_Int32_System_Int32_"></a> DoesAreaExist\(int, int\)

```csharp
public bool DoesAreaExist(int pixelX, int pixelY)
```

#### Parameters

`pixelX` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`pixelY` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Tiles_TiledLayer_1_DoesAreaExist_System_Numerics_Vector2_"></a> DoesAreaExist\(Vector2\)

```csharp
public bool DoesAreaExist(Vector2 pixelPosition)
```

#### Parameters

`pixelPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Tiles_TiledLayer_1_GetArea_System_Int32_System_Int32_"></a> GetArea\(int, int\)

```csharp
public TiledAreaType GetArea(int pixelX, int pixelY)
```

#### Parameters

`pixelX` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`pixelY` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 TiledAreaType

### <a id="Clockwork_Tiles_TiledLayer_1_GetArea_System_Numerics_Vector2_"></a> GetArea\(Vector2\)

```csharp
public TiledAreaType GetArea(Vector2 pixelPosition)
```

#### Parameters

`pixelPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 TiledAreaType

### <a id="Clockwork_Tiles_TiledLayer_1_OnDraw"></a> OnDraw\(\)

```csharp
public override void OnDraw()
```

### <a id="Clockwork_Tiles_TiledLayer_1_SnapPosition_System_Int32_System_Int32_"></a> SnapPosition\(int, int\)

```csharp
public Vector2 SnapPosition(int pixelX, int pixelY)
```

#### Parameters

`pixelX` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`pixelY` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_Tiles_TiledLayer_1_SnapPosition_System_Numerics_Vector2_"></a> SnapPosition\(Vector2\)

```csharp
public Vector2 SnapPosition(Vector2 pixelPosition)
```

#### Parameters

`pixelPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

