# <a id="HarpEngine_Shapes_RectangleShape"></a> Class RectangleShape

Namespace: [HarpEngine.Shapes](HarpEngine.Shapes.md)  
Assembly: HarpEngine.dll  

```csharp
public class RectangleShape : Entity, ITransform2D, IIntersectsWithPoint, IIntersectsWithCircle, IIntersectsWithRectangle, IIntersectsWithLine
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](HarpEngine.Entity.md) ← 
[RectangleShape](HarpEngine.Shapes.RectangleShape.md)

#### Implements

[ITransform2D](HarpEngine.Utilities.ITransform2D.md), 
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

### <a id="HarpEngine_Shapes_RectangleShape__ctor_System_Int32_System_Int32_HarpEngine_Graphics_Color_"></a> RectangleShape\(int, int, Color\)

```csharp
public RectangleShape(int width, int height, Color color)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`color` [Color](HarpEngine.Graphics.Color.md)

## Fields

### <a id="HarpEngine_Shapes_RectangleShape_Color"></a> Color

```csharp
public Color Color
```

#### Field Value

 [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Shapes_RectangleShape_Height"></a> Height

```csharp
public int Height
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Shapes_RectangleShape_Origin"></a> Origin

```csharp
public Vector2 Origin
```

#### Field Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="HarpEngine_Shapes_RectangleShape_Width"></a> Width

```csharp
public int Width
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="HarpEngine_Shapes_RectangleShape_Rectangle"></a> Rectangle

```csharp
public Rectangle Rectangle { get; }
```

#### Property Value

 [Rectangle](HarpEngine.Graphics.Rectangle.md)

### <a id="HarpEngine_Shapes_RectangleShape_Transform"></a> Transform

```csharp
public Transform2D Transform { get; set; }
```

#### Property Value

 [Transform2D](HarpEngine.Utilities.Transform2D.md)

## Methods

### <a id="HarpEngine_Shapes_RectangleShape_IntersectsWithCircle_System_Numerics_Vector2_System_Single_"></a> IntersectsWithCircle\(Vector2, float\)

```csharp
public bool IntersectsWithCircle(Vector2 circlePosition, float circleRadius)
```

#### Parameters

`circlePosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`circleRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Shapes_RectangleShape_IntersectsWithLine_System_Numerics_Vector2_System_Numerics_Vector2_"></a> IntersectsWithLine\(Vector2, Vector2\)

```csharp
public bool IntersectsWithLine(Vector2 lineStartPosition, Vector2 lineEndPosition)
```

#### Parameters

`lineStartPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`lineEndPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Shapes_RectangleShape_IntersectsWithPoint_System_Numerics_Vector2_"></a> IntersectsWithPoint\(Vector2\)

```csharp
public bool IntersectsWithPoint(Vector2 position)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Shapes_RectangleShape_IntersectsWithRectangle_HarpEngine_Graphics_Rectangle_"></a> IntersectsWithRectangle\(Rectangle\)

```csharp
public bool IntersectsWithRectangle(Rectangle rectangle)
```

#### Parameters

`rectangle` [Rectangle](HarpEngine.Graphics.Rectangle.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Shapes_RectangleShape_OnDraw"></a> OnDraw\(\)

```csharp
public override void OnDraw()
```

