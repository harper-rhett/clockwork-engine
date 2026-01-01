# <a id="Clockwork_Audio_MusicPlayer"></a> Class MusicPlayer

Namespace: [Clockwork.Audio](Clockwork.Audio.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class MusicPlayer : Entity
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Clockwork.Entity.md) ← 
[MusicPlayer](Clockwork.Audio.MusicPlayer.md)

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

### <a id="Clockwork_Audio_MusicPlayer__ctor_Clockwork_Audio_Music_"></a> MusicPlayer\(Music\)

```csharp
public MusicPlayer(Music music)
```

#### Parameters

`music` [Music](Clockwork.Audio.Music.md)

## Fields

### <a id="Clockwork_Audio_MusicPlayer_RemoveOnFinished"></a> RemoveOnFinished

```csharp
public bool RemoveOnFinished
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Clockwork_Audio_MusicPlayer_OnUpdate"></a> OnUpdate\(\)

```csharp
public override void OnUpdate()
```

### <a id="Clockwork_Audio_MusicPlayer_Pause"></a> Pause\(\)

```csharp
public void Pause()
```

### <a id="Clockwork_Audio_MusicPlayer_Resume"></a> Resume\(\)

```csharp
public void Resume()
```

### <a id="Clockwork_Audio_MusicPlayer_Start"></a> Start\(\)

```csharp
public void Start()
```

### <a id="Clockwork_Audio_MusicPlayer_Stop"></a> Stop\(\)

```csharp
public void Stop()
```

