# <a id="Clockwork_Graphics_Cameras_FreeCamera2D"></a> Class FreeCamera2D

Namespace: [Clockwork.Graphics.Cameras](Clockwork.Graphics.Cameras.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class FreeCamera2D : Camera2D
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Clockwork.Entity.md) ← 
[CameraEntity](Clockwork.Graphics.Cameras.CameraEntity.md) ← 
[Camera2D](Clockwork.Graphics.Cameras.Camera2D.md) ← 
[FreeCamera2D](Clockwork.Graphics.Cameras.FreeCamera2D.md)

#### Inherited Members

[Camera2D.Transform](Clockwork.Graphics.Cameras.Camera2D.md\#Clockwork\_Graphics\_Cameras\_Camera2D\_Transform), 
[Camera2D.Position](Clockwork.Graphics.Cameras.Camera2D.md\#Clockwork\_Graphics\_Cameras\_Camera2D\_Position), 
[Camera2D.Rotation](Clockwork.Graphics.Cameras.Camera2D.md\#Clockwork\_Graphics\_Cameras\_Camera2D\_Rotation), 
[Camera2D.InternalCamera](Clockwork.Graphics.Cameras.Camera2D.md\#Clockwork\_Graphics\_Cameras\_Camera2D\_InternalCamera), 
[Camera2D.Offset](Clockwork.Graphics.Cameras.Camera2D.md\#Clockwork\_Graphics\_Cameras\_Camera2D\_Offset), 
[Camera2D.Zoom](Clockwork.Graphics.Cameras.Camera2D.md\#Clockwork\_Graphics\_Cameras\_Camera2D\_Zoom), 
[Camera2D.Width](Clockwork.Graphics.Cameras.Camera2D.md\#Clockwork\_Graphics\_Cameras\_Camera2D\_Width), 
[Camera2D.Height](Clockwork.Graphics.Cameras.Camera2D.md\#Clockwork\_Graphics\_Cameras\_Camera2D\_Height), 
[Camera2D.GetMouseWorldX\(\)](Clockwork.Graphics.Cameras.Camera2D.md\#Clockwork\_Graphics\_Cameras\_Camera2D\_GetMouseWorldX), 
[Camera2D.GetMouseWorldY\(\)](Clockwork.Graphics.Cameras.Camera2D.md\#Clockwork\_Graphics\_Cameras\_Camera2D\_GetMouseWorldY), 
[Camera2D.GetAxisAlignedViewport\(\)](Clockwork.Graphics.Cameras.Camera2D.md\#Clockwork\_Graphics\_Cameras\_Camera2D\_GetAxisAlignedViewport), 
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

### <a id="Clockwork_Graphics_Cameras_FreeCamera2D__ctor"></a> FreeCamera2D\(\)

```csharp
public FreeCamera2D()
```

## Fields

### <a id="Clockwork_Graphics_Cameras_FreeCamera2D_MaxZoomIn"></a> MaxZoomIn

```csharp
public float MaxZoomIn
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Graphics_Cameras_FreeCamera2D_MinZoomOut"></a> MinZoomOut

```csharp
public float MinZoomOut
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Graphics_Cameras_FreeCamera2D_MovementSpeed"></a> MovementSpeed

```csharp
public float MovementSpeed
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Graphics_Cameras_FreeCamera2D_ZoomSpeed"></a> ZoomSpeed

```csharp
public float ZoomSpeed
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Clockwork_Graphics_Cameras_FreeCamera2D_OnUpdate"></a> OnUpdate\(\)

```csharp
public override void OnUpdate()
```

