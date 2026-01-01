# <a id="Clockwork_Graphics_Texture"></a> Struct Texture

Namespace: [Clockwork.Graphics](Clockwork.Graphics.md)  
Assembly: ClockworkEngine.dll  

```csharp
public struct Texture : IDisposable
```

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Fields

### <a id="Clockwork_Graphics_Texture_Format"></a> Format

```csharp
public PixelFormat Format
```

#### Field Value

 [PixelFormat](Clockwork.Graphics.PixelFormat.md)

### <a id="Clockwork_Graphics_Texture_Height"></a> Height

```csharp
public int Height
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Graphics_Texture_Id"></a> Id

```csharp
public uint Id
```

#### Field Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Clockwork_Graphics_Texture_Mipmaps"></a> Mipmaps

```csharp
public int Mipmaps
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Graphics_Texture_Width"></a> Width

```csharp
public int Width
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Clockwork_Graphics_Texture_IsValid"></a> IsValid

```csharp
public bool IsValid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Clockwork_Graphics_Texture_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="Clockwork_Graphics_Texture_Draw_System_Int32_System_Int32_Clockwork_Graphics_Color_"></a> Draw\(int, int, Color\)

```csharp
public void Draw(int x, int y, Color color)
```

#### Parameters

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`color` [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Graphics_Texture_Draw_System_Numerics_Vector2_Clockwork_Graphics_Color_"></a> Draw\(Vector2, Color\)

```csharp
public void Draw(Vector2 position, Color color)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`color` [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Graphics_Texture_Draw_Clockwork_Graphics_Rectangle_System_Numerics_Vector2_Clockwork_Graphics_Color_"></a> Draw\(Rectangle, Vector2, Color\)

```csharp
public void Draw(Rectangle source, Vector2 position, Color color)
```

#### Parameters

`source` [Rectangle](Clockwork.Graphics.Rectangle.md)

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`color` [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Graphics_Texture_Draw_Clockwork_Graphics_Rectangle_Clockwork_Graphics_Rectangle_System_Numerics_Vector2_System_Single_Clockwork_Graphics_Color_"></a> Draw\(Rectangle, Rectangle, Vector2, float, Color\)

```csharp
public void Draw(Rectangle source, Rectangle destination, Vector2 origin, float rotation, Color color)
```

#### Parameters

`source` [Rectangle](Clockwork.Graphics.Rectangle.md)

`destination` [Rectangle](Clockwork.Graphics.Rectangle.md)

`origin` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`rotation` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Graphics_Texture_DrawNinePatch_Clockwork_Graphics_NinePatch_Clockwork_Graphics_Rectangle_System_Numerics_Vector2_System_Single_Clockwork_Graphics_Color_"></a> DrawNinePatch\(NinePatch, Rectangle, Vector2, float, Color\)

```csharp
public void DrawNinePatch(NinePatch ninePatch, Rectangle destination, Vector2 origin, float rotation, Color color)
```

#### Parameters

`ninePatch` [NinePatch](Clockwork.Graphics.NinePatch.md)

`destination` [Rectangle](Clockwork.Graphics.Rectangle.md)

`origin` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`rotation` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Graphics_Texture_Load_System_String_"></a> Load\(string\)

```csharp
public static extern Texture Load(string filePath)
```

#### Parameters

`filePath` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [Texture](Clockwork.Graphics.Texture.md)

### <a id="Clockwork_Graphics_Texture_Load_Clockwork_Graphics_Image_"></a> Load\(Image\)

```csharp
public static extern Texture Load(Image image)
```

#### Parameters

`image` [Image](Clockwork.Graphics.Image.md)

#### Returns

 [Texture](Clockwork.Graphics.Texture.md)

### <a id="Clockwork_Graphics_Texture_SetFilter_Clockwork_Graphics_TextureFilter_"></a> SetFilter\(TextureFilter\)

```csharp
public void SetFilter(TextureFilter textureFilter)
```

#### Parameters

`textureFilter` [TextureFilter](Clockwork.Graphics.TextureFilter.md)

