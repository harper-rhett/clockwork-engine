# <a id="Clockwork_Graphics_Shader"></a> Class Shader

Namespace: [Clockwork.Graphics](Clockwork.Graphics.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class Shader : IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Shader](Clockwork.Graphics.Shader.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Clockwork_Graphics_Shader__ctor"></a> Shader\(\)

```csharp
public Shader()
```

### <a id="Clockwork_Graphics_Shader__ctor_System_String_System_String_"></a> Shader\(string, string\)

```csharp
public Shader(string vertexFileName, string fragmentFileName)
```

#### Parameters

`vertexFileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`fragmentFileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

## Properties

### <a id="Clockwork_Graphics_Shader_Data"></a> Data

```csharp
public ShaderData Data { get; }
```

#### Property Value

 [ShaderData](Clockwork.Graphics.ShaderData.md)

## Methods

### <a id="Clockwork_Graphics_Shader_BeginUsing_Clockwork_Graphics_Shader_"></a> BeginUsing\(Shader\)

```csharp
public static void BeginUsing(Shader shader)
```

#### Parameters

`shader` [Shader](Clockwork.Graphics.Shader.md)

### <a id="Clockwork_Graphics_Shader_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="Clockwork_Graphics_Shader_EndUsing"></a> EndUsing\(\)

```csharp
public static void EndUsing()
```

### <a id="Clockwork_Graphics_Shader_LoadFromCode_System_String_System_String_"></a> LoadFromCode\(string, string\)

```csharp
public void LoadFromCode(string vertexCode, string fragmentCode)
```

#### Parameters

`vertexCode` [string](https://learn.microsoft.com/dotnet/api/system.string)

`fragmentCode` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Clockwork_Graphics_Shader_LoadFromFile_System_String_System_String_"></a> LoadFromFile\(string, string\)

```csharp
public void LoadFromFile(string vertexFileName, string fragmentFileName)
```

#### Parameters

`vertexFileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`fragmentFileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Clockwork_Graphics_Shader_SetArray_System_String_System_IntPtr_Clockwork_Graphics_UniformDataType_System_Int32_"></a> SetArray\(string, nint, UniformDataType, int\)

```csharp
public void SetArray(string variableName, nint value, UniformDataType dataType, int count)
```

#### Parameters

`variableName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

`dataType` [UniformDataType](Clockwork.Graphics.UniformDataType.md)

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Graphics_Shader_SetFloat_System_String_System_Single_"></a> SetFloat\(string, float\)

```csharp
public void SetFloat(string variableName, float value)
```

#### Parameters

`variableName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Graphics_Shader_SetFloats_System_String_System_Single___"></a> SetFloats\(string, float\[\]\)

```csharp
public void SetFloats(string variableName, float[] values)
```

#### Parameters

`variableName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`values` [float](https://learn.microsoft.com/dotnet/api/system.single)\[\]

### <a id="Clockwork_Graphics_Shader_SetInteger_System_String_System_Int32_"></a> SetInteger\(string, int\)

```csharp
public void SetInteger(string variableName, int value)
```

#### Parameters

`variableName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Graphics_Shader_SetIntegers_System_String_System_Int32___"></a> SetIntegers\(string, int\[\]\)

```csharp
public void SetIntegers(string variableName, int[] values)
```

#### Parameters

`variableName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`values` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

### <a id="Clockwork_Graphics_Shader_SetMatrix_System_String_System_Numerics_Matrix4x4_"></a> SetMatrix\(string, Matrix4x4\)

```csharp
public void SetMatrix(string variableName, Matrix4x4 matrix)
```

#### Parameters

`variableName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`matrix` [Matrix4x4](https://learn.microsoft.com/dotnet/api/system.numerics.matrix4x4)

### <a id="Clockwork_Graphics_Shader_SetTexture_System_String_Clockwork_Graphics_Texture_"></a> SetTexture\(string, Texture\)

```csharp
public void SetTexture(string variableName, Texture texture)
```

#### Parameters

`variableName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`texture` [Texture](Clockwork.Graphics.Texture.md)

### <a id="Clockwork_Graphics_Shader_SetValue_System_String_System_IntPtr_Clockwork_Graphics_UniformDataType_"></a> SetValue\(string, nint, UniformDataType\)

```csharp
public void SetValue(string variableName, nint value, UniformDataType dataType)
```

#### Parameters

`variableName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

`dataType` [UniformDataType](Clockwork.Graphics.UniformDataType.md)

### <a id="Clockwork_Graphics_Shader_SetVector2_System_String_System_Numerics_Vector2_"></a> SetVector2\(string, Vector2\)

```csharp
public void SetVector2(string variableName, Vector2 value)
```

#### Parameters

`variableName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_Graphics_Shader_SetVector2s_System_String_System_Numerics_Vector2___"></a> SetVector2s\(string, Vector2\[\]\)

```csharp
public void SetVector2s(string variableName, Vector2[] values)
```

#### Parameters

`variableName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`values` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)\[\]

### <a id="Clockwork_Graphics_Shader_SetVector3_System_String_System_Numerics_Vector3_"></a> SetVector3\(string, Vector3\)

```csharp
public void SetVector3(string variableName, Vector3 value)
```

#### Parameters

`variableName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Clockwork_Graphics_Shader_SetVector3s_System_String_System_Numerics_Vector3___"></a> SetVector3s\(string, Vector3\[\]\)

```csharp
public void SetVector3s(string variableName, Vector3[] values)
```

#### Parameters

`variableName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`values` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)\[\]

### <a id="Clockwork_Graphics_Shader_SetVector4_System_String_System_Numerics_Vector4_"></a> SetVector4\(string, Vector4\)

```csharp
public void SetVector4(string variableName, Vector4 value)
```

#### Parameters

`variableName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

### <a id="Clockwork_Graphics_Shader_SetVector4s_System_String_System_Numerics_Vector4___"></a> SetVector4s\(string, Vector4\[\]\)

```csharp
public void SetVector4s(string variableName, Vector4[] values)
```

#### Parameters

`variableName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`values` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)\[\]

