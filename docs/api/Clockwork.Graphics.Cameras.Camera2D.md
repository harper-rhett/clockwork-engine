# <a id="Clockwork_Graphics_Cameras_Camera2D"></a> Class Camera2D

Namespace: [Clockwork.Graphics.Cameras](Clockwork.Graphics.Cameras.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class Camera2D : CameraEntity
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Clockwork.Entity.md) ← 
[CameraEntity](Clockwork.Graphics.Cameras.CameraEntity.md) ← 
[Camera2D](Clockwork.Graphics.Cameras.Camera2D.md)

#### Derived

[FreeCamera2D](Clockwork.Graphics.Cameras.FreeCamera2D.md)

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

### <a id="Clockwork_Graphics_Cameras_Camera2D__ctor"></a> Camera2D\(\)

```csharp
public Camera2D()
```

## Fields

### <a id="Clockwork_Graphics_Cameras_Camera2D_InternalCamera"></a> InternalCamera

```csharp
public Camera2DInternal InternalCamera
```

#### Field Value

 [Camera2DInternal](Clockwork.Graphics.Cameras.Camera2DInternal.md)

### <a id="Clockwork_Graphics_Cameras_Camera2D_Transform"></a> Transform

```csharp
public Transform2D Transform
```

#### Field Value

 [Transform2D](Clockwork.Utilities.Transform2D.md)

## Properties

### <a id="Clockwork_Graphics_Cameras_Camera2D_Height"></a> Height

```csharp
public float Height { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Graphics_Cameras_Camera2D_Offset"></a> Offset

```csharp
public Vector2 Offset { get; set; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_Graphics_Cameras_Camera2D_Position"></a> Position

```csharp
public Vector2 Position { get; set; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_Graphics_Cameras_Camera2D_Rotation"></a> Rotation

```csharp
public float Rotation { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Graphics_Cameras_Camera2D_Width"></a> Width

```csharp
public float Width { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Graphics_Cameras_Camera2D_Zoom"></a> Zoom

```csharp
public float Zoom { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Clockwork_Graphics_Cameras_Camera2D_GetAxisAlignedViewport"></a> GetAxisAlignedViewport\(\)

```csharp
public Rectangle GetAxisAlignedViewport()
```

#### Returns

 [Rectangle](Clockwork.Graphics.Rectangle.md)

### <a id="Clockwork_Graphics_Cameras_Camera2D_GetMouseWorldX"></a> GetMouseWorldX\(\)

```csharp
public float GetMouseWorldX()
```

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Graphics_Cameras_Camera2D_GetMouseWorldY"></a> GetMouseWorldY\(\)

```csharp
public float GetMouseWorldY()
```

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

