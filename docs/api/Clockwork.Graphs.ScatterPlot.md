# <a id="Clockwork_Graphs_ScatterPlot"></a> Class ScatterPlot

Namespace: [Clockwork.Graphs](Clockwork.Graphs.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class ScatterPlot : Entity, ICollection<Vector2>, IEnumerable<Vector2>, IEnumerable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Clockwork.Entity.md) ← 
[ScatterPlot](Clockwork.Graphs.ScatterPlot.md)

#### Implements

[ICollection<Vector2\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection\-1), 
[IEnumerable<Vector2\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable)

#### Inherited Members

[Entity.Scene](Clockwork.Entity.md\#Clockwork\_Entity\_Scene), 
[Entity.IsUpdating](Clockwork.Entity.md\#Clockwork\_Entity\_IsUpdating), 
[Entity.IsDrawing](Clockwork.Entity.md\#Clockwork\_Entity\_IsDrawing), 
[Entity.Removed](Clockwork.Entity.md\#Clockwork\_Entity\_Removed), 
[Entity.IsInScene](Clockwork.Entity.md\#Clockwork\_Entity\_IsInScene), 
[Entity.FrameTime](Clockwork.Entity.md\#Clockwork\_Entity\_FrameTime), 
[Entity.Time](Clockwork.Entity.md\#Clockwork\_Entity\_Time), 
[Entity.UpdateLayer](Clockwork.Entity.md\#Clockwork\_Entity\_UpdateLayer), 
[Entity.DrawLayer](Clockwork.Entity.md\#Clockwork\_Entity\_DrawLayer), 
[Entity.OnUpdate\(\)](Clockwork.Entity.md\#Clockwork\_Entity\_OnUpdate), 
[Entity.OnDraw\(\)](Clockwork.Entity.md\#Clockwork\_Entity\_OnDraw), 
[Entity.OnDrawGUI\(\)](Clockwork.Entity.md\#Clockwork\_Entity\_OnDrawGUI), 
[Entity.AddToScene\(Scene\)](Clockwork.Entity.md\#Clockwork\_Entity\_AddToScene\_Clockwork\_Scene\_), 
[Entity.RemoveFromScene\(\)](Clockwork.Entity.md\#Clockwork\_Entity\_RemoveFromScene), 
[Entity.OnAddedToScene\(\)](Clockwork.Entity.md\#Clockwork\_Entity\_OnAddedToScene), 
[Entity.OnRemovedFromScene\(\)](Clockwork.Entity.md\#Clockwork\_Entity\_OnRemovedFromScene), 
[Entity.IsVisible\(\)](Clockwork.Entity.md\#Clockwork\_Entity\_IsVisible), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[Generate.GetRandomIndex<Vector2\>\(ICollection<Vector2\>\)](Clockwork.Utilities.Generate.md\#Clockwork\_Utilities\_Generate\_GetRandomIndex\_\_1\_System\_Collections\_Generic\_ICollection\_\_\_0\_\_)

## Constructors

### <a id="Clockwork_Graphs_ScatterPlot__ctor_System_String_System_String_"></a> ScatterPlot\(string, string\)

```csharp
public ScatterPlot(string horizontalAxisName, string verticalAxisName)
```

#### Parameters

`horizontalAxisName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`verticalAxisName` [string](https://learn.microsoft.com/dotnet/api/system.string)

## Fields

### <a id="Clockwork_Graphs_ScatterPlot_FontSize"></a> FontSize

```csharp
public int FontSize
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Graphs_ScatterPlot_PointRadius"></a> PointRadius

```csharp
public float PointRadius
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Graphs_ScatterPlot_Position"></a> Position

```csharp
public Vector2 Position
```

#### Field Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

## Properties

### <a id="Clockwork_Graphs_ScatterPlot_Count"></a> Count

Gets the number of elements contained in the <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public int Count { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Graphs_ScatterPlot_Height"></a> Height

```csharp
public int Height { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Graphs_ScatterPlot_HorizontalRange"></a> HorizontalRange

```csharp
public float HorizontalRange { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Graphs_ScatterPlot_IsReadOnly"></a> IsReadOnly

Gets a value indicating whether the <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref> is read-only.

```csharp
public bool IsReadOnly { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Graphs_ScatterPlot_MaxXPoint"></a> MaxXPoint

```csharp
public float MaxXPoint { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Graphs_ScatterPlot_MaxYPoint"></a> MaxYPoint

```csharp
public float MaxYPoint { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Graphs_ScatterPlot_MinXPoint"></a> MinXPoint

```csharp
public float MinXPoint { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Graphs_ScatterPlot_MinYPoint"></a> MinYPoint

```csharp
public float MinYPoint { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Graphs_ScatterPlot_VerticalRange"></a> VerticalRange

```csharp
public float VerticalRange { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Graphs_ScatterPlot_Width"></a> Width

```csharp
public int Width { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Clockwork_Graphs_ScatterPlot_Add_System_Numerics_Vector2_"></a> Add\(Vector2\)

Adds an item to the <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public void Add(Vector2 point)
```

#### Parameters

`point` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Exceptions

 [NotSupportedException](https://learn.microsoft.com/dotnet/api/system.notsupportedexception)

The <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref> is read-only.

### <a id="Clockwork_Graphs_ScatterPlot_Clear"></a> Clear\(\)

Removes all items from the <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public void Clear()
```

#### Exceptions

 [NotSupportedException](https://learn.microsoft.com/dotnet/api/system.notsupportedexception)

The <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref> is read-only.

### <a id="Clockwork_Graphs_ScatterPlot_Contains_System_Numerics_Vector2_"></a> Contains\(Vector2\)

Determines whether the <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref> contains a specific value.

```csharp
public bool Contains(Vector2 point)
```

#### Parameters

`point` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if <code class="paramref">item</code> is found in the <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref>; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="Clockwork_Graphs_ScatterPlot_CopyTo_System_Numerics_Vector2___System_Int32_"></a> CopyTo\(Vector2\[\], int\)

Copies the elements of the <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref> to an <xref href="System.Array" data-throw-if-not-resolved="false"></xref>, starting at a particular <xref href="System.Array" data-throw-if-not-resolved="false"></xref> index.

```csharp
public void CopyTo(Vector2[] array, int arrayIndex)
```

#### Parameters

`array` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)\[\]

The one-dimensional <xref href="System.Array" data-throw-if-not-resolved="false"></xref> that is the destination of the elements copied from <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref>. The <xref href="System.Array" data-throw-if-not-resolved="false"></xref> must have zero-based indexing.

`arrayIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The zero-based index in <code class="paramref">array</code> at which copying begins.

#### Exceptions

 [ArgumentNullException](https://learn.microsoft.com/dotnet/api/system.argumentnullexception)

<code class="paramref">array</code> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

 [ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception)

<code class="paramref">arrayIndex</code> is less than 0.

 [ArgumentException](https://learn.microsoft.com/dotnet/api/system.argumentexception)

The number of elements in the source <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref> is greater than the available space from <code class="paramref">arrayIndex</code> to the end of the destination <code class="paramref">array</code>.

### <a id="Clockwork_Graphs_ScatterPlot_GetEnumerator"></a> GetEnumerator\(\)

Returns an enumerator that iterates through the collection.

```csharp
public IEnumerator<Vector2> GetEnumerator()
```

#### Returns

 [IEnumerator](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerator\-1)<[Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)\>

An enumerator that can be used to iterate through the collection.

### <a id="Clockwork_Graphs_ScatterPlot_OnDraw"></a> OnDraw\(\)

```csharp
public override void OnDraw()
```

### <a id="Clockwork_Graphs_ScatterPlot_OnUpdate"></a> OnUpdate\(\)

```csharp
public override void OnUpdate()
```

### <a id="Clockwork_Graphs_ScatterPlot_Remove_System_Numerics_Vector2_"></a> Remove\(Vector2\)

Removes the first occurrence of a specific object from the <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public bool Remove(Vector2 point)
```

#### Parameters

`point` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if <code class="paramref">item</code> was successfully removed from the <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref>; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>. This method also returns <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a> if <code class="paramref">item</code> is not found in the original <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref>.

#### Exceptions

 [NotSupportedException](https://learn.microsoft.com/dotnet/api/system.notsupportedexception)

The <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref> is read-only.

