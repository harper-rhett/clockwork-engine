# <a id="HarpEngine_Animation_TextureAnimation"></a> Class TextureAnimation

Namespace: [HarpEngine.Animation](HarpEngine.Animation.md)  
Assembly: HarpEngine.dll  

```csharp
public class TextureAnimation
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TextureAnimation](HarpEngine.Animation.TextureAnimation.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="HarpEngine_Animation_TextureAnimation__ctor_HarpEngine_Graphics_Texture_System_Int32_System_Int32_System_Int32_System_Single_"></a> TextureAnimation\(Texture, int, int, int, float\)

```csharp
public TextureAnimation(Texture texture, int cellCount, int cellWidth, int cellHeight, float timePerCell)
```

#### Parameters

`texture` [Texture](HarpEngine.Graphics.Texture.md)

`cellCount` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`cellWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`cellHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`timePerCell` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Fields

### <a id="HarpEngine_Animation_TextureAnimation_PlayOnce"></a> PlayOnce

```csharp
public bool PlayOnce
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Properties

### <a id="HarpEngine_Animation_TextureAnimation_AnimationTime"></a> AnimationTime

```csharp
public float AnimationTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="HarpEngine_Animation_TextureAnimation_PlayTime"></a> PlayTime

```csharp
public float PlayTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="HarpEngine_Animation_TextureAnimation_Draw_System_Numerics_Vector2_System_Numerics_Vector2_HarpEngine_Graphics_Color_"></a> Draw\(Vector2, Vector2, Color\)

```csharp
public void Draw(Vector2 position, Vector2 direction, Color color)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`direction` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Animation_TextureAnimation_Reset"></a> Reset\(\)

```csharp
public void Reset()
```

