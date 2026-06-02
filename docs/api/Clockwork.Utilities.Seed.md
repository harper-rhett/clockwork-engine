# <a id="Clockwork_Utilities_Seed"></a> Class Seed

Namespace: [Clockwork.Utilities](Clockwork.Utilities.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class Seed
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Seed](Clockwork.Utilities.Seed.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Clockwork_Utilities_Seed__ctor"></a> Seed\(\)

```csharp
public Seed()
```

### <a id="Clockwork_Utilities_Seed__ctor_System_Int32_"></a> Seed\(int\)

```csharp
public Seed(int seed)
```

#### Parameters

`seed` [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Clockwork_Utilities_Seed_Value"></a> Value

```csharp
public int Value { set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Clockwork_Utilities_Seed_GetNextShuffledList__1_System_Collections_Generic_IList___0__"></a> GetNextShuffledList<Type\>\(IList<Type\>\)

```csharp
public List<Type> GetNextShuffledList<Type>(IList<Type> list)
```

#### Parameters

`list` [IList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist\-1)<Type\>

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<Type\>

#### Type Parameters

`Type` 

### <a id="Clockwork_Utilities_Seed_NextBool"></a> NextBool\(\)

```csharp
public bool NextBool()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Utilities_Seed_NextBool_System_Single_"></a> NextBool\(float\)

```csharp
public bool NextBool(float trueChance)
```

#### Parameters

`trueChance` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Utilities_Seed_NextDegrees"></a> NextDegrees\(\)

```csharp
public float NextDegrees()
```

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Utilities_Seed_NextDouble"></a> NextDouble\(\)

```csharp
public double NextDouble()
```

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="Clockwork_Utilities_Seed_NextFloat"></a> NextFloat\(\)

```csharp
public float NextFloat()
```

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Utilities_Seed_NextFloat_System_Single_"></a> NextFloat\(float\)

```csharp
public float NextFloat(float max)
```

#### Parameters

`max` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Utilities_Seed_NextFloat_System_Single_System_Single_"></a> NextFloat\(float, float\)

```csharp
public float NextFloat(float min, float max)
```

#### Parameters

`min` [float](https://learn.microsoft.com/dotnet/api/system.single)

`max` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Utilities_Seed_NextIndex__1_System_Collections_Generic_ICollection___0__"></a> NextIndex<Type\>\(ICollection<Type\>\)

```csharp
public int NextIndex<Type>(ICollection<Type> collection)
```

#### Parameters

`collection` [ICollection](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection\-1)<Type\>

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Type Parameters

`Type` 

### <a id="Clockwork_Utilities_Seed_NextInteger"></a> NextInteger\(\)

```csharp
public int NextInteger()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Utilities_Seed_NextInteger_System_Int32_"></a> NextInteger\(int\)

```csharp
public int NextInteger(int max)
```

#### Parameters

`max` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Utilities_Seed_NextInteger_System_Int32_System_Int32_"></a> NextInteger\(int, int\)

```csharp
public int NextInteger(int minInclusive, int maxExclusive)
```

#### Parameters

`minInclusive` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`maxExclusive` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Utilities_Seed_NextItem__1_System_Collections_Generic_IList___0__"></a> NextItem<Type\>\(IList<Type\>\)

```csharp
public Type NextItem<Type>(IList<Type> list)
```

#### Parameters

`list` [IList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist\-1)<Type\>

#### Returns

 Type

#### Type Parameters

`Type` 

### <a id="Clockwork_Utilities_Seed_NextLong"></a> NextLong\(\)

```csharp
public long NextLong()
```

#### Returns

 [long](https://learn.microsoft.com/dotnet/api/system.int64)

### <a id="Clockwork_Utilities_Seed_NextRadians"></a> NextRadians\(\)

```csharp
public float NextRadians()
```

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Utilities_Seed_NextUnitVector2"></a> NextUnitVector2\(\)

```csharp
public Vector2 NextUnitVector2()
```

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_Utilities_Seed_NextUnitVector3"></a> NextUnitVector3\(\)

```csharp
public Vector3 NextUnitVector3()
```

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Clockwork_Utilities_Seed_NextVector2_System_Single_System_Single_System_Single_System_Single_"></a> NextVector2\(float, float, float, float\)

```csharp
public Vector2 NextVector2(float westX, float northY, float eastX, float southY)
```

#### Parameters

`westX` [float](https://learn.microsoft.com/dotnet/api/system.single)

`northY` [float](https://learn.microsoft.com/dotnet/api/system.single)

`eastX` [float](https://learn.microsoft.com/dotnet/api/system.single)

`southY` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_Utilities_Seed_NextVector2_Clockwork_Graphics_Rectangle_"></a> NextVector2\(Rectangle\)

```csharp
public Vector2 NextVector2(Rectangle bounds)
```

#### Parameters

`bounds` [Rectangle](Clockwork.Graphics.Rectangle.md)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_Utilities_Seed_RemoveNextItem__1_System_Collections_Generic_IList___0__"></a> RemoveNextItem<Type\>\(IList<Type\>\)

```csharp
public void RemoveNextItem<Type>(IList<Type> list)
```

#### Parameters

`list` [IList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist\-1)<Type\>

#### Type Parameters

`Type` 

### <a id="Clockwork_Utilities_Seed_ShuffleNextList__1_System_Collections_Generic_IList___0__"></a> ShuffleNextList<Type\>\(IList<Type\>\)

```csharp
public void ShuffleNextList<Type>(IList<Type> list)
```

#### Parameters

`list` [IList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist\-1)<Type\>

#### Type Parameters

`Type` 

