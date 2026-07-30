# <a id="Clockwork_Graphics_Draw2D_Sprite"></a> Class Sprite

Namespace: [Clockwork.Graphics.Draw2D](Clockwork.Graphics.Draw2D.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class Sprite
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Sprite](Clockwork.Graphics.Draw2D.Sprite.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Clockwork_Graphics_Draw2D_Sprite__ctor_System_String_"></a> Sprite\(string\)

```csharp
public Sprite(string filePath)
```

#### Parameters

`filePath` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Clockwork_Graphics_Draw2D_Sprite__ctor_System_String_System_Numerics_Vector2_System_Single_"></a> Sprite\(string, Vector2, float\)

```csharp
public Sprite(string filePath, Vector2 position, float rotation)
```

#### Parameters

`filePath` [string](https://learn.microsoft.com/dotnet/api/system.string)

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`rotation` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Fields

### <a id="Clockwork_Graphics_Draw2D_Sprite_Color"></a> Color

```csharp
public Color Color
```

#### Field Value

 [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Graphics_Draw2D_Sprite_Origin"></a> Origin

```csharp
public Vector2 Origin
```

#### Field Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_Graphics_Draw2D_Sprite_Transform"></a> Transform

```csharp
public Transform2D Transform
```

#### Field Value

 [Transform2D](Clockwork.Utilities.Transform2D.md)

## Properties

### <a id="Clockwork_Graphics_Draw2D_Sprite_HalfHeight"></a> HalfHeight

```csharp
public float HalfHeight { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Graphics_Draw2D_Sprite_HalfScaledHeight"></a> HalfScaledHeight

```csharp
public float HalfScaledHeight { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Graphics_Draw2D_Sprite_HalfScaledWidth"></a> HalfScaledWidth

```csharp
public float HalfScaledWidth { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Graphics_Draw2D_Sprite_HalfWidth"></a> HalfWidth

```csharp
public float HalfWidth { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Graphics_Draw2D_Sprite_Height"></a> Height

```csharp
public int Height { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Graphics_Draw2D_Sprite_Offset"></a> Offset

```csharp
public SpriteOffset Offset { get; set; }
```

#### Property Value

 [SpriteOffset](Clockwork.Graphics.Draw2D.SpriteOffset.md)

### <a id="Clockwork_Graphics_Draw2D_Sprite_Position"></a> Position

```csharp
public Vector2 Position { get; set; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_Graphics_Draw2D_Sprite_Rotation"></a> Rotation

```csharp
public float Rotation { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Graphics_Draw2D_Sprite_Scale"></a> Scale

```csharp
public Vector2 Scale { get; set; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_Graphics_Draw2D_Sprite_ScaledHeight"></a> ScaledHeight

```csharp
public float ScaledHeight { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Graphics_Draw2D_Sprite_ScaledWidth"></a> ScaledWidth

```csharp
public float ScaledWidth { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Graphics_Draw2D_Sprite_Width"></a> Width

```csharp
public int Width { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Graphics_Draw2D_Sprite_WorldRectangle"></a> WorldRectangle

```csharp
public Rectangle WorldRectangle { get; }
```

#### Property Value

 [Rectangle](Clockwork.Graphics.Rectangle.md)

## Methods

### <a id="Clockwork_Graphics_Draw2D_Sprite_Draw"></a> Draw\(\)

```csharp
public void Draw()
```

### <a id="Clockwork_Graphics_Draw2D_Sprite_LoadTexture_System_String_"></a> LoadTexture\(string\)

```csharp
public void LoadTexture(string filePath)
```

#### Parameters

`filePath` [string](https://learn.microsoft.com/dotnet/api/system.string)

