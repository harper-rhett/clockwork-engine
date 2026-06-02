# <a id="Clockwork_Graphics_Cameras_FreeCamera3D"></a> Class FreeCamera3D

Namespace: [Clockwork.Graphics.Cameras](Clockwork.Graphics.Cameras.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class FreeCamera3D : Camera3D
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Clockwork.Entity.md) ← 
[CameraEntity](Clockwork.Graphics.Cameras.CameraEntity.md) ← 
[Camera3D](Clockwork.Graphics.Cameras.Camera3D.md) ← 
[FreeCamera3D](Clockwork.Graphics.Cameras.FreeCamera3D.md)

#### Inherited Members

[Camera3D.Transform](Clockwork.Graphics.Cameras.Camera3D.md\#Clockwork\_Graphics\_Cameras\_Camera3D\_Transform), 
[Camera3D.InternalCamera](Clockwork.Graphics.Cameras.Camera3D.md\#Clockwork\_Graphics\_Cameras\_Camera3D\_InternalCamera), 
[Camera3D.ScreenToWorldRay\(Vector2\)](Clockwork.Graphics.Cameras.Camera3D.md\#Clockwork\_Graphics\_Cameras\_Camera3D\_ScreenToWorldRay\_System\_Numerics\_Vector2\_), 
[Camera3D.WorldToScreenPosition\(Vector3\)](Clockwork.Graphics.Cameras.Camera3D.md\#Clockwork\_Graphics\_Cameras\_Camera3D\_WorldToScreenPosition\_System\_Numerics\_Vector3\_), 
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

### <a id="Clockwork_Graphics_Cameras_FreeCamera3D__ctor_System_Numerics_Vector3_"></a> FreeCamera3D\(Vector3\)

```csharp
public FreeCamera3D(Vector3 position)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

## Fields

### <a id="Clockwork_Graphics_Cameras_FreeCamera3D_MovementSpeed"></a> MovementSpeed

```csharp
public float MovementSpeed
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Graphics_Cameras_FreeCamera3D_TurnSpeed"></a> TurnSpeed

```csharp
public float TurnSpeed
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Clockwork_Graphics_Cameras_FreeCamera3D_OnUpdate"></a> OnUpdate\(\)

```csharp
public override void OnUpdate()
```

