# <a id="Clockwork_Shapes_Intersection"></a> Class Intersection

Namespace: [Clockwork.Shapes](Clockwork.Shapes.md)  
Assembly: ClockworkEngine.dll  

```csharp
public static class Intersection
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Intersection](Clockwork.Shapes.Intersection.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Methods

### <a id="Clockwork_Shapes_Intersection_CircleInCircle_System_Numerics_Vector2_System_Single_System_Numerics_Vector2_System_Single_"></a> CircleInCircle\(Vector2, float, Vector2, float\)

```csharp
public static bool CircleInCircle(Vector2 positionA, float radiusA, Vector2 positionB, float radiusB)
```

#### Parameters

`positionA` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`radiusA` [float](https://learn.microsoft.com/dotnet/api/system.single)

`positionB` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`radiusB` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Shapes_Intersection_CircleInCircleSquared_System_Numerics_Vector2_System_Single_System_Numerics_Vector2_System_Single_"></a> CircleInCircleSquared\(Vector2, float, Vector2, float\)

```csharp
public static bool CircleInCircleSquared(Vector2 positionA, float radiusSquaredA, Vector2 positionB, float radiusSquaredB)
```

#### Parameters

`positionA` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`radiusSquaredA` [float](https://learn.microsoft.com/dotnet/api/system.single)

`positionB` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`radiusSquaredB` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Shapes_Intersection_CircleOnCircle_System_Numerics_Vector2_System_Single_System_Numerics_Vector2_System_Single_"></a> CircleOnCircle\(Vector2, float, Vector2, float\)

```csharp
public static bool CircleOnCircle(Vector2 positionA, float radiusA, Vector2 positionB, float radiusB)
```

#### Parameters

`positionA` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`radiusA` [float](https://learn.microsoft.com/dotnet/api/system.single)

`positionB` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`radiusB` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Shapes_Intersection_CircleOnCircleSquared_System_Numerics_Vector2_System_Single_System_Numerics_Vector2_System_Single_"></a> CircleOnCircleSquared\(Vector2, float, Vector2, float\)

```csharp
public static bool CircleOnCircleSquared(Vector2 positionA, float radiusSquaredA, Vector2 positionB, float radiusSquaredB)
```

#### Parameters

`positionA` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`radiusSquaredA` [float](https://learn.microsoft.com/dotnet/api/system.single)

`positionB` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`radiusSquaredB` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Shapes_Intersection_CircleOnLine_System_Numerics_Vector2_System_Single_System_Numerics_Vector2_System_Numerics_Vector2_"></a> CircleOnLine\(Vector2, float, Vector2, Vector2\)

```csharp
public static bool CircleOnLine(Vector2 circlePosition, float radius, Vector2 lineStartPosition, Vector2 lineEndPosition)
```

#### Parameters

`circlePosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`lineStartPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`lineEndPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Shapes_Intersection_CircleOnRectangle_System_Numerics_Vector2_System_Single_Clockwork_Graphics_Rectangle_"></a> CircleOnRectangle\(Vector2, float, Rectangle\)

```csharp
public static bool CircleOnRectangle(Vector2 circlePosition, float circleRadius, Rectangle rectangle)
```

#### Parameters

`circlePosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`circleRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`rectangle` [Rectangle](Clockwork.Graphics.Rectangle.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Shapes_Intersection_LineOnLine_System_Numerics_Vector2_System_Numerics_Vector2_System_Numerics_Vector2_System_Numerics_Vector2_"></a> LineOnLine\(Vector2, Vector2, Vector2, Vector2\)

```csharp
public static bool LineOnLine(Vector2 startPositionA, Vector2 endPositionA, Vector2 startPositionB, Vector2 endPositionB)
```

#### Parameters

`startPositionA` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`endPositionA` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`startPositionB` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`endPositionB` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Shapes_Intersection_LineOnRectangle_System_Numerics_Vector2_System_Numerics_Vector2_Clockwork_Graphics_Rectangle_"></a> LineOnRectangle\(Vector2, Vector2, Rectangle\)

```csharp
public static bool LineOnRectangle(Vector2 lineStartPosition, Vector2 lineEndPosition, Rectangle rectangle)
```

#### Parameters

`lineStartPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`lineEndPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`rectangle` [Rectangle](Clockwork.Graphics.Rectangle.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Shapes_Intersection_PointInCircle_System_Numerics_Vector2_System_Numerics_Vector2_System_Single_"></a> PointInCircle\(Vector2, Vector2, float\)

```csharp
public static bool PointInCircle(Vector2 pointPosition, Vector2 circlePosition, float radius)
```

#### Parameters

`pointPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`circlePosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Shapes_Intersection_PointInCircleSquared_System_Numerics_Vector2_System_Numerics_Vector2_System_Single_"></a> PointInCircleSquared\(Vector2, Vector2, float\)

```csharp
public static bool PointInCircleSquared(Vector2 pointPosition, Vector2 circlePosition, float radiusSquared)
```

#### Parameters

`pointPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`circlePosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`radiusSquared` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Shapes_Intersection_PointInRectangle_System_Numerics_Vector2_Clockwork_Graphics_Rectangle_"></a> PointInRectangle\(Vector2, Rectangle\)

```csharp
public static bool PointInRectangle(Vector2 pointPosition, Rectangle rectangle)
```

#### Parameters

`pointPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`rectangle` [Rectangle](Clockwork.Graphics.Rectangle.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Shapes_Intersection_PointOnLine_System_Numerics_Vector2_System_Numerics_Vector2_System_Numerics_Vector2_System_Single_"></a> PointOnLine\(Vector2, Vector2, Vector2, float\)

```csharp
public static bool PointOnLine(Vector2 pointPosition, Vector2 lineStartPosition, Vector2 lineEndPosition, float tolerance)
```

#### Parameters

`pointPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`lineStartPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`lineEndPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`tolerance` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Shapes_Intersection_RectangleOnRectangle_Clockwork_Graphics_Rectangle_Clockwork_Graphics_Rectangle_"></a> RectangleOnRectangle\(Rectangle, Rectangle\)

```csharp
public static bool RectangleOnRectangle(Rectangle rectangleA, Rectangle rectangleB)
```

#### Parameters

`rectangleA` [Rectangle](Clockwork.Graphics.Rectangle.md)

`rectangleB` [Rectangle](Clockwork.Graphics.Rectangle.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

