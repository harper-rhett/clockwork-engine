# <a id="Clockwork_UI_HorizontalSlider"></a> Class HorizontalSlider

Namespace: [Clockwork.UI](Clockwork.UI.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class HorizontalSlider : Container
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Element](Clockwork.UI.Element.md) ← 
[Container](Clockwork.UI.Container.md) ← 
[HorizontalSlider](Clockwork.UI.HorizontalSlider.md)

#### Inherited Members

[Container.children](Clockwork.UI.Container.md\#Clockwork\_UI\_Container\_children), 
[Container.Children](Clockwork.UI.Container.md\#Clockwork\_UI\_Container\_Children), 
[Container.Padding](Clockwork.UI.Container.md\#Clockwork\_UI\_Container\_Padding), 
[Container.PaddingLeft](Clockwork.UI.Container.md\#Clockwork\_UI\_Container\_PaddingLeft), 
[Container.PaddingRight](Clockwork.UI.Container.md\#Clockwork\_UI\_Container\_PaddingRight), 
[Container.PaddingTop](Clockwork.UI.Container.md\#Clockwork\_UI\_Container\_PaddingTop), 
[Container.PaddingBottom](Clockwork.UI.Container.md\#Clockwork\_UI\_Container\_PaddingBottom), 
[Container.AddChild\(Element\)](Clockwork.UI.Container.md\#Clockwork\_UI\_Container\_AddChild\_Clockwork\_UI\_Element\_), 
[Container.InsertChild\(int, Element\)](Clockwork.UI.Container.md\#Clockwork\_UI\_Container\_InsertChild\_System\_Int32\_Clockwork\_UI\_Element\_), 
[Container.RemoveChild\(Element\)](Clockwork.UI.Container.md\#Clockwork\_UI\_Container\_RemoveChild\_Clockwork\_UI\_Element\_), 
[Container.ForceLayoutUpdate\(\)](Clockwork.UI.Container.md\#Clockwork\_UI\_Container\_ForceLayoutUpdate), 
[Container.OnUpdate\(DrawContext\)](Clockwork.UI.Container.md\#Clockwork\_UI\_Container\_OnUpdate\_Clockwork\_UI\_DrawContext\_), 
[Container.OnDraw\(\)](Clockwork.UI.Container.md\#Clockwork\_UI\_Container\_OnDraw), 
[Container.OnEnabled\(\)](Clockwork.UI.Container.md\#Clockwork\_UI\_Container\_OnEnabled), 
[Container.OnDisabled\(\)](Clockwork.UI.Container.md\#Clockwork\_UI\_Container\_OnDisabled), 
[Container.OnVisible\(\)](Clockwork.UI.Container.md\#Clockwork\_UI\_Container\_OnVisible), 
[Container.OnInvisible\(\)](Clockwork.UI.Container.md\#Clockwork\_UI\_Container\_OnInvisible), 
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

### <a id="Clockwork_UI_HorizontalSlider__ctor"></a> HorizontalSlider\(\)

```csharp
public HorizontalSlider()
```

## Fields

### <a id="Clockwork_UI_HorizontalSlider_ValueTextOffset"></a> ValueTextOffset

```csharp
public int ValueTextOffset
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Clockwork_UI_HorizontalSlider_Handle"></a> Handle

```csharp
public Button Handle { get; }
```

#### Property Value

 [Button](Clockwork.UI.Button.md)

### <a id="Clockwork_UI_HorizontalSlider_IsDragging"></a> IsDragging

```csharp
public bool IsDragging { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_UI_HorizontalSlider_Rail"></a> Rail

```csharp
public Element Rail { get; }
```

#### Property Value

 [Element](Clockwork.UI.Element.md)

### <a id="Clockwork_UI_HorizontalSlider_Value"></a> Value

```csharp
public float Value { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_UI_HorizontalSlider_ValueText"></a> ValueText

```csharp
public TextElement ValueText { get; }
```

#### Property Value

 [TextElement](Clockwork.UI.TextElement.md)

## Methods

### <a id="Clockwork_UI_HorizontalSlider_OnHeightUpdated"></a> OnHeightUpdated\(\)

```csharp
protected override void OnHeightUpdated()
```

### <a id="Clockwork_UI_HorizontalSlider_OnUpdate_Clockwork_UI_DrawContext_"></a> OnUpdate\(DrawContext\)

```csharp
public override void OnUpdate(DrawContext drawContext)
```

#### Parameters

`drawContext` [DrawContext](Clockwork.UI.DrawContext.md)

### <a id="Clockwork_UI_HorizontalSlider_OnWidthUpdated"></a> OnWidthUpdated\(\)

```csharp
protected override void OnWidthUpdated()
```

### <a id="Clockwork_UI_HorizontalSlider_OnXUpdated"></a> OnXUpdated\(\)

```csharp
protected override void OnXUpdated()
```

### <a id="Clockwork_UI_HorizontalSlider_OnYUpdated"></a> OnYUpdated\(\)

```csharp
protected override void OnYUpdated()
```

### <a id="Clockwork_UI_HorizontalSlider_ValueChanged"></a> ValueChanged

```csharp
public event HorizontalSlider.OnValueChanged ValueChanged
```

#### Event Type

 [HorizontalSlider](Clockwork.UI.HorizontalSlider.md).[OnValueChanged](Clockwork.UI.HorizontalSlider.OnValueChanged.md)

