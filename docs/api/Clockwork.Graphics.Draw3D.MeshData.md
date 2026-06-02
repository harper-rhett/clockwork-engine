# <a id="Clockwork_Graphics_Draw3D_MeshData"></a> Struct MeshData

Namespace: [Clockwork.Graphics.Draw3D](Clockwork.Graphics.Draw3D.md)  
Assembly: ClockworkEngine.dll  

```csharp
public struct MeshData : IDisposable
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

### <a id="Clockwork_Graphics_Draw3D_MeshData__ctor_System_Int32_System_Int32_"></a> MeshData\(int, int\)

```csharp
public MeshData(int vertexCount, int triangleCount)
```

#### Parameters

`vertexCount` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`triangleCount` [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Fields

### <a id="Clockwork_Graphics_Draw3D_MeshData_AnimNormals"></a> AnimNormals

```csharp
public float* AnimNormals
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)\*

### <a id="Clockwork_Graphics_Draw3D_MeshData_AnimVertices"></a> AnimVertices

```csharp
public float* AnimVertices
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)\*

### <a id="Clockwork_Graphics_Draw3D_MeshData_BoneCount"></a> BoneCount

```csharp
public int BoneCount
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Graphics_Draw3D_MeshData_BoneIds"></a> BoneIds

```csharp
public byte* BoneIds
```

#### Field Value

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)\*

### <a id="Clockwork_Graphics_Draw3D_MeshData_BoneMatrices"></a> BoneMatrices

```csharp
public Matrix4x4* BoneMatrices
```

#### Field Value

 [Matrix4x4](https://learn.microsoft.com/dotnet/api/system.numerics.matrix4x4)\*

### <a id="Clockwork_Graphics_Draw3D_MeshData_BoneWeights"></a> BoneWeights

```csharp
public float* BoneWeights
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)\*

### <a id="Clockwork_Graphics_Draw3D_MeshData_Colors"></a> Colors

```csharp
public byte* Colors
```

#### Field Value

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)\*

### <a id="Clockwork_Graphics_Draw3D_MeshData_Indices"></a> Indices

```csharp
public ushort* Indices
```

#### Field Value

 [ushort](https://learn.microsoft.com/dotnet/api/system.uint16)\*

### <a id="Clockwork_Graphics_Draw3D_MeshData_Normals"></a> Normals

```csharp
public float* Normals
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)\*

### <a id="Clockwork_Graphics_Draw3D_MeshData_Tangents"></a> Tangents

```csharp
public float* Tangents
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)\*

### <a id="Clockwork_Graphics_Draw3D_MeshData_TexCoords"></a> TexCoords

```csharp
public float* TexCoords
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)\*

### <a id="Clockwork_Graphics_Draw3D_MeshData_TexCoords2"></a> TexCoords2

```csharp
public float* TexCoords2
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)\*

### <a id="Clockwork_Graphics_Draw3D_MeshData_TriangleCount"></a> TriangleCount

```csharp
public int TriangleCount
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Graphics_Draw3D_MeshData_VaoId"></a> VaoId

```csharp
public uint VaoId
```

#### Field Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Clockwork_Graphics_Draw3D_MeshData_VboId"></a> VboId

```csharp
public uint* VboId
```

#### Field Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)\*

### <a id="Clockwork_Graphics_Draw3D_MeshData_VboIdIndexColors"></a> VboIdIndexColors

```csharp
public const int VboIdIndexColors = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Graphics_Draw3D_MeshData_VboIdIndexIndices"></a> VboIdIndexIndices

```csharp
public const int VboIdIndexIndices = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Graphics_Draw3D_MeshData_VboIdIndexNormals"></a> VboIdIndexNormals

```csharp
public const int VboIdIndexNormals = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Graphics_Draw3D_MeshData_VboIdIndexTangents"></a> VboIdIndexTangents

```csharp
public const int VboIdIndexTangents = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Graphics_Draw3D_MeshData_VboIdIndexTexCoords"></a> VboIdIndexTexCoords

```csharp
public const int VboIdIndexTexCoords = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Graphics_Draw3D_MeshData_VboIdIndexTexCoords2"></a> VboIdIndexTexCoords2

```csharp
public const int VboIdIndexTexCoords2 = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Graphics_Draw3D_MeshData_VboIdIndexVertices"></a> VboIdIndexVertices

```csharp
public const int VboIdIndexVertices = 0
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Graphics_Draw3D_MeshData_VertexCount"></a> VertexCount

```csharp
public int VertexCount
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Graphics_Draw3D_MeshData_Vertices"></a> Vertices

