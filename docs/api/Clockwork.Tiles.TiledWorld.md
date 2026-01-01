# <a id="Clockwork_Tiles_TiledWorld"></a> Class TiledWorld

Namespace: [Clockwork.Tiles](Clockwork.Tiles.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class TiledWorld : Entity
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Clockwork.Entity.md) ← 
[TiledWorld](Clockwork.Tiles.TiledWorld.md)

#### Inherited Members

[Entity.Scene](Clockwork.Entity.md\#Clockwork\_Entity\_Scene), 
[Entity.IsUpdating](Clockwork.Entity.md\#Clockwork\_Entity\_IsUpdating), 
[Entity.IsRendering](Clockwork.Entity.md\#Clockwork\_Entity\_IsRendering), 
[Entity.UpdateLayer](Clockwork.Entity.md\#Clockwork\_Entity\_UpdateLayer), 
[Entity.DrawLayer](Clockwork.Entity.md\#Clockwork\_Entity\_DrawLayer), 
[Entity.OnUpdate\(\)](Clockwork.Entity.md\#Clockwork\_Entity\_OnUpdate), 
[Entity.OnDraw\(\)](Clockwork.Entity.md\#Clockwork\_Entity\_OnDraw), 
[Entity.OnDrawGUI\(\)](Clockwork.Entity.md\#Clockwork\_Entity\_OnDrawGUI), 
[Entity.Remove\(\)](Clockwork.Entity.md\#Clockwork\_Entity\_Remove), 
[Entity.OnAddedToScene\(\)](Clockwork.Entity.md\#Clockwork\_Entity\_OnAddedToScene), 
[Entity.OnRemovedFromScene\(\)](Clockwork.Entity.md\#Clockwork\_Entity\_OnRemovedFromScene), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Clockwork_Tiles_TiledWorld__ctor_System_Int32_"></a> TiledWorld\(int\)

```csharp
public TiledWorld(int tileSize)
```

#### Parameters

`tileSize` [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Clockwork_Tiles_TiledWorld_AddArea_Clockwork_Tiles_TiledArea_"></a> AddArea\(TiledArea\)

```csharp
public void AddArea(TiledArea area)
```

#### Parameters

`area` [TiledArea](Clockwork.Tiles.TiledArea.md)

### <a id="Clockwork_Tiles_TiledWorld_AddFocus_Clockwork_Tiles_TiledArea_"></a> AddFocus\(TiledArea\)

```csharp
public void AddFocus(TiledArea focusArea)
```

#### Parameters

`focusArea` [TiledArea](Clockwork.Tiles.TiledArea.md)

### <a id="Clockwork_Tiles_TiledWorld_DoesAreaExist_System_Int32_System_Int32_"></a> DoesAreaExist\(int, int\)

```csharp
public bool DoesAreaExist(int pixelX, int pixelY)
```

#### Parameters

`pixelX` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`pixelY` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Tiles_TiledWorld_DoesAreaExist_System_Numerics_Vector2_"></a> DoesAreaExist\(Vector2\)

```csharp
public bool DoesAreaExist(Vector2 pixelPosition)
```

#### Parameters

`pixelPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Tiles_TiledWorld_GetArea_System_Int32_System_Int32_"></a> GetArea\(int, int\)

```csharp
public TiledArea GetArea(int pixelX, int pixelY)
```

#### Parameters

`pixelX` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`pixelY` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [TiledArea](Clockwork.Tiles.TiledArea.md)

### <a id="Clockwork_Tiles_TiledWorld_GetArea_System_Numerics_Vector2_"></a> GetArea\(Vector2\)

```csharp
public TiledArea GetArea(Vector2 pixelPosition)
```

#### Parameters

`pixelPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [TiledArea](Clockwork.Tiles.TiledArea.md)

### <a id="Clockwork_Tiles_TiledWorld_OnDraw"></a> OnDraw\(\)

```csharp
public override void OnDraw()
```

### <a id="Clockwork_Tiles_TiledWorld_RemoveFocus_Clockwork_Tiles_TiledArea_"></a> RemoveFocus\(TiledArea\)

```csharp
public void RemoveFocus(TiledArea focusArea)
```

#### Parameters

`focusArea` [TiledArea](Clockwork.Tiles.TiledArea.md)

### <a id="Clockwork_Tiles_TiledWorld_SnapPosition_System_Int32_System_Int32_"></a> SnapPosition\(int, int\)

```csharp
public Vector2 SnapPosition(int pixelX, int pixelY)
```

#### Parameters

`pixelX` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`pixelY` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_Tiles_TiledWorld_SnapPosition_System_Numerics_Vector2_"></a> SnapPosition\(Vector2\)

```csharp
public Vector2 SnapPosition(Vector2 pixelPosition)
```

#### Parameters

`pixelPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

