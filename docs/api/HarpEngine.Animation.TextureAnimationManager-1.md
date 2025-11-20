# <a id="HarpEngine_Animation_TextureAnimationManager_1"></a> Class TextureAnimationManager<AnimationID\>

Namespace: [HarpEngine.Animation](HarpEngine.Animation.md)  
Assembly: HarpEngine.dll  

```csharp
public class TextureAnimationManager<AnimationID> where AnimationID : Enum
```

#### Type Parameters

`AnimationID` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TextureAnimationManager<AnimationID\>](HarpEngine.Animation.TextureAnimationManager\-1.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Fields

### <a id="HarpEngine_Animation_TextureAnimationManager_1_CurrentAnimationID"></a> CurrentAnimationID

```csharp
public AnimationID CurrentAnimationID
```

#### Field Value

 AnimationID

## Properties

### <a id="HarpEngine_Animation_TextureAnimationManager_1_CurrentAnimation"></a> CurrentAnimation

```csharp
public TextureAnimation CurrentAnimation { get; }
```

#### Property Value

 [TextureAnimation](HarpEngine.Animation.TextureAnimation.md)

## Methods

### <a id="HarpEngine_Animation_TextureAnimationManager_1_Draw_System_Numerics_Vector2_System_Numerics_Vector2_HarpEngine_Graphics_Color_"></a> Draw\(Vector2, Vector2, Color\)

```csharp
public void Draw(Vector2 position, Vector2 direction, Color color)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`direction` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Animation_TextureAnimationManager_1_RegisterAnimation_HarpEngine_Animation_TextureAnimation__0_"></a> RegisterAnimation\(TextureAnimation, AnimationID\)

```csharp
public void RegisterAnimation(TextureAnimation animation, AnimationID id)
```

#### Parameters

`animation` [TextureAnimation](HarpEngine.Animation.TextureAnimation.md)

`id` AnimationID