```csharp
public float* Vertices
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)\*

## Methods

### <a id="Clockwork_Graphics_Draw3D_MeshData_AllocColors"></a> AllocColors\(\)

```csharp
public void AllocColors()
```

### <a id="Clockwork_Graphics_Draw3D_MeshData_AllocIndices"></a> AllocIndices\(\)

```csharp
public void AllocIndices()
```

### <a id="Clockwork_Graphics_Draw3D_MeshData_AllocNormals"></a> AllocNormals\(\)

```csharp
public void AllocNormals()
```

### <a id="Clockwork_Graphics_Draw3D_MeshData_AllocTangents"></a> AllocTangents\(\)

```csharp
public void AllocTangents()
```

### <a id="Clockwork_Graphics_Draw3D_MeshData_AllocTexCoords"></a> AllocTexCoords\(\)

```csharp
public void AllocTexCoords()
```

### <a id="Clockwork_Graphics_Draw3D_MeshData_AllocTexCoords2"></a> AllocTexCoords2\(\)

```csharp
public void AllocTexCoords2()
```

### <a id="Clockwork_Graphics_Draw3D_MeshData_AllocVertices"></a> AllocVertices\(\)

```csharp
public void AllocVertices()
```

### <a id="Clockwork_Graphics_Draw3D_MeshData_ColorsAs__1"></a> ColorsAs<T\>\(\)

```csharp
public readonly Span<T> ColorsAs<T>() where T : unmanaged
```

#### Returns

 [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<T\>

#### Type Parameters

`T` 

### <a id="Clockwork_Graphics_Draw3D_MeshData_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="Clockwork_Graphics_Draw3D_MeshData_Draw_Clockwork_Graphics_Draw3D_MaterialData_System_Numerics_Matrix4x4_"></a> Draw\(MaterialData, Matrix4x4\)

```csharp
public void Draw(MaterialData materialData, Matrix4x4 matrix)
```

#### Parameters

`materialData` [MaterialData](Clockwork.Graphics.Draw3D.MaterialData.md)

`matrix` [Matrix4x4](https://learn.microsoft.com/dotnet/api/system.numerics.matrix4x4)

### <a id="Clockwork_Graphics_Draw3D_MeshData_Draw_Clockwork_Graphics_Draw3D_MaterialData_Clockwork_Utilities_Transform3D_"></a> Draw\(MaterialData, Transform3D\)

```csharp
public void Draw(MaterialData materialData, Transform3D transform)
```

#### Parameters

`materialData` [MaterialData](Clockwork.Graphics.Draw3D.MaterialData.md)

`transform` [Transform3D](Clockwork.Utilities.Transform3D.md)

### <a id="Clockwork_Graphics_Draw3D_MeshData_GenerateBox_System_Single_System_Single_System_Single_"></a> GenerateBox\(float, float, float\)

```csharp
public static extern MeshData GenerateBox(float width, float height, float length)
```

#### Parameters

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

`height` [float](https://learn.microsoft.com/dotnet/api/system.single)

`length` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [MeshData](Clockwork.Graphics.Draw3D.MeshData.md)

### <a id="Clockwork_Graphics_Draw3D_MeshData_GenerateSphere_System_Single_System_Int32_System_Int32_"></a> GenerateSphere\(float, int, int\)

```csharp
public static extern MeshData GenerateSphere(float radius, int rings, int slices)
```

#### Parameters

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`rings` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`slices` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [MeshData](Clockwork.Graphics.Draw3D.MeshData.md)

### <a id="Clockwork_Graphics_Draw3D_MeshData_IndicesAs__1"></a> IndicesAs<T\>\(\)

```csharp
public readonly Span<T> IndicesAs<T>() where T : unmanaged
```

#### Returns

 [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<T\>

#### Type Parameters

`T` 

### <a id="Clockwork_Graphics_Draw3D_MeshData_NormalsAs__1"></a> NormalsAs<T\>\(\)

```csharp
public readonly Span<T> NormalsAs<T>() where T : unmanaged
```

#### Returns

 [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<T\>

#### Type Parameters

`T` 

### <a id="Clockwork_Graphics_Draw3D_MeshData_TangentsAs__1"></a> TangentsAs<T\>\(\)

```csharp
public readonly Span<T> TangentsAs<T>() where T : unmanaged
```

#### Returns

 [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<T\>

#### Type Parameters

`T` 

### <a id="Clockwork_Graphics_Draw3D_MeshData_TexCoords2As__1"></a> TexCoords2As<T\>\(\)

```csharp
public readonly Span<T> TexCoords2As<T>() where T : unmanaged
```

#### Returns

 [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<T\>

#### Type Parameters

`T` 

### <a id="Clockwork_Graphics_Draw3D_MeshData_TexCoordsAs__1"></a> TexCoordsAs<T\>\(\)

```csharp
public readonly Span<T> TexCoordsAs<T>() where T : unmanaged
```

#### Returns

 [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<T\>

#### Type Parameters

`T` 

### <a id="Clockwork_Graphics_Draw3D_MeshData_VerticesAs__1"></a> VerticesAs<T\>\(\)

```csharp
public readonly Span<T> VerticesAs<T>() where T : unmanaged
```

#### Returns

 [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<T\>

#### Type Parameters

`T` 

