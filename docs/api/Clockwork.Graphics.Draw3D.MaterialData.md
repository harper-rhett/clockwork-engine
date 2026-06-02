# <a id="Clockwork_Graphics_Draw3D_MaterialData"></a> Struct MaterialData

Namespace: [Clockwork.Graphics.Draw3D](Clockwork.Graphics.Draw3D.md)  
Assembly: ClockworkEngine.dll  

```csharp
public struct MaterialData : IDisposable
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

### <a id="Clockwork_Graphics_Draw3D_MaterialData_Maps"></a> Maps

```csharp
public MaterialMap* Maps
```

#### Field Value

 [MaterialMap](Clockwork.Graphics.Draw3D.MaterialMap.md)\*

### <a id="Clockwork_Graphics_Draw3D_MaterialData_Param"></a> Param

```csharp
public float* Param
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)\*

### <a id="Clockwork_Graphics_Draw3D_MaterialData_Shader"></a> Shader

```csharp
public ShaderData Shader
```

#### Field Value

 [ShaderData](Clockwork.Graphics.ShaderData.md)

## Properties

### <a id="Clockwork_Graphics_Draw3D_MaterialData_IsValid"></a> IsValid

```csharp
public bool IsValid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Clockwork_Graphics_Draw3D_MaterialData_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="Clockwork_Graphics_Draw3D_MaterialData_LoadDefault"></a> LoadDefault\(\)

```csharp
public static extern MaterialData LoadDefault()
```

#### Returns

 [MaterialData](Clockwork.Graphics.Draw3D.MaterialData.md)

