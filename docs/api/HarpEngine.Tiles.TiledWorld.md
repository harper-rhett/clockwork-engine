# <a id="HarpEngine_Tiles_TiledWorld"></a> Class TiledWorld

Namespace: [HarpEngine.Tiles](HarpEngine.Tiles.md)  
Assembly: HarpEngine.dll  

```csharp
public class TiledWorld : Entity
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](HarpEngine.Entity.md) ← 
[TiledWorld](HarpEngine.Tiles.TiledWorld.md)

#### Inherited Members

[Entity.Scene](HarpEngine.Entity.md\#HarpEngine\_Entity\_Scene), 
[Entity.IsUpdating](HarpEngine.Entity.md\#HarpEngine\_Entity\_IsUpdating), 
[Entity.IsRendering](HarpEngine.Entity.md\#HarpEngine\_Entity\_IsRendering), 
[Entity.UpdateLayer](HarpEngine.Entity.md\#HarpEngine\_Entity\_UpdateLayer), 
[Entity.DrawLayer](HarpEngine.Entity.md\#HarpEngine\_Entity\_DrawLayer), 
[Entity.OnUpdate\(\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_OnUpdate), 
[Entity.OnDraw\(\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_OnDraw), 
[Entity.OnDrawGUI\(\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_OnDrawGUI), 
[Entity.Remove\(\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_Remove), 
[Entity.OnAddedToScene\(\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_OnAddedToScene), 
[Entity.OnRemovedFromScene\(\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_OnRemovedFromScene), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="HarpEngine_Tiles_TiledWorld__ctor_System_Collections_Generic_IEnumerable_HarpEngine_Tiles_TiledArea__System_Int32_"></a> TiledWorld\(IEnumerable<TiledArea\>, int\)

```csharp
public TiledWorld(IEnumerable<TiledArea> areas, int tileSize)
```

#### Parameters

`areas` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[TiledArea](HarpEngine.Tiles.TiledArea.md)\>

`tileSize` [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="HarpEngine_Tiles_TiledWorld_DoesAreaExist_System_Int32_System_Int32_"></a> DoesAreaExist\(int, int\)

```csharp
public bool DoesAreaExist(int pixelX, int pixelY)
```

#### Parameters

`pixelX` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`pixelY` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Tiles_TiledWorld_DoesAreaExist_System_Numerics_Vector2_"></a> DoesAreaExist\(Vector2\)

```csharp
public bool DoesAreaExist(Vector2 pixelPosition)
```

#### Parameters

`pixelPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Tiles_TiledWorld_GetArea_System_Int32_System_Int32_"></a> GetArea\(int, int\)

```csharp
public TiledArea GetArea(int pixelX, int pixelY)
```

#### Parameters

`pixelX` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`pixelY` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [TiledArea](HarpEngine.Tiles.TiledArea.md)

### <a id="HarpEngine_Tiles_TiledWorld_GetArea_System_Numerics_Vector2_"></a> GetArea\(Vector2\)

```csharp
public TiledArea GetArea(Vector2 pixelPosition)
```

#### Parameters

`pixelPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [TiledArea](HarpEngine.Tiles.TiledArea.md)

### <a id="HarpEngine_Tiles_TiledWorld_OnDraw"></a> OnDraw\(\)

```csharp
public override void OnDraw()
```

### <a id="HarpEngine_Tiles_TiledWorld_SnapPosition_System_Int32_System_Int32_"></a> SnapPosition\(int, int\)

```csharp
public Vector2 SnapPosition(int pixelX, int pixelY)
```

#### Parameters

`pixelX` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`pixelY` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

