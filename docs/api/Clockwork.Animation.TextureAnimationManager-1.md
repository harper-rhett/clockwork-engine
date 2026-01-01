# <a id="Clockwork_Animation_TextureAnimationManager_1"></a> Class TextureAnimationManager<AnimationState\>

Namespace: [Clockwork.Animation](Clockwork.Animation.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class TextureAnimationManager<AnimationState> where AnimationState : Enum
```

#### Type Parameters

`AnimationState` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TextureAnimationManager<AnimationState\>](Clockwork.Animation.TextureAnimationManager\-1.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Fields

### <a id="Clockwork_Animation_TextureAnimationManager_1_State"></a> State

```csharp
public AnimationState State
```

#### Field Value

 AnimationState

## Properties

### <a id="Clockwork_Animation_TextureAnimationManager_1_CurrentAnimation"></a> CurrentAnimation

```csharp
public TextureAnimation CurrentAnimation { get; }
```

#### Property Value

 [TextureAnimation](Clockwork.Animation.TextureAnimation.md)

## Methods

### <a id="Clockwork_Animation_TextureAnimationManager_1_Draw_System_Numerics_Vector2_System_Numerics_Vector2_Clockwork_Graphics_Color_"></a> Draw\(Vector2, Vector2, Color\)

```csharp
public void Draw(Vector2 position, Vector2 direction, Color color)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`direction` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`color` [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Animation_TextureAnimationManager_1_RegisterAnimation_Clockwork_Animation_TextureAnimation__0_"></a> RegisterAnimation\(TextureAnimation, AnimationState\)

```csharp
public void RegisterAnimation(TextureAnimation animation, AnimationState id)
```

#### Parameters

`animation` [TextureAnimation](Clockwork.Animation.TextureAnimation.md)

`id` AnimationState

