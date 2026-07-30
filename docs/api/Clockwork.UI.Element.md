# <a id="Clockwork_UI_Element"></a> Class Element

Namespace: [Clockwork.UI](Clockwork.UI.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class Element
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Element](Clockwork.UI.Element.md)

#### Derived

[Container](Clockwork.UI.Container.md), 
[TextElement](Clockwork.UI.TextElement.md), 
[TextureElement](Clockwork.UI.TextureElement.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Clockwork_UI_Element__ctor"></a> Element\(\)

```csharp
public Element()
```

### <a id="Clockwork_UI_Element__ctor_Clockwork_UI_Style_"></a> Element\(Style\)

```csharp
public Element(Style style)
```

#### Parameters

`style` [Style](Clockwork.UI.Style.md)

### <a id="Clockwork_UI_Element__ctor_System_Int32_System_Int32_System_Int32_System_Int32_"></a> Element\(int, int, int, int\)

```csharp
public Element(int x, int y, int width, int height)
```

#### Parameters

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_UI_Element__ctor_System_Int32_System_Int32_System_Int32_System_Int32_Clockwork_UI_Style_"></a> Element\(int, int, int, int, Style\)

```csharp
public Element(int x, int y, int width, int height, Style style)
```

#### Parameters

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`style` [Style](Clockwork.UI.Style.md)

### <a id="Clockwork_UI_Element__ctor_System_Numerics_Vector2_System_Numerics_Vector2_"></a> Element\(Vector2, Vector2\)

```csharp
public Element(Vector2 position, Vector2 size)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`size` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_UI_Element__ctor_System_Numerics_Vector2_System_Numerics_Vector2_Clockwork_UI_Style_"></a> Element\(Vector2, Vector2, Style\)

```csharp
public Element(Vector2 position, Vector2 size, Style style)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`size` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`style` [Style](Clockwork.UI.Style.md)

## Fields

### <a id="Clockwork_UI_Element_ActiveStyle"></a> ActiveStyle

```csharp
public Style ActiveStyle
```

#### Field Value

 [Style](Clockwork.UI.Style.md)

### <a id="Clockwork_UI_Element_DisabledStyle"></a> DisabledStyle

```csharp
public Style DisabledStyle
```

#### Field Value

 [Style](Clockwork.UI.Style.md)

## Properties

### <a id="Clockwork_UI_Element_BackgroundColor"></a> BackgroundColor

```csharp
public Color BackgroundColor { get; set; }
```

#### Property Value

 [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_UI_Element_BorderColor"></a> BorderColor

```csharp
public Color BorderColor { get; set; }
```

#### Property Value

 [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_UI_Element_BorderThickness"></a> BorderThickness

```csharp
public int BorderThickness { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_UI_Element_Enabled"></a> Enabled

```csharp
public bool Enabled { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_UI_Element_Height"></a> Height

```csharp
public int Height { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_UI_Element_Position"></a> Position

```csharp
public Vector2 Position { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_UI_Element_Rectangle"></a> Rectangle

```csharp
public Rectangle Rectangle { get; }
```

#### Property Value

 [Rectangle](Clockwork.Graphics.Rectangle.md)

### <a id="Clockwork_UI_Element_Size"></a> Size

```csharp
public Vector2 Size { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_UI_Element_Visible"></a> Visible

```csharp
public bool Visible { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_UI_Element_Width"></a> Width

```csharp
public int Width { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_UI_Element_X"></a> X

```csharp
public int X { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_UI_Element_Y"></a> Y

```csharp
public int Y { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Clockwork_UI_Element_GetHalfHeight"></a> GetHalfHeight\(\)

```csharp
public int GetHalfHeight()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_UI_Element_GetHalfWidth"></a> GetHalfWidth\(\)

```csharp
public int GetHalfWidth()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_UI_Element_InitializeDisabledStyle"></a> InitializeDisabledStyle\(\)

```csharp
protected void InitializeDisabledStyle()
```

### <a id="Clockwork_UI_Element_InitializeTransform_System_Int32_System_Int32_System_Int32_System_Int32_"></a> InitializeTransform\(int, int, int, int\)

```csharp
protected void InitializeTransform(int x, int y, int width, int height)
```

#### Parameters

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_UI_Element_IsHovering_Clockwork_UI_DrawContext_"></a> IsHovering\(DrawContext\)

```csharp
protected bool IsHovering(DrawContext drawContext)
```

#### Parameters

`drawContext` [DrawContext](Clockwork.UI.DrawContext.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_UI_Element_OnDisabled"></a> OnDisabled\(\)

```csharp
protected virtual void OnDisabled()
```

### <a id="Clockwork_UI_Element_OnDraw"></a> OnDraw\(\)

```csharp
public virtual void OnDraw()
```

### <a id="Clockwork_UI_Element_OnEnabled"></a> OnEnabled\(\)

```csharp
protected virtual void OnEnabled()
```

### <a id="Clockwork_UI_Element_OnHeightUpdated"></a> OnHeightUpdated\(\)

```csharp
protected virtual void OnHeightUpdated()
```

### <a id="Clockwork_UI_Element_OnInvisible"></a> OnInvisible\(\)

```csharp
protected virtual void OnInvisible()
```

### <a id="Clockwork_UI_Element_OnUpdate_Clockwork_UI_DrawContext_"></a> OnUpdate\(DrawContext\)

```csharp
public virtual void OnUpdate(DrawContext drawContext)
```

#### Parameters

`drawContext` [DrawContext](Clockwork.UI.DrawContext.md)

### <a id="Clockwork_UI_Element_OnVisible"></a> OnVisible\(\)

```csharp
protected virtual void OnVisible()
```

### <a id="Clockwork_UI_Element_OnWidthUpdated"></a> OnWidthUpdated\(\)

```csharp
protected virtual void OnWidthUpdated()
```

### <a id="Clockwork_UI_Element_OnXUpdated"></a> OnXUpdated\(\)

```csharp
protected virtual void OnXUpdated()
```

### <a id="Clockwork_UI_Element_OnYUpdated"></a> OnYUpdated\(\)

```csharp
protected virtual void OnYUpdated()
```

### <a id="Clockwork_UI_Element_HoverEntered"></a> HoverEntered

```csharp
public event Action HoverEntered
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action)

### <a id="Clockwork_UI_Element_HoverExited"></a> HoverExited

```csharp
public event Action HoverExited
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action)

### <a id="Clockwork_UI_Element_Pressed"></a> Pressed

```csharp
public event Action Pressed
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action)

### <a id="Clockwork_UI_Element_Released"></a> Released

```csharp
public event Action Released
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action)

