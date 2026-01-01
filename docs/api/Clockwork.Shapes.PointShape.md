# <a id="Clockwork_Shapes_PointShape"></a> Class PointShape

Namespace: [Clockwork.Shapes](Clockwork.Shapes.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class PointShape : Entity, IIntersectsWithCircle, IIntersectsWithRectangle, IIntersectsWithLine
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Clockwork.Entity.md) ← 
[PointShape](Clockwork.Shapes.PointShape.md)

#### Implements

[IIntersectsWithCircle](Clockwork.Shapes.IIntersectsWithCircle.md), 
[IIntersectsWithRectangle](Clockwork.Shapes.IIntersectsWithRectangle.md), 
[IIntersectsWithLine](Clockwork.Shapes.IIntersectsWithLine.md)

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

### <a id="Clockwork_Shapes_PointShape__ctor_Clockwork_Graphics_Color_"></a> PointShape\(Color\)

```csharp
public PointShape(Color color)
```

#### Parameters

`color` [Color](Clockwork.Graphics.Color.md)

## Fields

### <a id="Clockwork_Shapes_PointShape_Color"></a> Color

```csharp
public Color Color
```

#### Field Value

 [Color](Clockwork.Graphics.Color.md)

## Properties

### <a id="Clockwork_Shapes_PointShape_Transform"></a> Transform

```csharp
public Transform2D Transform { get; set; }
```

#### Property Value

 [Transform2D](Clockwork.Utilities.Transform2D.md)

## Methods

### <a id="Clockwork_Shapes_PointShape_IntersectsWithCircle_System_Numerics_Vector2_System_Single_"></a> IntersectsWithCircle\(Vector2, float\)

```csharp
public bool IntersectsWithCircle(Vector2 circlePosition, float circleRadius)
```

#### Parameters

`circlePosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`circleRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Shapes_PointShape_IntersectsWithLine_System_Numerics_Vector2_System_Numerics_Vector2_"></a> IntersectsWithLine\(Vector2, Vector2\)

```csharp
public bool IntersectsWithLine(Vector2 lineStartPosition, Vector2 lineEndPosition)
```

#### Parameters

`lineStartPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`lineEndPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Shapes_PointShape_IntersectsWithRectangle_Clockwork_Graphics_Rectangle_"></a> IntersectsWithRectangle\(Rectangle\)

```csharp
public bool IntersectsWithRectangle(Rectangle rectangle)
```

#### Parameters

`rectangle` [Rectangle](Clockwork.Graphics.Rectangle.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Shapes_PointShape_OnDraw"></a> OnDraw\(\)

```csharp
public override void OnDraw()
```

