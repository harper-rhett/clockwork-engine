# <a id="Clockwork_Graphics_Cameras_Camera3D"></a> Class Camera3D

Namespace: [Clockwork.Graphics.Cameras](Clockwork.Graphics.Cameras.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class Camera3D : CameraEntity
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Clockwork.Entity.md) ← 
[CameraEntity](Clockwork.Graphics.Cameras.CameraEntity.md) ← 
[Camera3D](Clockwork.Graphics.Cameras.Camera3D.md)

#### Derived

[FreeCamera3D](Clockwork.Graphics.Cameras.FreeCamera3D.md)

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

### <a id="Clockwork_Graphics_Cameras_Camera3D__ctor_System_Numerics_Vector3_"></a> Camera3D\(Vector3\)

```csharp
public Camera3D(Vector3 position)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

## Fields

### <a id="Clockwork_Graphics_Cameras_Camera3D_InternalCamera"></a> InternalCamera

```csharp
public Camera3DInternal InternalCamera
```

#### Field Value

 [Camera3DInternal](Clockwork.Graphics.Cameras.Camera3DInternal.md)

### <a id="Clockwork_Graphics_Cameras_Camera3D_Transform"></a> Transform

```csharp
public Transform3D Transform
```

#### Field Value

 [Transform3D](Clockwork.Utilities.Transform3D.md)

## Methods

### <a id="Clockwork_Graphics_Cameras_Camera3D_ScreenToWorldRay_System_Numerics_Vector2_"></a> ScreenToWorldRay\(Vector2\)

```csharp
public Ray ScreenToWorldRay(Vector2 screenPosition)
```

#### Parameters

`screenPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [Ray](Ray.md)

### <a id="Clockwork_Graphics_Cameras_Camera3D_WorldToScreenPosition_System_Numerics_Vector3_"></a> WorldToScreenPosition\(Vector3\)

```csharp
public Vector2 WorldToScreenPosition(Vector3 position)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

