# <a id="Clockwork_Graphics_ShaderData"></a> Struct ShaderData

Namespace: [Clockwork.Graphics](Clockwork.Graphics.md)  
Assembly: ClockworkEngine.dll  

```csharp
public struct ShaderData : IDisposable
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

### <a id="Clockwork_Graphics_ShaderData_ID"></a> ID

```csharp
public uint ID
```

#### Field Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Clockwork_Graphics_ShaderData_Locations"></a> Locations

```csharp
public int* Locations
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)\*

## Properties

### <a id="Clockwork_Graphics_ShaderData_IsValid"></a> IsValid

```csharp
public bool IsValid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Clockwork_Graphics_ShaderData_BeginUsing_Clockwork_Graphics_ShaderData_"></a> BeginUsing\(ShaderData\)

```csharp
public static extern void BeginUsing(ShaderData shaderData)
```

#### Parameters

`shaderData` [ShaderData](Clockwork.Graphics.ShaderData.md)

### <a id="Clockwork_Graphics_ShaderData_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="Clockwork_Graphics_ShaderData_EndUsing"></a> EndUsing\(\)

```csharp
public static extern void EndUsing()
```

### <a id="Clockwork_Graphics_ShaderData_GetVariableLocation_System_String_"></a> GetVariableLocation\(string\)

```csharp
public int GetVariableLocation(string variableName)
```

#### Parameters

`variableName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Graphics_ShaderData_LoadFromCode_System_String_System_String_"></a> LoadFromCode\(string, string\)

```csharp
public static extern ShaderData LoadFromCode(string vertexCode, string fragmentCode)
```

#### Parameters

`vertexCode` [string](https://learn.microsoft.com/dotnet/api/system.string)

`fragmentCode` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [ShaderData](Clockwork.Graphics.ShaderData.md)

### <a id="Clockwork_Graphics_ShaderData_LoadFromFile_System_String_System_String_"></a> LoadFromFile\(string, string\)

```csharp
public static extern ShaderData LoadFromFile(string vertexFileName, string fragmentFileName)
```

#### Parameters

`vertexFileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`fragmentFileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [ShaderData](Clockwork.Graphics.ShaderData.md)

### <a id="Clockwork_Graphics_ShaderData_SetArray_System_Int32_System_IntPtr_Clockwork_Graphics_UniformDataType_System_Int32_"></a> SetArray\(int, nint, UniformDataType, int\)

```csharp
public void SetArray(int location, nint value, UniformDataType dataType, int count)
```

#### Parameters

`location` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`value` [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

`dataType` [UniformDataType](Clockwork.Graphics.UniformDataType.md)

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Graphics_ShaderData_SetFloat_System_Int32_System_Single_"></a> SetFloat\(int, float\)

```csharp
public void SetFloat(int location, float value)
```

#### Parameters

`location` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Graphics_ShaderData_SetFloats_System_Int32_System_Single___"></a> SetFloats\(int, float\[\]\)

```csharp
public void SetFloats(int location, float[] values)
```

#### Parameters

`location` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`values` [float](https://learn.microsoft.com/dotnet/api/system.single)\[\]

### <a id="Clockwork_Graphics_ShaderData_SetInteger_System_Int32_System_Int32_"></a> SetInteger\(int, int\)

```csharp
public void SetInteger(int location, int value)
```

#### Parameters

`location` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`value` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Graphics_ShaderData_SetIntegers_System_Int32_System_Int32___"></a> SetIntegers\(int, int\[\]\)

```csharp
public void SetIntegers(int location, int[] values)
```

#### Parameters

`location` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`values` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

### <a id="Clockwork_Graphics_ShaderData_SetMatrix_System_Int32_System_Numerics_Matrix4x4_"></a> SetMatrix\(int, Matrix4x4\)

```csharp
public void SetMatrix(int location, Matrix4x4 matrix)
```

#### Parameters

`location` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`matrix` [Matrix4x4](https://learn.microsoft.com/dotnet/api/system.numerics.matrix4x4)

### <a id="Clockwork_Graphics_ShaderData_SetTexture_System_Int32_Clockwork_Graphics_Texture_"></a> SetTexture\(int, Texture\)

```csharp
public void SetTexture(int location, Texture texture)
```

#### Parameters

`location` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`texture` [Texture](Clockwork.Graphics.Texture.md)

### <a id="Clockwork_Graphics_ShaderData_SetValue_System_Int32_System_IntPtr_Clockwork_Graphics_UniformDataType_"></a> SetValue\(int, nint, UniformDataType\)

```csharp
public void SetValue(int location, nint value, UniformDataType dataType)
```

#### Parameters

`location` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`value` [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

`dataType` [UniformDataType](Clockwork.Graphics.UniformDataType.md)

### <a id="Clockwork_Graphics_ShaderData_SetVector2_System_Int32_System_Numerics_Vector2_"></a> SetVector2\(int, Vector2\)

```csharp
public void SetVector2(int location, Vector2 value)
```

#### Parameters

`location` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`value` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_Graphics_ShaderData_SetVector2s_System_Int32_System_Numerics_Vector2___"></a> SetVector2s\(int, Vector2\[\]\)

```csharp
public void SetVector2s(int location, Vector2[] values)
```

#### Parameters

`location` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`values` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)\[\]

### <a id="Clockwork_Graphics_ShaderData_SetVector3_System_Int32_System_Numerics_Vector3_"></a> SetVector3\(int, Vector3\)

```csharp
public void SetVector3(int location, Vector3 value)
```

#### Parameters

`location` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`value` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Clockwork_Graphics_ShaderData_SetVector3s_System_Int32_System_Numerics_Vector3___"></a> SetVector3s\(int, Vector3\[\]\)

```csharp
public void SetVector3s(int location, Vector3[] values)
```

#### Parameters

`location` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`values` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)\[\]

### <a id="Clockwork_Graphics_ShaderData_SetVector4_System_Int32_System_Numerics_Vector4_"></a> SetVector4\(int, Vector4\)

```csharp
public void SetVector4(int location, Vector4 value)
```

#### Parameters

`location` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`value` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

### <a id="Clockwork_Graphics_ShaderData_SetVector4s_System_Int32_System_Numerics_Vector4___"></a> SetVector4s\(int, Vector4\[\]\)

```csharp
public void SetVector4s(int location, Vector4[] values)
```

#### Parameters

`location` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`values` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)\[\]

