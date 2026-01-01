# <a id="Clockwork_Particles_ParticleEngine2D"></a> Class ParticleEngine2D

Namespace: [Clockwork.Particles](Clockwork.Particles.md)  
Assembly: ClockworkEngine.dll  

```csharp
public sealed class ParticleEngine2D : Entity
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Clockwork.Entity.md) ← 
[ParticleEngine2D](Clockwork.Particles.ParticleEngine2D.md)

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
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Clockwork_Particles_ParticleEngine2D__ctor_System_Int32_System_Single_"></a> ParticleEngine2D\(int, float\)

```csharp
public ParticleEngine2D(int initialCount = 100, float streamCooldownTime = 0.1)
```

#### Parameters

`initialCount` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`streamCooldownTime` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Fields

### <a id="Clockwork_Particles_ParticleEngine2D_Particles"></a> Particles

```csharp
public IReadOnlyList<Particle2D> Particles
```

#### Field Value

 [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<[Particle2D](Clockwork.Particles.Particle2D.md)\>

### <a id="Clockwork_Particles_ParticleEngine2D_RemoveOnExhausted"></a> RemoveOnExhausted

```csharp
public bool RemoveOnExhausted
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Properties

### <a id="Clockwork_Particles_ParticleEngine2D_IsExhausted"></a> IsExhausted

```csharp
public bool IsExhausted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Particles_ParticleEngine2D_IsStreaming"></a> IsStreaming

```csharp
public bool IsStreaming { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Particles_ParticleEngine2D_StreamCooldownTime"></a> StreamCooldownTime

```csharp
public float StreamCooldownTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Clockwork_Particles_ParticleEngine2D_AddFinalizer_Clockwork_Particles_Particle2DFinalizer_"></a> AddFinalizer\(Particle2DFinalizer\)

```csharp
public void AddFinalizer(Particle2DFinalizer finalizer)
```

#### Parameters

`finalizer` [Particle2DFinalizer](Clockwork.Particles.Particle2DFinalizer.md)

### <a id="Clockwork_Particles_ParticleEngine2D_AddInitializer_Clockwork_Particles_Particle2DInitializer_"></a> AddInitializer\(Particle2DInitializer\)

```csharp
public void AddInitializer(Particle2DInitializer initializer)
```

#### Parameters

`initializer` [Particle2DInitializer](Clockwork.Particles.Particle2DInitializer.md)

### <a id="Clockwork_Particles_ParticleEngine2D_AddModifier_Clockwork_Particles_Particle2DModifier_"></a> AddModifier\(Particle2DModifier\)

```csharp
public void AddModifier(Particle2DModifier modifier)
```

#### Parameters

`modifier` [Particle2DModifier](Clockwork.Particles.Particle2DModifier.md)

### <a id="Clockwork_Particles_ParticleEngine2D_OnAddedToScene"></a> OnAddedToScene\(\)

```csharp
public override void OnAddedToScene()
```

### <a id="Clockwork_Particles_ParticleEngine2D_OnDraw"></a> OnDraw\(\)

```csharp
public override void OnDraw()
```

### <a id="Clockwork_Particles_ParticleEngine2D_OnRemovedFromScene"></a> OnRemovedFromScene\(\)

```csharp
public override void OnRemovedFromScene()
```

### <a id="Clockwork_Particles_ParticleEngine2D_OnUpdate"></a> OnUpdate\(\)

```csharp
public override void OnUpdate()
```

### <a id="Clockwork_Particles_ParticleEngine2D_RemoveParticle_System_Int32_"></a> RemoveParticle\(int\)

```csharp
public void RemoveParticle(int particleIndex)
```

#### Parameters

`particleIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Particles_ParticleEngine2D_RenderAsCircle_System_Single_"></a> RenderAsCircle\(float\)

```csharp
public void RenderAsCircle(float radius)
```

#### Parameters

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Particles_ParticleEngine2D_RenderAsPixel"></a> RenderAsPixel\(\)

```csharp
public void RenderAsPixel()
```

### <a id="Clockwork_Particles_ParticleEngine2D_RenderAsPolygon_System_Int32_System_Single_"></a> RenderAsPolygon\(int, float\)

```csharp
public void RenderAsPolygon(int sides, float radius)
```

#### Parameters

`sides` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Particles_ParticleEngine2D_RenderAsTexture_Clockwork_Graphics_Texture_"></a> RenderAsTexture\(Texture\)

```csharp
public void RenderAsTexture(Texture texture2D)
```

#### Parameters

`texture2D` [Texture](Clockwork.Graphics.Texture.md)

### <a id="Clockwork_Particles_ParticleEngine2D_SpawnBurst_Clockwork_Particles_Particle2D_System_Int32_"></a> SpawnBurst\(Particle2D, int\)

```csharp
public void SpawnBurst(Particle2D particleTemplate, int count)
```

#### Parameters

`particleTemplate` [Particle2D](Clockwork.Particles.Particle2D.md)

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Particles_ParticleEngine2D_SpawnParticle_Clockwork_Particles_Particle2D_"></a> SpawnParticle\(Particle2D\)

```csharp
public void SpawnParticle(Particle2D particleTemplate)
```

#### Parameters

`particleTemplate` [Particle2D](Clockwork.Particles.Particle2D.md)

### <a id="Clockwork_Particles_ParticleEngine2D_Exhausted"></a> Exhausted

```csharp
public event ParticleEngine2D.ExhaustedDelegate Exhausted
```

#### Event Type

 [ParticleEngine2D](Clockwork.Particles.ParticleEngine2D.md).[ExhaustedDelegate](Clockwork.Particles.ParticleEngine2D.ExhaustedDelegate.md)

### <a id="Clockwork_Particles_ParticleEngine2D_StreamFired"></a> StreamFired

```csharp
public event ParticleEngine2D.StreamFiredDelegate StreamFired
```

#### Event Type

 [ParticleEngine2D](Clockwork.Particles.ParticleEngine2D.md).[StreamFiredDelegate](Clockwork.Particles.ParticleEngine2D.StreamFiredDelegate.md)

