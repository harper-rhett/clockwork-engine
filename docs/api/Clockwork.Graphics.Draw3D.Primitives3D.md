# <a id="Clockwork_Graphics_Draw3D_Primitives3D"></a> Class Primitives3D

Namespace: [Clockwork.Graphics.Draw3D](Clockwork.Graphics.Draw3D.md)  
Assembly: ClockworkEngine.dll  

```csharp
public static class Primitives3D
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Primitives3D](Clockwork.Graphics.Draw3D.Primitives3D.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Methods

### <a id="Clockwork_Graphics_Draw3D_Primitives3D_DrawBox_System_Numerics_Vector3_System_Single_System_Single_System_Single_Clockwork_Graphics_Color_"></a> DrawBox\(Vector3, float, float, float, Color\)

```csharp
public static extern void DrawBox(Vector3 position, float width, float height, float length, Color color)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

`height` [float](https://learn.microsoft.com/dotnet/api/system.single)

`length` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Graphics_Draw3D_Primitives3D_DrawBox_System_Numerics_Vector3_System_Numerics_Vector3_Clockwork_Graphics_Color_"></a> DrawBox\(Vector3, Vector3, Color\)

```csharp
public static extern void DrawBox(Vector3 position, Vector3 size, Color color)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`size` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`color` [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Graphics_Draw3D_Primitives3D_DrawBoxWires_System_Numerics_Vector3_System_Single_System_Single_System_Single_Clockwork_Graphics_Color_"></a> DrawBoxWires\(Vector3, float, float, float, Color\)

```csharp
public static extern void DrawBoxWires(Vector3 position, float width, float height, float length, Color color)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

`height` [float](https://learn.microsoft.com/dotnet/api/system.single)

`length` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Graphics_Draw3D_Primitives3D_DrawBoxWires_System_Numerics_Vector3_System_Numerics_Vector3_Clockwork_Graphics_Color_"></a> DrawBoxWires\(Vector3, Vector3, Color\)

```csharp
public static extern void DrawBoxWires(Vector3 position, Vector3 size, Color color)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`size` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`color` [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Graphics_Draw3D_Primitives3D_DrawCapsule_System_Numerics_Vector3_System_Numerics_Vector3_System_Single_System_Int32_System_Int32_Clockwork_Graphics_Color_"></a> DrawCapsule\(Vector3, Vector3, float, int, int, Color\)

```csharp
public static extern void DrawCapsule(Vector3 startPosition, Vector3 endPosition, float radius, int slices, int rings, Color color)
```

#### Parameters

`startPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`endPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`slices` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`rings` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`color` [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Graphics_Draw3D_Primitives3D_DrawCapsuleWires_System_Numerics_Vector3_System_Numerics_Vector3_System_Single_System_Int32_System_Int32_Clockwork_Graphics_Color_"></a> DrawCapsuleWires\(Vector3, Vector3, float, int, int, Color\)

```csharp
public static extern void DrawCapsuleWires(Vector3 startPosition, Vector3 endPosition, float radius, int slices, int rings, Color color)
```

#### Parameters

`startPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`endPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`slices` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`rings` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`color` [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Graphics_Draw3D_Primitives3D_DrawCircle_System_Numerics_Vector3_System_Single_System_Numerics_Vector3_System_Single_Clockwork_Graphics_Color_"></a> DrawCircle\(Vector3, float, Vector3, float, Color\)

```csharp
public static extern void DrawCircle(Vector3 center, float radius, Vector3 axis, float angle, Color color)
```

#### Parameters

`center` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`axis` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`angle` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Graphics_Draw3D_Primitives3D_DrawCube_System_Numerics_Vector3_System_Single_Clockwork_Graphics_Color_"></a> DrawCube\(Vector3, float, Color\)

```csharp
public static void DrawCube(Vector3 position, float size, Color color)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`size` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Graphics_Draw3D_Primitives3D_DrawCylinder_System_Numerics_Vector3_System_Single_System_Single_System_Single_System_Int32_Clockwork_Graphics_Color_"></a> DrawCylinder\(Vector3, float, float, float, int, Color\)

```csharp
public static extern void DrawCylinder(Vector3 position, float radiusTop, float radiusBottom, float height, int slices, Color color)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`radiusTop` [float](https://learn.microsoft.com/dotnet/api/system.single)

`radiusBottom` [float](https://learn.microsoft.com/dotnet/api/system.single)

`height` [float](https://learn.microsoft.com/dotnet/api/system.single)

`slices` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`color` [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Graphics_Draw3D_Primitives3D_DrawCylinder_System_Numerics_Vector3_System_Numerics_Vector3_System_Single_System_Single_System_Int32_Clockwork_Graphics_Color_"></a> DrawCylinder\(Vector3, Vector3, float, float, int, Color\)

```csharp
public static extern void DrawCylinder(Vector3 startPosition, Vector3 endPosition, float startRadius, float endRadius, int sides, Color color)
```

#### Parameters

`startPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`endPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`startRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`endRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`sides` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`color` [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Graphics_Draw3D_Primitives3D_DrawCylinderWires_System_Numerics_Vector3_System_Single_System_Single_System_Single_System_Int32_Clockwork_Graphics_Color_"></a> DrawCylinderWires\(Vector3, float, float, float, int, Color\)

```csharp
public static extern void DrawCylinderWires(Vector3 position, float radiusTop, float radiusBottom, float height, int slices, Color color)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`radiusTop` [float](https://learn.microsoft.com/dotnet/api/system.single)

`radiusBottom` [float](https://learn.microsoft.com/dotnet/api/system.single)

`height` [float](https://learn.microsoft.com/dotnet/api/system.single)

`slices` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`color` [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Graphics_Draw3D_Primitives3D_DrawCylinderWires_System_Numerics_Vector3_System_Numerics_Vector3_System_Single_System_Single_System_Int32_Clockwork_Graphics_Color_"></a> DrawCylinderWires\(Vector3, Vector3, float, float, int, Color\)

```csharp
public static extern void DrawCylinderWires(Vector3 startPosition, Vector3 endPosition, float startRadius, float endRadius, int sides, Color color)
```

#### Parameters

`startPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`endPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`startRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`endRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`sides` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`color` [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Graphics_Draw3D_Primitives3D_DrawGrid_System_Int32_System_Single_"></a> DrawGrid\(int, float\)

```csharp
public static extern void DrawGrid(int slices, float spacing)
```

#### Parameters

`slices` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`spacing` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Graphics_Draw3D_Primitives3D_DrawLine_System_Numerics_Vector3_System_Numerics_Vector3_Clockwork_Graphics_Color_"></a> DrawLine\(Vector3, Vector3, Color\)

```csharp
public static extern void DrawLine(Vector3 startPosition, Vector3 endPosition, Color color)
```

#### Parameters

`startPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`endPosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`color` [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Graphics_Draw3D_Primitives3D_DrawPlane_System_Numerics_Vector3_System_Numerics_Vector2_Clockwork_Graphics_Color_"></a> DrawPlane\(Vector3, Vector2, Color\)

```csharp
public static extern void DrawPlane(Vector3 center, Vector2 size, Color color)
```

#### Parameters

`center` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`size` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`color` [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Graphics_Draw3D_Primitives3D_DrawPoint_System_Numerics_Vector3_Clockwork_Graphics_Color_"></a> DrawPoint\(Vector3, Color\)

```csharp
public static extern void DrawPoint(Vector3 position, Color color)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`color` [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Graphics_Draw3D_Primitives3D_DrawSphere_System_Numerics_Vector3_System_Single_Clockwork_Graphics_Color_"></a> DrawSphere\(Vector3, float, Color\)

```csharp
public static extern void DrawSphere(Vector3 center, float radius, Color color)
```

#### Parameters

`center` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Graphics_Draw3D_Primitives3D_DrawSphere_System_Numerics_Vector3_System_Single_System_Int32_System_Int32_Clockwork_Graphics_Color_"></a> DrawSphere\(Vector3, float, int, int, Color\)

```csharp
public static extern void DrawSphere(Vector3 center, float radius, int rings, int slices, Color color)
```

#### Parameters

`center` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`rings` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`slices` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`color` [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Graphics_Draw3D_Primitives3D_DrawSphereWires_System_Numerics_Vector3_System_Single_System_Int32_System_Int32_Clockwork_Graphics_Color_"></a> DrawSphereWires\(Vector3, float, int, int, Color\)

```csharp
public static extern void DrawSphereWires(Vector3 center, float radius, int rings, int slices, Color color)
```

#### Parameters

`center` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`rings` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`slices` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`color` [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Graphics_Draw3D_Primitives3D_DrawTriangle_System_Numerics_Vector3_System_Numerics_Vector3_System_Numerics_Vector3_Clockwork_Graphics_Color_"></a> DrawTriangle\(Vector3, Vector3, Vector3, Color\)

```csharp
public static extern void DrawTriangle(Vector3 corner1, Vector3 corner2, Vector3 corner3, Color color)
```

#### Parameters

`corner1` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`corner2` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`corner3` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`color` [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Graphics_Draw3D_Primitives3D_DrawTriangleStrip_System_Numerics_Vector3___System_Int32_Clockwork_Graphics_Color_"></a> DrawTriangleStrip\(Vector3\[\], int, Color\)

```csharp
public static extern void DrawTriangleStrip(Vector3[] positions, int positionCount, Color color)
```

#### Parameters

`positions` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)\[\]

`positionCount` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`color` [Color](Clockwork.Graphics.Color.md)

