# <a id="HarpEngine_Entity"></a> Class Entity

Namespace: [HarpEngine](HarpEngine.md)  
Assembly: HarpEngine.dll  

```csharp
public abstract class Entity
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](HarpEngine.Entity.md)

#### Derived

[Camera](HarpEngine.Camera.md), 
[CircleShape](HarpEngine.Shapes.CircleShape.md), 
[Easer](HarpEngine.Animation.Easer.md), 
[FireTimer](HarpEngine.Utilities.FireTimer.md), 
[LineShape](HarpEngine.Shapes.LineShape.md), 
[MusicPlayer](HarpEngine.Audio.MusicPlayer.md), 
[MusicRepeater](HarpEngine.Audio.MusicRepeater.md), 
[MusicRepeater2Part](HarpEngine.Audio.MusicRepeater2Part.md), 
[ParticleEngine2D](HarpEngine.Particles.ParticleEngine2D.md), 
[PointShape](HarpEngine.Shapes.PointShape.md), 
[PolygonShape](HarpEngine.Shapes.PolygonShape.md), 
[RectangleShape](HarpEngine.Shapes.RectangleShape.md), 
[TiledWorld](HarpEngine.Tiles.TiledWorld.md), 
[TriggerTimer](HarpEngine.Utilities.TriggerTimer.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Fields

### <a id="HarpEngine_Entity_IsRendering"></a> IsRendering

```csharp
public bool IsRendering
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Entity_IsUpdating"></a> IsUpdating

```csharp
public bool IsUpdating
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Entity_Scene"></a> Scene

```csharp
public Scene Scene
```

#### Field Value

 [Scene](HarpEngine.Scene.md)

## Properties

### <a id="HarpEngine_Entity_DrawLayer"></a> DrawLayer

```csharp
public int DrawLayer { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Entity_UpdateLayer"></a> UpdateLayer

```csharp
public int UpdateLayer { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="HarpEngine_Entity_OnAddedToScene"></a> OnAddedToScene\(\)

```csharp
public virtual void OnAddedToScene()
```

### <a id="HarpEngine_Entity_OnDraw"></a> OnDraw\(\)

```csharp
public virtual void OnDraw()
```

### <a id="HarpEngine_Entity_OnDrawGUI"></a> OnDrawGUI\(\)

```csharp
public virtual void OnDrawGUI()
```

### <a id="HarpEngine_Entity_OnRemovedFromScene"></a> OnRemovedFromScene\(\)

```csharp
public virtual void OnRemovedFromScene()
```

### <a id="HarpEngine_Entity_OnUpdate"></a> OnUpdate\(\)

```csharp
public virtual void OnUpdate()
```

### <a id="HarpEngine_Entity_Remove"></a> Remove\(\)

```csharp
public void Remove()
```

