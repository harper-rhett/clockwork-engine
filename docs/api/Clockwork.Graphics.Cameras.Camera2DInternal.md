# <a id="Clockwork_Graphics_Cameras_Camera2DInternal"></a> Struct Camera2DInternal

Namespace: [Clockwork.Graphics.Cameras](Clockwork.Graphics.Cameras.md)  
Assembly: ClockworkEngine.dll  

```csharp
public struct Camera2DInternal
```

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Clockwork_Graphics_Cameras_Camera2DInternal__ctor_System_Numerics_Vector2_System_Single_System_Single_"></a> Camera2DInternal\(Vector2, float, float\)

```csharp
public Camera2DInternal(Vector2 position, float rotation, float zoom)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`rotation` [float](https://learn.microsoft.com/dotnet/api/system.single)

`zoom` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Fields

### <a id="Clockwork_Graphics_Cameras_Camera2DInternal_Offset"></a> Offset

```csharp
public Vector2 Offset
```

#### Field Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_Graphics_Cameras_Camera2DInternal_Position"></a> Position

```csharp
public Vector2 Position
```

#### Field Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_Graphics_Cameras_Camera2DInternal_Rotation"></a> Rotation

```csharp
public float Rotation
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Graphics_Cameras_Camera2DInternal_Zoom"></a> Zoom

```csharp
public float Zoom
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Properties

### <a id="Clockwork_Graphics_Cameras_Camera2DInternal_Matrix"></a> Matrix

```csharp
public Matrix4x4 Matrix { get; }
```

#### Property Value

 [Matrix4x4](https://learn.microsoft.com/dotnet/api/system.numerics.matrix4x4)

## Methods

### <a id="Clockwork_Graphics_Cameras_Camera2DInternal_BeginRendering_Clockwork_Graphics_Cameras_Camera2DInternal_"></a> BeginRendering\(Camera2DInternal\)

```csharp
public static extern void BeginRendering(Camera2DInternal camera2D)
```

#### Parameters

`camera2D` [Camera2DInternal](Clockwork.Graphics.Cameras.Camera2DInternal.md)

### <a id="Clockwork_Graphics_Cameras_Camera2DInternal_EndRendering"></a> EndRendering\(\)

```csharp
public static extern void EndRendering()
```

### <a id="Clockwork_Graphics_Cameras_Camera2DInternal_GetRenderScope"></a> GetRenderScope\(\)

```csharp
public Scope GetRenderScope()
```

#### Returns

 [Scope](Clockwork.Utilities.Scope.md)

