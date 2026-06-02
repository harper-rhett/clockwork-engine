# <a id="Clockwork_Utilities_Translation2D"></a> Class Translation2D

Namespace: [Clockwork.Utilities](Clockwork.Utilities.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class Translation2D : ITranslation2D
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Translation2D](Clockwork.Utilities.Translation2D.md)

#### Implements

[ITranslation2D](Clockwork.Utilities.ITranslation2D.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Fields

### <a id="Clockwork_Utilities_Translation2D_Parent"></a> Parent

```csharp
public Translation2D Parent
```

#### Field Value

 [Translation2D](Clockwork.Utilities.Translation2D.md)

## Properties

### <a id="Clockwork_Utilities_Translation2D_LocalPosition"></a> LocalPosition

```csharp
public Vector2 LocalPosition { get; set; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_Utilities_Translation2D_Matrix"></a> Matrix

```csharp
public Matrix3x2 Matrix { get; }
```

#### Property Value

 [Matrix3x2](https://learn.microsoft.com/dotnet/api/system.numerics.matrix3x2)

### <a id="Clockwork_Utilities_Translation2D_MatrixInverse"></a> MatrixInverse

```csharp
public Matrix3x2 MatrixInverse { get; }
```

#### Property Value

 [Matrix3x2](https://learn.microsoft.com/dotnet/api/system.numerics.matrix3x2)

### <a id="Clockwork_Utilities_Translation2D_WorldPosition"></a> WorldPosition

```csharp
public Vector2 WorldPosition { get; set; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

## Methods

### <a id="Clockwork_Utilities_Translation2D_GetTranslation_System_Numerics_Vector2_"></a> GetTranslation\(Vector2\)

```csharp
public static Matrix3x2 GetTranslation(Vector2 localPosition)
```

#### Parameters

`localPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [Matrix3x2](https://learn.microsoft.com/dotnet/api/system.numerics.matrix3x2)

