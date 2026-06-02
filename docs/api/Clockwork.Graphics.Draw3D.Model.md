# <a id="Clockwork_Graphics_Draw3D_Model"></a> Struct Model

Namespace: [Clockwork.Graphics.Draw3D](Clockwork.Graphics.Draw3D.md)  
Assembly: ClockworkEngine.dll  

```csharp
public struct Model : IDisposable
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

## Constructors

### <a id="Clockwork_Graphics_Draw3D_Model__ctor"></a> Model\(\)

```csharp
public Model()
```

## Fields

### <a id="Clockwork_Graphics_Draw3D_Model_BindPose"></a> BindPose

```csharp
public RaylibTransform* BindPose
```

#### Field Value

 [RaylibTransform](Clockwork.Graphics.Draw3D.RaylibTransform.md)\*

### <a id="Clockwork_Graphics_Draw3D_Model_BoneCount"></a> BoneCount

```csharp
public int BoneCount
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Graphics_Draw3D_Model_Bones"></a> Bones

```csharp
public BoneInfo* Bones
```

#### Field Value

 [BoneInfo](Clockwork.Graphics.Draw3D.BoneInfo.md)\*

### <a id="Clockwork_Graphics_Draw3D_Model_MaterialCount"></a> MaterialCount

```csharp
public int MaterialCount
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Graphics_Draw3D_Model_Materials"></a> Materials

```csharp
public MaterialData* Materials
```

#### Field Value

 [MaterialData](Clockwork.Graphics.Draw3D.MaterialData.md)\*

### <a id="Clockwork_Graphics_Draw3D_Model_MeshCount"></a> MeshCount

```csharp
public int MeshCount
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Graphics_Draw3D_Model_MeshMaterial"></a> MeshMaterial

```csharp
public int* MeshMaterial
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)\*

### <a id="Clockwork_Graphics_Draw3D_Model_Meshes"></a> Meshes

```csharp
public MeshData* Meshes
```

#### Field Value

 [MeshData](Clockwork.Graphics.Draw3D.MeshData.md)\*

### <a id="Clockwork_Graphics_Draw3D_Model_Transform"></a> Transform

```csharp
public Matrix4x4 Transform
```

#### Field Value

 [Matrix4x4](https://learn.microsoft.com/dotnet/api/system.numerics.matrix4x4)

## Properties

### <a id="Clockwork_Graphics_Draw3D_Model_IsValid"></a> IsValid

```csharp
public bool IsValid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Clockwork_Graphics_Draw3D_Model_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="Clockwork_Graphics_Draw3D_Model_Load_System_String_"></a> Load\(string\)

```csharp
public static extern Model Load(string fileName)
```

#### Parameters

`fileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [Model](Clockwork.Graphics.Draw3D.Model.md)

### <a id="Clockwork_Graphics_Draw3D_Model_LoadModel_Clockwork_Graphics_Draw3D_MeshData_"></a> LoadModel\(MeshData\)

```csharp
public static extern Model LoadModel(MeshData mesh)
```

#### Parameters

`mesh` [MeshData](Clockwork.Graphics.Draw3D.MeshData.md)

#### Returns

 [Model](Clockwork.Graphics.Draw3D.Model.md)

