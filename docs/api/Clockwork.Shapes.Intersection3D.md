# <a id="Clockwork_Shapes_Intersection3D"></a> Class Intersection3D

Namespace: [Clockwork.Shapes](Clockwork.Shapes.md)  
Assembly: ClockworkEngine.dll  

```csharp
public static class Intersection3D
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Intersection3D](Clockwork.Shapes.Intersection3D.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Methods

### <a id="Clockwork_Shapes_Intersection3D_RayInSphere_Ray_System_Numerics_Vector3_System_Single_"></a> RayInSphere\(Ray, Vector3, float\)

```csharp
public static bool RayInSphere(Ray ray, Vector3 spherePosition, float sphereRadius)
```

#### Parameters

`ray` [Ray](Ray.md)

`spherePosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`sphereRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Shapes_Intersection3D_RayInSphereCollision_Ray_System_Numerics_Vector3_System_Single_"></a> RayInSphereCollision\(Ray, Vector3, float\)

```csharp
public static extern RayCollision RayInSphereCollision(Ray ray, Vector3 spherePosition, float sphereRadius)
```

#### Parameters

`ray` [Ray](Ray.md)

`spherePosition` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`sphereRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [RayCollision](Clockwork.Shapes.RayCollision.md)

