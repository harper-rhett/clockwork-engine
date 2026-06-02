# <a id="Clockwork_Graphics_Draw3D_Mesh"></a> Class Mesh

Namespace: [Clockwork.Graphics.Draw3D](Clockwork.Graphics.Draw3D.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class Mesh : IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Mesh](Clockwork.Graphics.Draw3D.Mesh.md)

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

### <a id="Clockwork_Graphics_Draw3D_Mesh__ctor"></a> Mesh\(\)

```csharp
public Mesh()
```

### <a id="Clockwork_Graphics_Draw3D_Mesh__ctor_Clockwork_Graphics_Draw3D_MeshData_"></a> Mesh\(MeshData\)

```csharp
public Mesh(MeshData data)
```

#### Parameters

`data` [MeshData](Clockwork.Graphics.Draw3D.MeshData.md)

## Properties

### <a id="Clockwork_Graphics_Draw3D_Mesh_Data"></a> Data

```csharp
public MeshData Data { get; }
```

#### Property Value

 [MeshData](Clockwork.Graphics.Draw3D.MeshData.md)

## Methods

### <a id="Clockwork_Graphics_Draw3D_Mesh_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="Clockwork_Graphics_Draw3D_Mesh_Draw_Clockwork_Graphics_Draw3D_Material_System_Numerics_Matrix4x4_"></a> Draw\(Material, Matrix4x4\)

```csharp
public void Draw(Material material, Matrix4x4 matrix)
```

#### Parameters

`material` [Material](Clockwork.Graphics.Draw3D.Material.md)

`matrix` [Matrix4x4](https://learn.microsoft.com/dotnet/api/system.numerics.matrix4x4)

### <a id="Clockwork_Graphics_Draw3D_Mesh_Draw_Clockwork_Graphics_Draw3D_Material_Clockwork_Utilities_Transform3D_"></a> Draw\(Material, Transform3D\)

```csharp
public void Draw(Material material, Transform3D transform)
```

#### Parameters

`material` [Material](Clockwork.Graphics.Draw3D.Material.md)

`transform` [Transform3D](Clockwork.Utilities.Transform3D.md)

### <a id="Clockwork_Graphics_Draw3D_Mesh_GenerateBox_System_Single_System_Single_System_Single_"></a> GenerateBox\(float, float, float\)

```csharp
public static Mesh GenerateBox(float width, float height, float length)
```

#### Parameters

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

`height` [float](https://learn.microsoft.com/dotnet/api/system.single)

`length` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Mesh](Clockwork.Graphics.Draw3D.Mesh.md)

### <a id="Clockwork_Graphics_Draw3D_Mesh_GenerateSphere_System_Single_System_Int32_System_Int32_"></a> GenerateSphere\(float, int, int\)

```csharp
public static Mesh GenerateSphere(float radius, int rings, int slices)
```

#### Parameters

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`rings` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`slices` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [Mesh](Clockwork.Graphics.Draw3D.Mesh.md)

