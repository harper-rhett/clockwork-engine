# <a id="Clockwork_Simulation_VerletBone"></a> Class VerletBone

Namespace: [Clockwork.Simulation](Clockwork.Simulation.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class VerletBone : LineShape, IIntersectsWithPoint, IIntersectsWithCircle, IIntersectsWithRectangle, IIntersectsWithLine
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Clockwork.Entity.md) ← 
[LineShape](Clockwork.Shapes.LineShape.md) ← 
[VerletBone](Clockwork.Simulation.VerletBone.md)

#### Implements

[IIntersectsWithPoint](Clockwork.Shapes.IIntersectsWithPoint.md), 
[IIntersectsWithCircle](Clockwork.Shapes.IIntersectsWithCircle.md), 
[IIntersectsWithRectangle](Clockwork.Shapes.IIntersectsWithRectangle.md), 
[IIntersectsWithLine](Clockwork.Shapes.IIntersectsWithLine.md)

#### Inherited Members

[LineShape.StartPosition](Clockwork.Shapes.LineShape.md\#Clockwork\_Shapes\_LineShape\_StartPosition), 
[LineShape.EndPosition](Clockwork.Shapes.LineShape.md\#Clockwork\_Shapes\_LineShape\_EndPosition), 
[LineShape.Thickness](Clockwork.Shapes.LineShape.md\#Clockwork\_Shapes\_LineShape\_Thickness), 
[LineShape.Color](Clockwork.Shapes.LineShape.md\#Clockwork\_Shapes\_LineShape\_Color), 
[LineShape.OnDraw\(\)](Clockwork.Shapes.LineShape.md\#Clockwork\_Shapes\_LineShape\_OnDraw), 
[LineShape.IntersectsWithPoint\(Vector2\)](Clockwork.Shapes.LineShape.md\#Clockwork\_Shapes\_LineShape\_IntersectsWithPoint\_System\_Numerics\_Vector2\_), 
[LineShape.IntersectsWithCircle\(Vector2, float\)](Clockwork.Shapes.LineShape.md\#Clockwork\_Shapes\_LineShape\_IntersectsWithCircle\_System\_Numerics\_Vector2\_System\_Single\_), 
[LineShape.IntersectsWithRectangle\(Rectangle\)](Clockwork.Shapes.LineShape.md\#Clockwork\_Shapes\_LineShape\_IntersectsWithRectangle\_Clockwork\_Graphics\_Rectangle\_), 
[LineShape.IntersectsWithLine\(Vector2, Vector2\)](Clockwork.Shapes.LineShape.md\#Clockwork\_Shapes\_LineShape\_IntersectsWithLine\_System\_Numerics\_Vector2\_System\_Numerics\_Vector2\_), 
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

### <a id="Clockwork_Simulation_VerletBone__ctor_Clockwork_Simulation_VerletJoint_Clockwork_Simulation_VerletJoint_System_Single_System_Single_Clockwork_Graphics_Color_"></a> VerletBone\(VerletJoint, VerletJoint, float, float, Color\)

```csharp
public VerletBone(VerletJoint firstJoint, VerletJoint secondJoint, float tolerance, float thickness, Color color)
```

#### Parameters

`firstJoint` [VerletJoint](Clockwork.Simulation.VerletJoint.md)

`secondJoint` [VerletJoint](Clockwork.Simulation.VerletJoint.md)

`tolerance` [float](https://learn.microsoft.com/dotnet/api/system.single)

`thickness` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](Clockwork.Graphics.Color.md)

## Fields

### <a id="Clockwork_Simulation_VerletBone_HalfDesiredLength"></a> HalfDesiredLength

```csharp
public float HalfDesiredLength
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Properties

### <a id="Clockwork_Simulation_VerletBone_CenterPosition"></a> CenterPosition

```csharp
public Vector2 CenterPosition { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_Simulation_VerletBone_DesiredLength"></a> DesiredLength

```csharp
public float DesiredLength { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Simulation_VerletBone_EndPosition"></a> EndPosition

```csharp
public override Vector2 EndPosition { get; protected set; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_Simulation_VerletBone_FirstJoint"></a> FirstJoint

```csharp
public VerletJoint FirstJoint { get; }
```

#### Property Value

 [VerletJoint](Clockwork.Simulation.VerletJoint.md)

### <a id="Clockwork_Simulation_VerletBone_SecondJoint"></a> SecondJoint

```csharp
public VerletJoint SecondJoint { get; }
```

#### Property Value

 [VerletJoint](Clockwork.Simulation.VerletJoint.md)

### <a id="Clockwork_Simulation_VerletBone_StartPosition"></a> StartPosition

```csharp
public override Vector2 StartPosition { get; protected set; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

## Methods

### <a id="Clockwork_Simulation_VerletBone_Tighten"></a> Tighten\(\)

```csharp
public void Tighten()
```

