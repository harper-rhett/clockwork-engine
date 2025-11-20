# <a id="HarpEngine_Shapes_LineShape"></a> Class LineShape

Namespace: [HarpEngine.Shapes](HarpEngine.Shapes.md)  
Assembly: HarpEngine.dll  

```csharp
public class LineShape : Entity, IIntersectsWithPoint, IIntersectsWithCircle, IIntersectsWithRectangle, IIntersectsWithLine
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](HarpEngine.Entity.md) ← 
[LineShape](HarpEngine.Shapes.LineShape.md)

#### Implements

[IIntersectsWithPoint](HarpEngine.Shapes.IIntersectsWithPoint.md), 
[IIntersectsWithCircle](HarpEngine.Shapes.IIntersectsWithCircle.md), 
[IIntersectsWithRectangle](HarpEngine.Shapes.IIntersectsWithRectangle.md), 
[IIntersectsWithLine](HarpEngine.Shapes.IIntersectsWithLine.md)

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

### <a id="HarpEngine_Shapes_LineShape__ctor_System_Single_HarpEngine_Graphics_Color_"></a> LineShape\(float, Color\)

```csharp
public LineShape(float thickness, Color color)
```

#### Parameters

`thickness` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](HarpEngine.Graphics.Color.md)

## Fields

### <a id="HarpEngine_Shapes_LineShape_Color"></a> Color

```csharp
public Color Color
```

#### Field Value

 [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Shapes_LineShape_EndPosition"></a> EndPosition

```csharp
public Vector2 EndPosition
```

#### Field Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="HarpEngine_Shapes_LineShape_StartPosition"></a> StartPosition

```csharp
public Vector2 StartPosition
```

#### Field Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="HarpEngine_Shapes_LineShape_Thickness"></a> Thickness

```csharp
public float Thickness
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="HarpEngine_Shapes_LineShape_IntersectsWithCircle_System_Numerics_Vector2_System_Single_"></a> IntersectsWithCircle\(Vector2, float\)

```csharp
public bool IntersectsWithCircle(Vector2 circlePosition, float circleRadius)
```

#### Parameters

`circlePosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`circleRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Shapes_LineShape_IntersectsWithLine_System_Numerics_Vector2_System_Numerics_Vector2_"></a> IntersectsWithLine\(Vector2, Vector2\)

```csharp
public bool IntersectsWithLine(Vector2 lineStartPosition, Vector2 lineEndPosition)
```

#### Parameters

`lineStartPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`lineEndPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Shapes_LineShape_IntersectsWithPoint_System_Numerics_Vector2_"></a> IntersectsWithPoint\(Vector2\)

```csharp
public bool IntersectsWithPoint(Vector2 pointPosition)
```

#### Parameters

`pointPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Shapes_LineShape_IntersectsWithRectangle_HarpEngine_Graphics_Rectangle_"></a> IntersectsWithRectangle\(Rectangle\)

```csharp
public bool IntersectsWithRectangle(Rectangle rectangle)
```

#### Parameters

`rectangle` [Rectangle](HarpEngine.Graphics.Rectangle.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Shapes_LineShape_OnDraw"></a> OnDraw\(\)

```csharp
public override void OnDraw()
```

