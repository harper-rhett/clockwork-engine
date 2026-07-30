# <a id="Clockwork_UI_Container"></a> Class Container

Namespace: [Clockwork.UI](Clockwork.UI.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class Container : Element
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Element](Clockwork.UI.Element.md) ← 
[Container](Clockwork.UI.Container.md)

#### Derived

[AlignmentContainer](Clockwork.UI.AlignmentContainer.md), 
[FrameContainer](Clockwork.UI.FrameContainer.md), 
[HorizontalSlider](Clockwork.UI.HorizontalSlider.md), 
[HorizontalStackContainer](Clockwork.UI.HorizontalStackContainer.md), 
[VerticalStackContainer](Clockwork.UI.VerticalStackContainer.md)

#### Inherited Members

[Element.DisabledStyle](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_DisabledStyle), 
[Element.ActiveStyle](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_ActiveStyle), 
[Element.BackgroundColor](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_BackgroundColor), 
[Element.BorderColor](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_BorderColor), 
[Element.BorderThickness](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_BorderThickness), 
[Element.Enabled](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_Enabled), 
[Element.Visible](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_Visible), 
[Element.HoverEntered](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_HoverEntered), 
[Element.HoverExited](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_HoverExited), 
[Element.Pressed](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_Pressed), 
[Element.Released](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_Released), 
[Element.X](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_X), 
[Element.Y](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_Y), 
[Element.Width](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_Width), 
[Element.Height](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_Height), 
[Element.GetHalfWidth\(\)](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_GetHalfWidth), 
[Element.GetHalfHeight\(\)](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_GetHalfHeight), 
[Element.Position](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_Position), 
[Element.Size](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_Size), 
[Element.Rectangle](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_Rectangle), 
[Element.InitializeTransform\(int, int, int, int\)](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_InitializeTransform\_System\_Int32\_System\_Int32\_System\_Int32\_System\_Int32\_), 
[Element.InitializeDisabledStyle\(\)](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_InitializeDisabledStyle), 
[Element.OnUpdate\(DrawContext\)](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_OnUpdate\_Clockwork\_UI\_DrawContext\_), 
[Element.IsHovering\(DrawContext\)](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_IsHovering\_Clockwork\_UI\_DrawContext\_), 
[Element.OnDraw\(\)](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_OnDraw), 
[Element.OnXUpdated\(\)](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_OnXUpdated), 
[Element.OnYUpdated\(\)](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_OnYUpdated), 
[Element.OnWidthUpdated\(\)](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_OnWidthUpdated), 
[Element.OnHeightUpdated\(\)](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_OnHeightUpdated), 
[Element.OnEnabled\(\)](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_OnEnabled), 
[Element.OnDisabled\(\)](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_OnDisabled), 
[Element.OnVisible\(\)](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_OnVisible), 
[Element.OnInvisible\(\)](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_OnInvisible), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Clockwork_UI_Container__ctor"></a> Container\(\)

```csharp
public Container()
```

### <a id="Clockwork_UI_Container__ctor_Clockwork_UI_Style_"></a> Container\(Style\)

```csharp
public Container(Style style)
```

#### Parameters

`style` [Style](Clockwork.UI.Style.md)

### <a id="Clockwork_UI_Container__ctor_System_Int32_System_Int32_System_Int32_System_Int32_"></a> Container\(int, int, int, int\)

```csharp
public Container(int x, int y, int width, int height)
```

#### Parameters

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_UI_Container__ctor_System_Int32_System_Int32_System_Int32_System_Int32_Clockwork_UI_Style_"></a> Container\(int, int, int, int, Style\)

```csharp
public Container(int x, int y, int width, int height, Style style)
```

#### Parameters

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`style` [Style](Clockwork.UI.Style.md)

### <a id="Clockwork_UI_Container__ctor_System_Numerics_Vector2_System_Numerics_Vector2_"></a> Container\(Vector2, Vector2\)

```csharp
public Container(Vector2 position, Vector2 size)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`size` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_UI_Container__ctor_System_Numerics_Vector2_System_Numerics_Vector2_Clockwork_UI_Style_"></a> Container\(Vector2, Vector2, Style\)

```csharp
public Container(Vector2 position, Vector2 size, Style style)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`size` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`style` [Style](Clockwork.UI.Style.md)

## Fields

### <a id="Clockwork_UI_Container_PaddingBottom"></a> PaddingBottom

```csharp
public int PaddingBottom
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_UI_Container_PaddingLeft"></a> PaddingLeft

```csharp
public int PaddingLeft
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_UI_Container_PaddingRight"></a> PaddingRight

```csharp
public int PaddingRight
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_UI_Container_PaddingTop"></a> PaddingTop

```csharp
public int PaddingTop
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_UI_Container_children"></a> children

```csharp
protected readonly List<Element> children
```

#### Field Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Element](Clockwork.UI.Element.md)\>

## Properties

### <a id="Clockwork_UI_Container_Children"></a> Children

```csharp
public IReadOnlyList<Element> Children { get; }
```

#### Property Value

 [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<[Element](Clockwork.UI.Element.md)\>

### <a id="Clockwork_UI_Container_Padding"></a> Padding

```csharp
public int Padding { set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Clockwork_UI_Container_AddChild_Clockwork_UI_Element_"></a> AddChild\(Element\)

```csharp
public virtual void AddChild(Element element)
```

#### Parameters

`element` [Element](Clockwork.UI.Element.md)

### <a id="Clockwork_UI_Container_ForceLayoutUpdate"></a> ForceLayoutUpdate\(\)

```csharp
public void ForceLayoutUpdate()
```

### <a id="Clockwork_UI_Container_InsertChild_System_Int32_Clockwork_UI_Element_"></a> InsertChild\(int, Element\)

```csharp
public virtual void InsertChild(int index, Element element)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`element` [Element](Clockwork.UI.Element.md)

### <a id="Clockwork_UI_Container_OnDisabled"></a> OnDisabled\(\)

```csharp
protected override void OnDisabled()
```

### <a id="Clockwork_UI_Container_OnDraw"></a> OnDraw\(\)

```csharp
public override void OnDraw()
```

### <a id="Clockwork_UI_Container_OnEnabled"></a> OnEnabled\(\)

```csharp
protected override void OnEnabled()
```

### <a id="Clockwork_UI_Container_OnInvisible"></a> OnInvisible\(\)

```csharp
protected override void OnInvisible()
```

### <a id="Clockwork_UI_Container_OnUpdate_Clockwork_UI_DrawContext_"></a> OnUpdate\(DrawContext\)

```csharp
public override void OnUpdate(DrawContext drawContext)
```

#### Parameters

`drawContext` [DrawContext](Clockwork.UI.DrawContext.md)

### <a id="Clockwork_UI_Container_OnVisible"></a> OnVisible\(\)

```csharp
protected override void OnVisible()
```

### <a id="Clockwork_UI_Container_RemoveChild_Clockwork_UI_Element_"></a> RemoveChild\(Element\)

```csharp
public virtual void RemoveChild(Element element)
```

#### Parameters

`element` [Element](Clockwork.UI.Element.md)

