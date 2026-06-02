# <a id="Clockwork_Utilities_QuaternionExtensions"></a> Class QuaternionExtensions

Namespace: [Clockwork.Utilities](Clockwork.Utilities.md)  
Assembly: ClockworkEngine.dll  

```csharp
public static class QuaternionExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[QuaternionExtensions](Clockwork.Utilities.QuaternionExtensions.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Methods

### <a id="Clockwork_Utilities_QuaternionExtensions_CreateRotation_System_Numerics_Vector3_System_Single_"></a> CreateRotation\(Vector3, float\)

```csharp
public static Quaternion CreateRotation(Vector3 axis, float radians)
```

#### Parameters

`axis` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`radians` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Quaternion](https://learn.microsoft.com/dotnet/api/system.numerics.quaternion)

### <a id="Clockwork_Utilities_QuaternionExtensions_GetBack_System_Numerics_Quaternion_"></a> GetBack\(Quaternion\)

```csharp
public static Vector3 GetBack(this Quaternion quaternion)
```

#### Parameters

`quaternion` [Quaternion](https://learn.microsoft.com/dotnet/api/system.numerics.quaternion)

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Clockwork_Utilities_QuaternionExtensions_GetDown_System_Numerics_Quaternion_"></a> GetDown\(Quaternion\)

```csharp
public static Vector3 GetDown(this Quaternion quaternion)
```

#### Parameters

`quaternion` [Quaternion](https://learn.microsoft.com/dotnet/api/system.numerics.quaternion)

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Clockwork_Utilities_QuaternionExtensions_GetForward_System_Numerics_Quaternion_"></a> GetForward\(Quaternion\)

```csharp
public static Vector3 GetForward(this Quaternion quaternion)
```

#### Parameters

`quaternion` [Quaternion](https://learn.microsoft.com/dotnet/api/system.numerics.quaternion)

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Clockwork_Utilities_QuaternionExtensions_GetLeft_System_Numerics_Quaternion_"></a> GetLeft\(Quaternion\)

```csharp
public static Vector3 GetLeft(this Quaternion quaternion)
```

#### Parameters

`quaternion` [Quaternion](https://learn.microsoft.com/dotnet/api/system.numerics.quaternion)

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Clockwork_Utilities_QuaternionExtensions_GetRight_System_Numerics_Quaternion_"></a> GetRight\(Quaternion\)

```csharp
public static Vector3 GetRight(this Quaternion quaternion)
```

#### Parameters

`quaternion` [Quaternion](https://learn.microsoft.com/dotnet/api/system.numerics.quaternion)

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Clockwork_Utilities_QuaternionExtensions_GetUp_System_Numerics_Quaternion_"></a> GetUp\(Quaternion\)

```csharp
public static Vector3 GetUp(this Quaternion quaternion)
```

#### Parameters

`quaternion` [Quaternion](https://learn.microsoft.com/dotnet/api/system.numerics.quaternion)

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Clockwork_Utilities_QuaternionExtensions_RotateLocalAxis_System_Numerics_Quaternion_System_Numerics_Vector3_System_Single_"></a> RotateLocalAxis\(Quaternion, Vector3, float\)

```csharp
public static Quaternion RotateLocalAxis(this Quaternion quaternion, Vector3 localAxis, float radians)
```

#### Parameters

`quaternion` [Quaternion](https://learn.microsoft.com/dotnet/api/system.numerics.quaternion)

`localAxis` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`radians` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Quaternion](https://learn.microsoft.com/dotnet/api/system.numerics.quaternion)

### <a id="Clockwork_Utilities_QuaternionExtensions_RotateWorldAxis_System_Numerics_Quaternion_System_Numerics_Vector3_System_Single_"></a> RotateWorldAxis\(Quaternion, Vector3, float\)

```csharp
public static Quaternion RotateWorldAxis(this Quaternion quaternion, Vector3 worldAxis, float radians)
```

#### Parameters

`quaternion` [Quaternion](https://learn.microsoft.com/dotnet/api/system.numerics.quaternion)

`worldAxis` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`radians` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Quaternion](https://learn.microsoft.com/dotnet/api/system.numerics.quaternion)

