# <a id="Clockwork_Graphics_Cameras_Camera3DInternal"></a> Struct Camera3DInternal

Namespace: [Clockwork.Graphics.Cameras](Clockwork.Graphics.Cameras.md)  
Assembly: ClockworkEngine.dll  

```csharp
public struct Camera3DInternal
```

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Clockwork_Graphics_Cameras_Camera3DInternal__ctor_System_Numerics_Vector3_System_Numerics_Vector3_System_Numerics_Vector3_System_Single_Clockwork_Graphics_Cameras_CameraProjection_"></a> Camera3DInternal\(Vector3, Vector3, Vector3, float, CameraProjection\)

```csharp
public Camera3DInternal(Vector3 position, Vector3 target, Vector3 up, float fovy, CameraProjection projection)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`target` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`up` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`fovy` [float](https://learn.microsoft.com/dotnet/api/system.single)

`projection` [CameraProjection](Clockwork.Graphics.Cameras.CameraProjection.md)

### <a id="Clockwork_Graphics_Cameras_Camera3DInternal__ctor_System_Numerics_Vector3_System_Numerics_Quaternion_System_Single_Clockwork_Graphics_Cameras_CameraProjection_"></a> Camera3DInternal\(Vector3, Quaternion, float, CameraProjection\)

```csharp
public Camera3DInternal(Vector3 position, Quaternion rotation, float fovy, CameraProjection projection)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`rotation` [Quaternion](https://learn.microsoft.com/dotnet/api/system.numerics.quaternion)

`fovy` [float](https://learn.microsoft.com/dotnet/api/system.single)

`projection` [CameraProjection](Clockwork.Graphics.Cameras.CameraProjection.md)

## Fields

### <a id="Clockwork_Graphics_Cameras_Camera3DInternal_FOVY"></a> FOVY

```csharp
public float FOVY
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Graphics_Cameras_Camera3DInternal_Position"></a> Position

```csharp
public Vector3 Position
```

#### Field Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Clockwork_Graphics_Cameras_Camera3DInternal_Projection"></a> Projection

```csharp
public CameraProjection Projection
```

#### Field Value

 [CameraProjection](Clockwork.Graphics.Cameras.CameraProjection.md)

### <a id="Clockwork_Graphics_Cameras_Camera3DInternal_Target"></a> Target

```csharp
public Vector3 Target
```

#### Field Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Clockwork_Graphics_Cameras_Camera3DInternal_Up"></a> Up

```csharp
public Vector3 Up
```

#### Field Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

## Properties

### <a id="Clockwork_Graphics_Cameras_Camera3DInternal_Rotation"></a> Rotation

```csharp
public Quaternion Rotation { get; set; }
```

#### Property Value

 [Quaternion](https://learn.microsoft.com/dotnet/api/system.numerics.quaternion)

## Methods

### <a id="Clockwork_Graphics_Cameras_Camera3DInternal_BeginRendering_Clockwork_Graphics_Cameras_Camera3DInternal_"></a> BeginRendering\(Camera3DInternal\)

```csharp
public static extern void BeginRendering(Camera3DInternal camera3D)
```

#### Parameters

`camera3D` [Camera3DInternal](Clockwork.Graphics.Cameras.Camera3DInternal.md)

### <a id="Clockwork_Graphics_Cameras_Camera3DInternal_EndRendering"></a> EndRendering\(\)

```csharp
public static extern void EndRendering()
```

### <a id="Clockwork_Graphics_Cameras_Camera3DInternal_GetRenderScope"></a> GetRenderScope\(\)

```csharp
public Scope GetRenderScope()
```

#### Returns

 [Scope](Clockwork.Utilities.Scope.md)

### <a id="Clockwork_Graphics_Cameras_Camera3DInternal_ScreenToWorldRay_System_Numerics_Vector2_"></a> ScreenToWorldRay\(Vector2\)

```csharp
public Ray ScreenToWorldRay(Vector2 screenPosition)
```

#### Parameters

`screenPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [Ray](Ray.md)

### <a id="Clockwork_Graphics_Cameras_Camera3DInternal_WorldToScreenPosition_System_Numerics_Vector3_"></a> WorldToScreenPosition\(Vector3\)

```csharp
public Vector2 WorldToScreenPosition(Vector3 position)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

