# <a id="Clockwork_Shapes_PolygonShape"></a> Class PolygonShape

Namespace: [Clockwork.Shapes](Clockwork.Shapes.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class PolygonShape : Entity
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Clockwork.Entity.md) ← 
[PolygonShape](Clockwork.Shapes.PolygonShape.md)

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

### <a id="Clockwork_Shapes_PolygonShape__ctor_System_Single_System_Int32_Clockwork_Graphics_Color_"></a> PolygonShape\(float, int, Color\)

```csharp
public PolygonShape(float radius, int sideCount, Color color)
```

#### Parameters

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`sideCount` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`color` [Color](Clockwork.Graphics.Color.md)

## Fields

### <a id="Clockwork_Shapes_PolygonShape_Color"></a> Color

```csharp
public Color Color
```

#### Field Value

 [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Shapes_PolygonShape_Radius"></a> Radius

```csharp
public float Radius
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Shapes_PolygonShape_SideCount"></a> SideCount

```csharp
public int SideCount
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Clockwork_Shapes_PolygonShape_Position"></a> Position

```csharp
public Vector2 Position { get; set; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_Shapes_PolygonShape_Rotation"></a> Rotation

```csharp
public float Rotation { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Shapes_PolygonShape_Transform"></a> Transform

```csharp
public Transform2D Transform { get; set; }
```

#### Property Value

 [Transform2D](Clockwork.Utilities.Transform2D.md)

## Methods

### <a id="Clockwork_Shapes_PolygonShape_OnDraw"></a> OnDraw\(\)

```csharp
public override void OnDraw()
```

