# <a id="Clockwork_Utilities_Rotation2D"></a> Class Rotation2D

Namespace: [Clockwork.Utilities](Clockwork.Utilities.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class Rotation2D : IRotation2D
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Rotation2D](Clockwork.Utilities.Rotation2D.md)

#### Implements

[IRotation2D](Clockwork.Utilities.IRotation2D.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Fields

### <a id="Clockwork_Utilities_Rotation2D_Parent"></a> Parent

```csharp
public Rotation2D Parent
```

#### Field Value

 [Rotation2D](Clockwork.Utilities.Rotation2D.md)

## Properties

### <a id="Clockwork_Utilities_Rotation2D_LocalRotation"></a> LocalRotation

```csharp
public float LocalRotation { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Utilities_Rotation2D_Matrix"></a> Matrix

```csharp
public Matrix3x2 Matrix { get; }
```

#### Property Value

 [Matrix3x2](https://learn.microsoft.com/dotnet/api/system.numerics.matrix3x2)

### <a id="Clockwork_Utilities_Rotation2D_MatrixInverse"></a> MatrixInverse

```csharp
public Matrix3x2 MatrixInverse { get; }
```

#### Property Value

 [Matrix3x2](https://learn.microsoft.com/dotnet/api/system.numerics.matrix3x2)

### <a id="Clockwork_Utilities_Rotation2D_WorldRotation"></a> WorldRotation

```csharp
public float WorldRotation { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Clockwork_Utilities_Rotation2D_GetRotation_System_Single_"></a> GetRotation\(float\)

```csharp
public static Matrix3x2 GetRotation(float localRotation)
```

#### Parameters

`localRotation` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Matrix3x2](https://learn.microsoft.com/dotnet/api/system.numerics.matrix3x2)

