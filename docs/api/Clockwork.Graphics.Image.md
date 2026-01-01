# <a id="Clockwork_Graphics_Image"></a> Struct Image

Namespace: [Clockwork.Graphics](Clockwork.Graphics.md)  
Assembly: ClockworkEngine.dll  

```csharp
public struct Image : IDisposable
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

### <a id="Clockwork_Graphics_Image_Data"></a> Data

```csharp
public void* Data
```

#### Field Value

 [void](https://learn.microsoft.com/dotnet/api/system.void)\*

### <a id="Clockwork_Graphics_Image_Format"></a> Format

```csharp
public PixelFormat Format
```

#### Field Value

 [PixelFormat](Clockwork.Graphics.PixelFormat.md)

### <a id="Clockwork_Graphics_Image_Height"></a> Height

```csharp
public int Height
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Graphics_Image_Mipmaps"></a> Mipmaps

```csharp
public int Mipmaps
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Graphics_Image_Width"></a> Width

```csharp
public int Width
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Clockwork_Graphics_Image_IsValid"></a> IsValid

```csharp
public bool IsValid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Clockwork_Graphics_Image_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="Clockwork_Graphics_Image_Export_System_String_System_Boolean__"></a> Export\(string, out bool\)

```csharp
public void Export(string fileName, out bool success)
```

#### Parameters

`fileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`success` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Graphics_Image_Load_System_String_"></a> Load\(string\)

```csharp
public static extern Image Load(string fileName)
```

#### Parameters

`fileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [Image](Clockwork.Graphics.Image.md)

### <a id="Clockwork_Graphics_Image_Load_Clockwork_Graphics_Texture_"></a> Load\(Texture\)

```csharp
public static extern Image Load(Texture texture)
```

#### Parameters

`texture` [Texture](Clockwork.Graphics.Texture.md)

#### Returns

 [Image](Clockwork.Graphics.Image.md)

### <a id="Clockwork_Graphics_Image_LoadRaw_System_String_System_Int32_System_Int32_Clockwork_Graphics_PixelFormat_System_Int32_"></a> LoadRaw\(string, int, int, PixelFormat, int\)

```csharp
public static extern Image LoadRaw(string fileName, int width, int height, PixelFormat pixelFormat, int headerSize)
```

#### Parameters

`fileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`pixelFormat` [PixelFormat](Clockwork.Graphics.PixelFormat.md)

`headerSize` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [Image](Clockwork.Graphics.Image.md)

