# <a id="Clockwork_UI_TextElement"></a> Class TextElement

Namespace: [Clockwork.UI](Clockwork.UI.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class TextElement : Element
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Element](Clockwork.UI.Element.md) ← 
[TextElement](Clockwork.UI.TextElement.md)

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

### <a id="Clockwork_UI_TextElement__ctor"></a> TextElement\(\)

```csharp
public TextElement()
```

### <a id="Clockwork_UI_TextElement__ctor_System_String_"></a> TextElement\(string\)

```csharp
public TextElement(string content)
```

#### Parameters

`content` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Clockwork_UI_TextElement__ctor_System_String_System_Int32_Clockwork_Graphics_Color_"></a> TextElement\(string, int, Color\)

```csharp
public TextElement(string content, int fontSize, Color textColor)
```

#### Parameters

`content` [string](https://learn.microsoft.com/dotnet/api/system.string)

`fontSize` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`textColor` [Color](Clockwork.Graphics.Color.md)

## Fields

### <a id="Clockwork_UI_TextElement_DisabledTextColor"></a> DisabledTextColor

```csharp
public Color DisabledTextColor
```

#### Field Value

 [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_UI_TextElement_TextColor"></a> TextColor

```csharp
public Color TextColor
```

#### Field Value

 [Color](Clockwork.Graphics.Color.md)

## Properties

### <a id="Clockwork_UI_TextElement_CharacterSpacing"></a> CharacterSpacing

```csharp
public int CharacterSpacing { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_UI_TextElement_Font"></a> Font

```csharp
public Font Font { get; set; }
```

#### Property Value

 [Font](Clockwork.Graphics.Text.Font.md)

### <a id="Clockwork_UI_TextElement_FontSize"></a> FontSize

```csharp
public int FontSize { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_UI_TextElement_HorizontalAlignment"></a> HorizontalAlignment

```csharp
public HorizontalAlignment HorizontalAlignment { get; set; }
```

#### Property Value

 [HorizontalAlignment](Clockwork.UI.HorizontalAlignment.md)

### <a id="Clockwork_UI_TextElement_Text"></a> Text

```csharp
public string Text { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Clockwork_UI_TextElement_TextHeight"></a> TextHeight

```csharp
public int TextHeight { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_UI_TextElement_TextWidth"></a> TextWidth

```csharp
public int TextWidth { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_UI_TextElement_VerticalAlignment"></a> VerticalAlignment

```csharp
public VerticalAlignment VerticalAlignment { get; set; }
```

#### Property Value

 [VerticalAlignment](Clockwork.UI.VerticalAlignment.md)

## Methods

### <a id="Clockwork_UI_TextElement_OnDraw"></a> OnDraw\(\)

```csharp
public override void OnDraw()
```

### <a id="Clockwork_UI_TextElement_OnHeightUpdated"></a> OnHeightUpdated\(\)

```csharp
protected override void OnHeightUpdated()
```

### <a id="Clockwork_UI_TextElement_OnWidthUpdated"></a> OnWidthUpdated\(\)

```csharp
protected override void OnWidthUpdated()
```

### <a id="Clockwork_UI_TextElement_OnXUpdated"></a> OnXUpdated\(\)

```csharp
protected override void OnXUpdated()
```

### <a id="Clockwork_UI_TextElement_OnYUpdated"></a> OnYUpdated\(\)

```csharp
protected override void OnYUpdated()
```

