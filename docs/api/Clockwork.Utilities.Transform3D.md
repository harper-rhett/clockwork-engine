# <a id="Clockwork_Utilities_Transform3D"></a> Class Transform3D

Namespace: [Clockwork.Utilities](Clockwork.Utilities.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class Transform3D
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Transform3D](Clockwork.Utilities.Transform3D.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Clockwork_Utilities_Transform3D__ctor"></a> Transform3D\(\)

```csharp
public Transform3D()
```

### <a id="Clockwork_Utilities_Transform3D__ctor_System_Numerics_Vector3_System_Numerics_Quaternion_"></a> Transform3D\(Vector3, Quaternion\)

```csharp
public Transform3D(Vector3 position, Quaternion rotation)
```

#### Parameters

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`rotation` [Quaternion](https://learn.microsoft.com/dotnet/api/system.numerics.quaternion)

## Fields

### <a id="Clockwork_Utilities_Transform3D_LocalPosition"></a> LocalPosition

```csharp
public Vector3 LocalPosition
```

#### Field Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Clockwork_Utilities_Transform3D_LocalRotation"></a> LocalRotation

```csharp
public Quaternion LocalRotation
```

#### Field Value

 [Quaternion](https://learn.microsoft.com/dotnet/api/system.numerics.quaternion)

### <a id="Clockwork_Utilities_Transform3D_Parent"></a> Parent

```csharp
public Transform3D Parent
```

#### Field Value

 [Transform3D](Clockwork.Utilities.Transform3D.md)

## Properties

### <a id="Clockwork_Utilities_Transform3D_Back"></a> Back

```csharp
public Vector3 Back { get; }
```

#### Property Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Clockwork_Utilities_Transform3D_Down"></a> Down

```csharp
public Vector3 Down { get; }
```

#### Property Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Clockwork_Utilities_Transform3D_Forward"></a> Forward

```csharp
public Vector3 Forward { get; }
```

#### Property Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Clockwork_Utilities_Transform3D_Left"></a> Left

```csharp
public Vector3 Left { get; }
```

#### Property Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Clockwork_Utilities_Transform3D_Matrix"></a> Matrix

```csharp
public Matrix4x4 Matrix { get; }
```

#### Property Value

 [Matrix4x4](https://learn.microsoft.com/dotnet/api/system.numerics.matrix4x4)

### <a id="Clockwork_Utilities_Transform3D_MatrixInverse"></a> MatrixInverse

```csharp
public Matrix4x4 MatrixInverse { get; }
```

#### Property Value

 [Matrix4x4](https://learn.microsoft.com/dotnet/api/system.numerics.matrix4x4)

### <a id="Clockwork_Utilities_Transform3D_Right"></a> Right

```csharp
public Vector3 Right { get; }
```

#### Property Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Clockwork_Utilities_Transform3D_Up"></a> Up

```csharp
public Vector3 Up { get; }
```

#### Property Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Clockwork_Utilities_Transform3D_WorldPosition"></a> WorldPosition

```csharp
public Vector3 WorldPosition { get; set; }
```

#### Property Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Clockwork_Utilities_Transform3D_WorldRotation"></a> WorldRotation

```csharp
public Quaternion WorldRotation { get; set; }
```

#### Property Value

 [Quaternion](https://learn.microsoft.com/dotnet/api/system.numerics.quaternion)

