# <a id="Clockwork_Utilities_Quadtree_1"></a> Class Quadtree<ItemType\>

Namespace: [Clockwork.Utilities](Clockwork.Utilities.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class Quadtree<ItemType>
```

#### Type Parameters

`ItemType` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Quadtree<ItemType\>](Clockwork.Utilities.Quadtree\-1.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Clockwork_Utilities_Quadtree_1__ctor_System_Numerics_Vector2_System_Single_System_Single_System_Int32_"></a> Quadtree\(Vector2, float, float, int\)

```csharp
public Quadtree(Vector2 position, float size, float minCellSize, int nodeCapacity = 4)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`size` [float](https://learn.microsoft.com/dotnet/api/system.single)

`minCellSize` [float](https://learn.microsoft.com/dotnet/api/system.single)

`nodeCapacity` [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Clockwork_Utilities_Quadtree_1_Add__0_System_Numerics_Vector2_"></a> Add\(ItemType, Vector2\)

```csharp
public void Add(ItemType item, Vector2 position)
```

#### Parameters

`item` ItemType

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_Utilities_Quadtree_1_AnyItemInRadius_System_Numerics_Vector2_System_Single_"></a> AnyItemInRadius\(Vector2, float\)

```csharp
public bool AnyItemInRadius(Vector2 position, float radiusSquared)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`radiusSquared` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Utilities_Quadtree_1_Clear"></a> Clear\(\)

```csharp
public void Clear()
```

### <a id="Clockwork_Utilities_Quadtree_1_DrawBounds_System_Single_Clockwork_Graphics_Color_"></a> DrawBounds\(float, Color\)

```csharp
public void DrawBounds(float lineThickness, Color color)
```

#### Parameters

`lineThickness` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Utilities_Quadtree_1_DrawPoints_System_Single_Clockwork_Graphics_Color_"></a> DrawPoints\(float, Color\)

```csharp
public void DrawPoints(float pointRadius, Color color)
```

#### Parameters

`pointRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Utilities_Quadtree_1_QueryBounds_System_Collections_Generic_IList_Clockwork_Graphics_Rectangle__"></a> QueryBounds\(IList<Rectangle\>\)

```csharp
public void QueryBounds(IList<Rectangle> queriedBounds)
```

#### Parameters

`queriedBounds` [IList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist\-1)<[Rectangle](Clockwork.Graphics.Rectangle.md)\>

### <a id="Clockwork_Utilities_Quadtree_1_QueryBounds_System_Numerics_Vector2_System_Single_System_Collections_Generic_IList_Clockwork_Graphics_Rectangle__"></a> QueryBounds\(Vector2, float, IList<Rectangle\>\)

```csharp
public void QueryBounds(Vector2 position, float radiusSquared, IList<Rectangle> queriedBounds)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`radiusSquared` [float](https://learn.microsoft.com/dotnet/api/system.single)

`queriedBounds` [IList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist\-1)<[Rectangle](Clockwork.Graphics.Rectangle.md)\>

### <a id="Clockwork_Utilities_Quadtree_1_QueryClosestItem_System_Numerics_Vector2_"></a> QueryClosestItem\(Vector2\)

```csharp
public ItemType QueryClosestItem(Vector2 position)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 ItemType

### <a id="Clockwork_Utilities_Quadtree_1_QueryItems_System_Numerics_Vector2_System_Single_System_Collections_Generic_IList__0__"></a> QueryItems\(Vector2, float, IList<ItemType\>\)

```csharp
public void QueryItems(Vector2 position, float radiusSquared, IList<ItemType> queriedItems)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`radiusSquared` [float](https://learn.microsoft.com/dotnet/api/system.single)

`queriedItems` [IList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist\-1)<ItemType\>

### <a id="Clockwork_Utilities_Quadtree_1_QueryItems_System_Numerics_Vector2_System_Single_System_Collections_Generic_IList__0__System_Collections_Generic_IList_System_Single__"></a> QueryItems\(Vector2, float, IList<ItemType\>, IList<float\>\)

```csharp
public void QueryItems(Vector2 position, float radiusSquared, IList<ItemType> queriedItems, IList<float> distancesSquared)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`radiusSquared` [float](https://learn.microsoft.com/dotnet/api/system.single)

`queriedItems` [IList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist\-1)<ItemType\>

`distancesSquared` [IList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist\-1)<[float](https://learn.microsoft.com/dotnet/api/system.single)\>

### <a id="Clockwork_Utilities_Quadtree_1_QueryItems_System_Numerics_Vector2_System_Single_System_Collections_Generic_IList__0__System_Collections_Generic_IList_System_Numerics_Vector2__System_Collections_Generic_IList_System_Single__"></a> QueryItems\(Vector2, float, IList<ItemType\>, IList<Vector2\>, IList<float\>\)

```csharp
public void QueryItems(Vector2 position, float radiusSquared, IList<ItemType> queriedItems, IList<Vector2> differences, IList<float> distancesSquared)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`radiusSquared` [float](https://learn.microsoft.com/dotnet/api/system.single)

`queriedItems` [IList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist\-1)<ItemType\>

`differences` [IList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist\-1)<[Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)\>

`distancesSquared` [IList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist\-1)<[float](https://learn.microsoft.com/dotnet/api/system.single)\>

