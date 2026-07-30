# <a id="Clockwork_Graphics_Color"></a> Struct Color

Namespace: [Clockwork.Graphics](Clockwork.Graphics.md)  
Assembly: ClockworkEngine.dll  

```csharp
public struct Color
```

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Clockwork_Graphics_Color__ctor"></a> Color\(\)

```csharp
public Color()
```

### <a id="Clockwork_Graphics_Color__ctor_System_Byte_System_Byte_System_Byte_System_Byte_"></a> Color\(byte, byte, byte, byte\)

```csharp
public Color(byte r, byte g, byte b, byte a)
```

#### Parameters

`r` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

`g` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

`b` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

`a` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

### <a id="Clockwork_Graphics_Color__ctor_System_Byte_System_Byte_System_Byte_"></a> Color\(byte, byte, byte\)

```csharp
public Color(byte r, byte g, byte b)
```

#### Parameters

`r` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

`g` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

`b` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

### <a id="Clockwork_Graphics_Color__ctor_System_Int32_System_Int32_System_Int32_System_Int32_"></a> Color\(int, int, int, int\)

```csharp
public Color(int r, int g, int b, int a)
```

#### Parameters

`r` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`g` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`b` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`a` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Graphics_Color__ctor_System_Int32_System_Int32_System_Int32_"></a> Color\(int, int, int\)

```csharp
public Color(int r, int g, int b)
```

#### Parameters

`r` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`g` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`b` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Graphics_Color__ctor_System_Single_System_Single_System_Single_System_Single_"></a> Color\(float, float, float, float\)

```csharp
public Color(float r, float g, float b, float a)
```

#### Parameters

`r` [float](https://learn.microsoft.com/dotnet/api/system.single)

`g` [float](https://learn.microsoft.com/dotnet/api/system.single)

`b` [float](https://learn.microsoft.com/dotnet/api/system.single)

`a` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Graphics_Color__ctor_System_Single_System_Single_System_Single_"></a> Color\(float, float, float\)

```csharp
public Color(float r, float g, float b)
```

#### Parameters

`r` [float](https://learn.microsoft.com/dotnet/api/system.single)

`g` [float](https://learn.microsoft.com/dotnet/api/system.single)

`b` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Fields

### <a id="Clockwork_Graphics_Color_A"></a> A

```csharp
public byte A
```

#### Field Value

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)

### <a id="Clockwork_Graphics_Color_B"></a> B

```csharp
public byte B
```

#### Field Value

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)

### <a id="Clockwork_Graphics_Color_G"></a> G

```csharp
public byte G
```

#### Field Value

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)

### <a id="Clockwork_Graphics_Color_R"></a> R

```csharp
public byte R
```

#### Field Value

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)

## Methods

### <a id="Clockwork_Graphics_Color_DropAlpha"></a> DropAlpha\(\)

```csharp
public Color DropAlpha()
```

#### Returns

 [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Graphics_Color_Equals_System_Object_"></a> Equals\(object\)

Indicates whether this instance and a specified object are equal.

```csharp
public override bool Equals(object otherObject)
```

#### Parameters

`otherObject` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if <code class="paramref">obj</code> and this instance are the same type and represent the same value; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="Clockwork_Graphics_Color_GetHashCode"></a> GetHashCode\(\)

Returns the hash code for this instance.

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A 32-bit signed integer that is the hash code for this instance.

### <a id="Clockwork_Graphics_Color_Lerp_Clockwork_Graphics_Color_Clockwork_Graphics_Color_System_Single_"></a> Lerp\(Color, Color, float\)

```csharp
public static Color Lerp(Color from, Color to, float amount)
```

#### Parameters

`from` [Color](Clockwork.Graphics.Color.md)

`to` [Color](Clockwork.Graphics.Color.md)

`amount` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Graphics_Color_Mix_Clockwork_Graphics_Color_Clockwork_Graphics_Color_"></a> Mix\(Color, Color\)

```csharp
public static Color Mix(Color firstColor, Color secondColor)
```

#### Parameters

`firstColor` [Color](Clockwork.Graphics.Color.md)

`secondColor` [Color](Clockwork.Graphics.Color.md)

#### Returns

 [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Graphics_Color_SetAlpha_System_Byte_"></a> SetAlpha\(byte\)

```csharp
public Color SetAlpha(byte alpha)
```

#### Parameters

`alpha` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

#### Returns

 [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Graphics_Color_SetAlpha_System_Single_"></a> SetAlpha\(float\)

```csharp
public Color SetAlpha(float alpha)
```

#### Parameters

`alpha` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Graphics_Color_ToString"></a> ToString\(\)

Returns the fully qualified type name of this instance.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The fully qualified type name.

## Operators

### <a id="Clockwork_Graphics_Color_op_Equality_Clockwork_Graphics_Color_Clockwork_Graphics_Color_"></a> operator ==\(Color, Color\)

```csharp
public static bool operator ==(Color leftColor, Color rightColor)
```

#### Parameters

`leftColor` [Color](Clockwork.Graphics.Color.md)

`rightColor` [Color](Clockwork.Graphics.Color.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Graphics_Color_op_Inequality_Clockwork_Graphics_Color_Clockwork_Graphics_Color_"></a> operator \!=\(Color, Color\)

```csharp
public static bool operator !=(Color leftColor, Color rightColor)
```

#### Parameters

`leftColor` [Color](Clockwork.Graphics.Color.md)

`rightColor` [Color](Clockwork.Graphics.Color.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

