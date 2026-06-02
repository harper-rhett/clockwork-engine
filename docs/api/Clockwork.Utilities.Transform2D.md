# <a id="Clockwork_Utilities_Transform2D"></a> Class Transform2D

Namespace: [Clockwork.Utilities](Clockwork.Utilities.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class Transform2D : ITranslation2D, IRotation2D
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Transform2D](Clockwork.Utilities.Transform2D.md)

#### Implements

[ITranslation2D](Clockwork.Utilities.ITranslation2D.md), 
[IRotation2D](Clockwork.Utilities.IRotation2D.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Clockwork_Utilities_Transform2D__ctor"></a> Transform2D\(\)

```csharp
public Transform2D()
```

### <a id="Clockwork_Utilities_Transform2D__ctor_System_Numerics_Vector2_System_Single_"></a> Transform2D\(Vector2, float\)

```csharp
public Transform2D(Vector2 position, float rotation)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`rotation` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Fields

### <a id="Clockwork_Utilities_Transform2D_Parent"></a> Parent

```csharp
public Transform2D Parent
```

#### Field Value

 [Transform2D](Clockwork.Utilities.Transform2D.md)

## Properties

### <a id="Clockwork_Utilities_Transform2D_Down"></a> Down

```csharp
public Vector2 Down { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_Utilities_Transform2D_Left"></a> Left

```csharp
public Vector2 Left { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_Utilities_Transform2D_LocalPosition"></a> LocalPosition

```csharp
public Vector2 LocalPosition { get; set; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_Utilities_Transform2D_LocalRotation"></a> LocalRotation

```csharp
public float LocalRotation { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Utilities_Transform2D_Matrix"></a> Matrix

```csharp
public Matrix3x2 Matrix { get; }
```

#### Property Value

 [Matrix3x2](https://learn.microsoft.com/dotnet/api/system.numerics.matrix3x2)

### <a id="Clockwork_Utilities_Transform2D_MatrixInverse"></a> MatrixInverse

```csharp
public Matrix3x2 MatrixInverse { get; }
```

#### Property Value

 [Matrix3x2](https://learn.microsoft.com/dotnet/api/system.numerics.matrix3x2)

### <a id="Clockwork_Utilities_Transform2D_Right"></a> Right

```csharp
public Vector2 Right { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_Utilities_Transform2D_Up"></a> Up

```csharp
public Vector2 Up { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_Utilities_Transform2D_WorldPosition"></a> WorldPosition

```csharp
public Vector2 WorldPosition { get; set; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_Utilities_Transform2D_WorldRotation"></a> WorldRotation

```csharp
public float WorldRotation { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

