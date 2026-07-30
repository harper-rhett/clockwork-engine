# <a id="Clockwork_Tiles_TiledLayer"></a> Class TiledLayer

Namespace: [Clockwork.Tiles](Clockwork.Tiles.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class TiledLayer : TiledLayer<TiledArea>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Clockwork.Entity.md) ← 
[TiledLayer<TiledArea\>](Clockwork.Tiles.TiledLayer\-1.md) ← 
[TiledLayer](Clockwork.Tiles.TiledLayer.md)

#### Inherited Members

[TiledLayer<TiledArea\>.AddArea\(TiledArea\)](Clockwork.Tiles.TiledLayer\-1.md\#Clockwork\_Tiles\_TiledLayer\_1\_AddArea\_Clockwork\_Tiles\_TiledArea\_), 
[TiledLayer<TiledArea\>.OnDraw\(\)](Clockwork.Tiles.TiledLayer\-1.md\#Clockwork\_Tiles\_TiledLayer\_1\_OnDraw), 
[TiledLayer<TiledArea\>.DoesAreaExist\(int, int\)](Clockwork.Tiles.TiledLayer\-1.md\#Clockwork\_Tiles\_TiledLayer\_1\_DoesAreaExist\_System\_Int32\_System\_Int32\_), 
[TiledLayer<TiledArea\>.DoesAreaExist\(Vector2\)](Clockwork.Tiles.TiledLayer\-1.md\#Clockwork\_Tiles\_TiledLayer\_1\_DoesAreaExist\_System\_Numerics\_Vector2\_), 
[TiledLayer<TiledArea\>.GetArea\(int, int\)](Clockwork.Tiles.TiledLayer\-1.md\#Clockwork\_Tiles\_TiledLayer\_1\_GetArea\_System\_Int32\_System\_Int32\_), 
[TiledLayer<TiledArea\>.GetArea\(Vector2\)](Clockwork.Tiles.TiledLayer\-1.md\#Clockwork\_Tiles\_TiledLayer\_1\_GetArea\_System\_Numerics\_Vector2\_), 
[TiledLayer<TiledArea\>.SnapPosition\(int, int\)](Clockwork.Tiles.TiledLayer\-1.md\#Clockwork\_Tiles\_TiledLayer\_1\_SnapPosition\_System\_Int32\_System\_Int32\_), 
[TiledLayer<TiledArea\>.SnapPosition\(Vector2\)](Clockwork.Tiles.TiledLayer\-1.md\#Clockwork\_Tiles\_TiledLayer\_1\_SnapPosition\_System\_Numerics\_Vector2\_), 
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

### <a id="Clockwork_Tiles_TiledLayer__ctor_System_Int32_"></a> TiledLayer\(int\)

```csharp
public TiledLayer(int tileSize)
```

#### Parameters

`tileSize` [int](https://learn.microsoft.com/dotnet/api/system.int32)

