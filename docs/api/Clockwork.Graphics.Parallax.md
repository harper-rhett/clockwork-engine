# <a id="Clockwork_Graphics_Parallax"></a> Class Parallax

Namespace: [Clockwork.Graphics](Clockwork.Graphics.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class Parallax : Entity
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Clockwork.Entity.md) ← 
[Parallax](Clockwork.Graphics.Parallax.md)

#### Inherited Members

[Entity.Scene](Clockwork.Entity.md\#Clockwork\_Entity\_Scene), 
[Entity.IsUpdating](Clockwork.Entity.md\#Clockwork\_Entity\_IsUpdating), 
[Entity.IsRendering](Clockwork.Entity.md\#Clockwork\_Entity\_IsRendering), 
[Entity.UpdateLayer](Clockwork.Entity.md\#Clockwork\_Entity\_UpdateLayer), 
[Entity.DrawLayer](Clockwork.Entity.md\#Clockwork\_Entity\_DrawLayer), 
[Entity.OnUpdate\(\)](Clockwork.Entity.md\#Clockwork\_Entity\_OnUpdate), 
[Entity.OnDraw\(\)](Clockwork.Entity.md\#Clockwork\_Entity\_OnDraw), 
[Entity.OnDrawGUI\(\)](Clockwork.Entity.md\#Clockwork\_Entity\_OnDrawGUI), 
[Entity.Remove\(\)](Clockwork.Entity.md\#Clockwork\_Entity\_Remove), 
[Entity.OnAddedToScene\(\)](Clockwork.Entity.md\#Clockwork\_Entity\_OnAddedToScene), 
[Entity.OnRemovedFromScene\(\)](Clockwork.Entity.md\#Clockwork\_Entity\_OnRemovedFromScene), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Clockwork_Graphics_Parallax__ctor_Clockwork_Camera2D_System_Numerics_Vector2_System_Numerics_Vector2_"></a> Parallax\(Camera2D, Vector2, Vector2\)

```csharp
public Parallax(Camera2D camera, Vector2 originPosition, Vector2 startPosition)
```

#### Parameters

`camera` [Camera2D](Clockwork.Camera2D.md)

`originPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`startPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

## Fields

### <a id="Clockwork_Graphics_Parallax_RepeatX"></a> RepeatX

```csharp
public bool RepeatX
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Graphics_Parallax_RepeatY"></a> RepeatY

```csharp
public bool RepeatY
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Clockwork_Graphics_Parallax_AddLayer_Clockwork_Graphics_Texture_System_Numerics_Vector2_System_Single_"></a> AddLayer\(Texture, Vector2, float\)

```csharp
public void AddLayer(Texture backgroundTexture, Vector2 offset, float speed)
```

#### Parameters

`backgroundTexture` [Texture](Clockwork.Graphics.Texture.md)

`offset` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`speed` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Graphics_Parallax_OnDraw"></a> OnDraw\(\)

```csharp
public override void OnDraw()
```

