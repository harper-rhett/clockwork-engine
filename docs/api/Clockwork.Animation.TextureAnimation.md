# <a id="Clockwork_Animation_TextureAnimation"></a> Class TextureAnimation

Namespace: [Clockwork.Animation](Clockwork.Animation.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class TextureAnimation
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TextureAnimation](Clockwork.Animation.TextureAnimation.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Clockwork_Animation_TextureAnimation__ctor_Clockwork_Graphics_Texture_System_Int32_System_Int32_System_Int32_System_Single_"></a> TextureAnimation\(Texture, int, int, int, float\)

```csharp
public TextureAnimation(Texture texture, int frameCount, int frameWidth, int frameHeight, float timePerFrame)
```

#### Parameters

`texture` [Texture](Clockwork.Graphics.Texture.md)

`frameCount` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`frameWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`frameHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`timePerFrame` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Fields

### <a id="Clockwork_Animation_TextureAnimation_IsPaused"></a> IsPaused

```csharp
public bool IsPaused
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Animation_TextureAnimation_PlayOnce"></a> PlayOnce

```csharp
public bool PlayOnce
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Animation_TextureAnimation_TimePerFrame"></a> TimePerFrame

```csharp
public float TimePerFrame
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Properties

### <a id="Clockwork_Animation_TextureAnimation_AnimationTime"></a> AnimationTime

```csharp
public float AnimationTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Animation_TextureAnimation_PlayTime"></a> PlayTime

```csharp
public float PlayTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Clockwork_Animation_TextureAnimation_Draw_System_Numerics_Vector2_System_Numerics_Vector2_Clockwork_Graphics_Color_"></a> Draw\(Vector2, Vector2, Color\)

```csharp
public void Draw(Vector2 position, Vector2 direction, Color color)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`direction` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`color` [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Animation_TextureAnimation_Reset"></a> Reset\(\)

```csharp
public void Reset()
```

