# <a id="Clockwork_Simulation_VerletJoint"></a> Class VerletJoint

Namespace: [Clockwork.Simulation](Clockwork.Simulation.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class VerletJoint : CircleShape, IIntersectsWithPoint, IIntersectsWithCircle, IIntersectsWithRectangle, IIntersectsWithLine
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Clockwork.Entity.md) ← 
[CircleShape](Clockwork.Shapes.CircleShape.md) ← 
[VerletJoint](Clockwork.Simulation.VerletJoint.md)

#### Implements

[IIntersectsWithPoint](Clockwork.Shapes.IIntersectsWithPoint.md), 
[IIntersectsWithCircle](Clockwork.Shapes.IIntersectsWithCircle.md), 
[IIntersectsWithRectangle](Clockwork.Shapes.IIntersectsWithRectangle.md), 
[IIntersectsWithLine](Clockwork.Shapes.IIntersectsWithLine.md)

#### Inherited Members

[CircleShape.Transform](Clockwork.Shapes.CircleShape.md\#Clockwork\_Shapes\_CircleShape\_Transform), 
[CircleShape.Radius](Clockwork.Shapes.CircleShape.md\#Clockwork\_Shapes\_CircleShape\_Radius), 
[CircleShape.Segments](Clockwork.Shapes.CircleShape.md\#Clockwork\_Shapes\_CircleShape\_Segments), 
[CircleShape.Color](Clockwork.Shapes.CircleShape.md\#Clockwork\_Shapes\_CircleShape\_Color), 
[CircleShape.Position](Clockwork.Shapes.CircleShape.md\#Clockwork\_Shapes\_CircleShape\_Position), 
[CircleShape.Rotation](Clockwork.Shapes.CircleShape.md\#Clockwork\_Shapes\_CircleShape\_Rotation), 
[CircleShape.OnDraw\(\)](Clockwork.Shapes.CircleShape.md\#Clockwork\_Shapes\_CircleShape\_OnDraw), 
[CircleShape.IntersectsWithPoint\(Vector2\)](Clockwork.Shapes.CircleShape.md\#Clockwork\_Shapes\_CircleShape\_IntersectsWithPoint\_System\_Numerics\_Vector2\_), 
[CircleShape.IntersectsWithCircle\(Vector2, float\)](Clockwork.Shapes.CircleShape.md\#Clockwork\_Shapes\_CircleShape\_IntersectsWithCircle\_System\_Numerics\_Vector2\_System\_Single\_), 
[CircleShape.IntersectsWithRectangle\(Rectangle\)](Clockwork.Shapes.CircleShape.md\#Clockwork\_Shapes\_CircleShape\_IntersectsWithRectangle\_Clockwork\_Graphics\_Rectangle\_), 
[CircleShape.IntersectsWithLine\(Vector2, Vector2\)](Clockwork.Shapes.CircleShape.md\#Clockwork\_Shapes\_CircleShape\_IntersectsWithLine\_System\_Numerics\_Vector2\_System\_Numerics\_Vector2\_), 
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

### <a id="Clockwork_Simulation_VerletJoint__ctor_System_Single_Clockwork_Graphics_Color_"></a> VerletJoint\(float, Color\)

```csharp
public VerletJoint(float radius, Color color)
```

#### Parameters

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](Clockwork.Graphics.Color.md)

## Properties

### <a id="Clockwork_Simulation_VerletJoint_Damping"></a> Damping

```csharp
public float Damping { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Simulation_VerletJoint_Velocity"></a> Velocity

```csharp
public Vector2 Velocity { get; set; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

## Methods

### <a id="Clockwork_Simulation_VerletJoint_AddVelocity_System_Numerics_Vector2_"></a> AddVelocity\(Vector2\)

```csharp
public void AddVelocity(Vector2 velocity)
```

#### Parameters

`velocity` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_Simulation_VerletJoint_OnAddedToScene"></a> OnAddedToScene\(\)

```csharp
public override void OnAddedToScene()
```

### <a id="Clockwork_Simulation_VerletJoint_OnUpdate"></a> OnUpdate\(\)

```csharp
public override void OnUpdate()
```

