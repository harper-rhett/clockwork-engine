# <a id="Clockwork_Graphics_Font"></a> Struct Font

Namespace: [Clockwork.Graphics](Clockwork.Graphics.md)  
Assembly: ClockworkEngine.dll  

```csharp
public struct Font : IDisposable
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

### <a id="Clockwork_Graphics_Font_BaseSize"></a> BaseSize

```csharp
public int BaseSize
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Graphics_Font_GlyphCount"></a> GlyphCount

```csharp
public int GlyphCount
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Graphics_Font_GlyphPadding"></a> GlyphPadding

```csharp
public int GlyphPadding
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Graphics_Font_Glyphs"></a> Glyphs

```csharp
public GlyphInfo* Glyphs
```

#### Field Value

 [GlyphInfo](Clockwork.Graphics.GlyphInfo.md)\*

### <a id="Clockwork_Graphics_Font_Recs"></a> Recs

```csharp
public Rectangle* Recs
```

#### Field Value

 [Rectangle](Clockwork.Graphics.Rectangle.md)\*

### <a id="Clockwork_Graphics_Font_Texture"></a> Texture

```csharp
public Texture Texture
```

#### Field Value

 [Texture](Clockwork.Graphics.Texture.md)

## Properties

### <a id="Clockwork_Graphics_Font_Default"></a> Default

```csharp
public static Font Default { get; }
```

#### Property Value

 [Font](Clockwork.Graphics.Font.md)

### <a id="Clockwork_Graphics_Font_IsValid"></a> IsValid

```csharp
public bool IsValid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Clockwork_Graphics_Font_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="Clockwork_Graphics_Font_Load_System_String_"></a> Load\(string\)

```csharp
public static extern Font Load(string fileName)
```

#### Parameters

`fileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [Font](Clockwork.Graphics.Font.md)

### <a id="Clockwork_Graphics_Font_Load_Clockwork_Graphics_Image_Clockwork_Graphics_Color_System_Int32_"></a> Load\(Image, Color, int\)

```csharp
public static extern Font Load(Image image, Color key, int firstCharacter)
```

#### Parameters

`image` [Image](Clockwork.Graphics.Image.md)

`key` [Color](Clockwork.Graphics.Color.md)

`firstCharacter` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [Font](Clockwork.Graphics.Font.md)

### <a id="Clockwork_Graphics_Font_Unload_Clockwork_Graphics_Font_"></a> Unload\(Font\)

```csharp
public static extern void Unload(Font font)
```

#### Parameters

`font` [Font](Clockwork.Graphics.Font.md)

