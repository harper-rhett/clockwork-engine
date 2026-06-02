# <a id="Clockwork_Utilities_Generate"></a> Class Generate

Namespace: [Clockwork.Utilities](Clockwork.Utilities.md)  
Assembly: ClockworkEngine.dll  

```csharp
public static class Generate
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Generate](Clockwork.Utilities.Generate.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Properties

### <a id="Clockwork_Utilities_Generate_Seed"></a> Seed

```csharp
public static int Seed { set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Clockwork_Utilities_Generate_Bool"></a> Bool\(\)

```csharp
public static bool Bool()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Utilities_Generate_Bool_System_Single_"></a> Bool\(float\)

```csharp
public static bool Bool(float trueChance)
```

#### Parameters

`trueChance` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Utilities_Generate_Degrees"></a> Degrees\(\)

```csharp
public static float Degrees()
```

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Utilities_Generate_Double"></a> Double\(\)

```csharp
public static double Double()
```

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="Clockwork_Utilities_Generate_Float"></a> Float\(\)

```csharp
public static float Float()
```

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Utilities_Generate_Float_System_Single_"></a> Float\(float\)

```csharp
public static float Float(float max)
```

#### Parameters

`max` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Utilities_Generate_Float_System_Single_System_Single_"></a> Float\(float, float\)

```csharp
public static float Float(float min, float max)
```

#### Parameters

`min` [float](https://learn.microsoft.com/dotnet/api/system.single)

`max` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Utilities_Generate_GetRandomIndex__1_System_Collections_Generic_ICollection___0__"></a> GetRandomIndex<Type\>\(ICollection<Type\>\)

```csharp
public static int GetRandomIndex<Type>(this ICollection<Type> collection)
```

#### Parameters

`collection` [ICollection](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection\-1)<Type\>

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Type Parameters

`Type` 

### <a id="Clockwork_Utilities_Generate_GetRandomItem__1_System_Collections_Generic_IList___0__"></a> GetRandomItem<Type\>\(IList<Type\>\)

```csharp
public static Type GetRandomItem<Type>(this IList<Type> list)
```

#### Parameters

`list` [IList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist\-1)<Type\>

#### Returns

 Type

#### Type Parameters

`Type` 

### <a id="Clockwork_Utilities_Generate_GetShuffled__1_System_Collections_Generic_IList___0__"></a> GetShuffled<Type\>\(IList<Type\>\)

```csharp
public static List<Type> GetShuffled<Type>(this IList<Type> list)
```

#### Parameters

`list` [IList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist\-1)<Type\>

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<Type\>

#### Type Parameters

`Type` 

### <a id="Clockwork_Utilities_Generate_GetShuffledList__1_System_Collections_Generic_IList___0__"></a> GetShuffledList<Type\>\(IList<Type\>\)

```csharp
public static List<Type> GetShuffledList<Type>(IList<Type> list)
```

#### Parameters

`list` [IList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist\-1)<Type\>

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<Type\>

#### Type Parameters

`Type` 

### <a id="Clockwork_Utilities_Generate_Index__1_System_Collections_Generic_ICollection___0__"></a> Index<Type\>\(ICollection<Type\>\)

```csharp
public static int Index<Type>(ICollection<Type> collection)
```

#### Parameters

`collection` [ICollection](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection\-1)<Type\>

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Type Parameters

`Type` 

### <a id="Clockwork_Utilities_Generate_Integer"></a> Integer\(\)

```csharp
public static int Integer()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Utilities_Generate_Integer_System_Int32_"></a> Integer\(int\)

```csharp
public static int Integer(int max)
```

#### Parameters

`max` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Utilities_Generate_Integer_System_Int32_System_Int32_"></a> Integer\(int, int\)

```csharp
public static int Integer(int minInclusive, int maxExclusive)
```

#### Parameters

`minInclusive` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`maxExclusive` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Utilities_Generate_Item__1_System_Collections_Generic_IList___0__"></a> Item<Type\>\(IList<Type\>\)

```csharp
public static Type Item<Type>(IList<Type> list)
```

#### Parameters

`list` [IList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist\-1)<Type\>

#### Returns

 Type

#### Type Parameters

`Type` 

### <a id="Clockwork_Utilities_Generate_Long"></a> Long\(\)

```csharp
public static long Long()
```

#### Returns

 [long](https://learn.microsoft.com/dotnet/api/system.int64)

### <a id="Clockwork_Utilities_Generate_Radians"></a> Radians\(\)

```csharp
public static float Radians()
```

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Utilities_Generate_RemoveItem__1_System_Collections_Generic_IList___0__"></a> RemoveItem<Type\>\(IList<Type\>\)

```csharp
public static void RemoveItem<Type>(IList<Type> list)
```

#### Parameters

`list` [IList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist\-1)<Type\>

#### Type Parameters

`Type` 

### <a id="Clockwork_Utilities_Generate_RemoveRandomItem__1_System_Collections_Generic_IList___0__"></a> RemoveRandomItem<Type\>\(IList<Type\>\)

```csharp
public static void RemoveRandomItem<Type>(this IList<Type> list)
```

#### Parameters

`list` [IList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist\-1)<Type\>

#### Type Parameters

`Type` 

### <a id="Clockwork_Utilities_Generate_Shuffle__1_System_Collections_Generic_IList___0__"></a> Shuffle<Type\>\(IList<Type\>\)

```csharp
public static void Shuffle<Type>(this IList<Type> list)
```

#### Parameters

`list` [IList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist\-1)<Type\>

#### Type Parameters

`Type` 

### <a id="Clockwork_Utilities_Generate_ShuffleList__1_System_Collections_Generic_IList___0__"></a> ShuffleList<Type\>\(IList<Type\>\)

```csharp
public static void ShuffleList<Type>(IList<Type> list)
```

#### Parameters

`list` [IList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist\-1)<Type\>

#### Type Parameters

`Type` 

### <a id="Clockwork_Utilities_Generate_UnitVector2"></a> UnitVector2\(\)

```csharp
public static Vector2 UnitVector2()
```

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_Utilities_Generate_UnitVector3"></a> UnitVector3\(\)

```csharp
public static Vector3 UnitVector3()
```

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Clockwork_Utilities_Generate_Vector2_System_Single_System_Single_System_Single_System_Single_"></a> Vector2\(float, float, float, float\)

```csharp
public static Vector2 Vector2(float westX, float northY, float eastX, float southY)
```

#### Parameters

`westX` [float](https://learn.microsoft.com/dotnet/api/system.single)

`northY` [float](https://learn.microsoft.com/dotnet/api/system.single)

`eastX` [float](https://learn.microsoft.com/dotnet/api/system.single)

`southY` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_Utilities_Generate_Vector2_Clockwork_Graphics_Rectangle_"></a> Vector2\(Rectangle\)

```csharp
public static Vector2 Vector2(Rectangle bounds)
```

#### Parameters

`bounds` [Rectangle](Clockwork.Graphics.Rectangle.md)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

