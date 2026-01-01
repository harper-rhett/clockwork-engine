# <a id="Clockwork_Entity"></a> Class Entity

Namespace: [Clockwork](Clockwork.md)  
Assembly: ClockworkEngine.dll  

```csharp
public abstract class Entity
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Clockwork.Entity.md)

#### Derived

[Camera](Clockwork.Camera.md), 
[CircleShape](Clockwork.Shapes.CircleShape.md), 
[Easer](Clockwork.Animation.Easer.md), 
[FireTimer](Clockwork.Utilities.FireTimer.md), 
[LineShape](Clockwork.Shapes.LineShape.md), 
[MusicPlayer](Clockwork.Audio.MusicPlayer.md), 
[MusicRepeater](Clockwork.Audio.MusicRepeater.md), 
[MusicRepeater2Part](Clockwork.Audio.MusicRepeater2Part.md), 
[Parallax](Clockwork.Graphics.Parallax.md), 
[ParticleEngine2D](Clockwork.Particles.ParticleEngine2D.md), 
[PointShape](Clockwork.Shapes.PointShape.md), 
[PolygonShape](Clockwork.Shapes.PolygonShape.md), 
[RectangleShape](Clockwork.Shapes.RectangleShape.md), 
[TiledWorld](Clockwork.Tiles.TiledWorld.md), 
[TriggerTimer](Clockwork.Utilities.TriggerTimer.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Fields

### <a id="Clockwork_Entity_IsRendering"></a> IsRendering

```csharp
public bool IsRendering
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Entity_IsUpdating"></a> IsUpdating

```csharp
public bool IsUpdating
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Entity_Scene"></a> Scene

```csharp
public Scene Scene
```

#### Field Value

 [Scene](Clockwork.Scene.md)

## Properties

### <a id="Clockwork_Entity_DrawLayer"></a> DrawLayer

```csharp
public int DrawLayer { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Entity_UpdateLayer"></a> UpdateLayer

```csharp
public int UpdateLayer { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Clockwork_Entity_OnAddedToScene"></a> OnAddedToScene\(\)

```csharp
public virtual void OnAddedToScene()
```

### <a id="Clockwork_Entity_OnDraw"></a> OnDraw\(\)

```csharp
public virtual void OnDraw()
```

### <a id="Clockwork_Entity_OnDrawGUI"></a> OnDrawGUI\(\)

```csharp
public virtual void OnDrawGUI()
```

### <a id="Clockwork_Entity_OnRemovedFromScene"></a> OnRemovedFromScene\(\)

```csharp
public virtual void OnRemovedFromScene()
```

### <a id="Clockwork_Entity_OnUpdate"></a> OnUpdate\(\)

```csharp
public virtual void OnUpdate()
```

### <a id="Clockwork_Entity_Remove"></a> Remove\(\)

```csharp
public void Remove()
```

