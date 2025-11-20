# <a id="HarpEngine_Audio_MusicPlayer"></a> Class MusicPlayer

Namespace: [HarpEngine.Audio](HarpEngine.Audio.md)  
Assembly: HarpEngine.dll  

```csharp
public class MusicPlayer : Entity
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](HarpEngine.Entity.md) ← 
[MusicPlayer](HarpEngine.Audio.MusicPlayer.md)

#### Inherited Members

[Entity.Scene](HarpEngine.Entity.md\#HarpEngine\_Entity\_Scene), 
[Entity.IsUpdating](HarpEngine.Entity.md\#HarpEngine\_Entity\_IsUpdating), 
[Entity.IsRendering](HarpEngine.Entity.md\#HarpEngine\_Entity\_IsRendering), 
[Entity.UpdateLayer](HarpEngine.Entity.md\#HarpEngine\_Entity\_UpdateLayer), 
[Entity.DrawLayer](HarpEngine.Entity.md\#HarpEngine\_Entity\_DrawLayer), 
[Entity.OnUpdate\(\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_OnUpdate), 
[Entity.OnDraw\(\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_OnDraw), 
[Entity.OnDrawGUI\(\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_OnDrawGUI), 
[Entity.Remove\(\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_Remove), 
[Entity.OnAddedToScene\(\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_OnAddedToScene), 
[Entity.OnRemovedFromScene\(\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_OnRemovedFromScene), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="HarpEngine_Audio_MusicPlayer__ctor_HarpEngine_Audio_Music_"></a> MusicPlayer\(Music\)

```csharp
public MusicPlayer(Music music)
```

#### Parameters

`music` [Music](HarpEngine.Audio.Music.md)

## Fields

### <a id="HarpEngine_Audio_MusicPlayer_RemoveOnFinished"></a> RemoveOnFinished

```csharp
public bool RemoveOnFinished
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="HarpEngine_Audio_MusicPlayer_OnUpdate"></a> OnUpdate\(\)

```csharp
public override void OnUpdate()
```

### <a id="HarpEngine_Audio_MusicPlayer_Pause"></a> Pause\(\)

```csharp
public void Pause()
```

### <a id="HarpEngine_Audio_MusicPlayer_Resume"></a> Resume\(\)

```csharp
public void Resume()
```

### <a id="HarpEngine_Audio_MusicPlayer_Start"></a> Start\(\)

```csharp
public void Start()
```

### <a id="HarpEngine_Audio_MusicPlayer_Stop"></a> Stop\(\)

```csharp
public void Stop()
```

