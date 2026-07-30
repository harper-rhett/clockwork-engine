# <a id="Clockwork_UI_UploadBox"></a> Class UploadBox

Namespace: [Clockwork.UI](Clockwork.UI.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class UploadBox : Button
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Element](Clockwork.UI.Element.md) ← 
[Container](Clockwork.UI.Container.md) ← 
[FrameContainer](Clockwork.UI.FrameContainer.md) ← 
[Button](Clockwork.UI.Button.md) ← 
[UploadBox](Clockwork.UI.UploadBox.md)

#### Derived

[TextUploadBox](Clockwork.UI.TextUploadBox.md)

#### Inherited Members

[Button.DefaultStyle](Clockwork.UI.Button.md\#Clockwork\_UI\_Button\_DefaultStyle), 
[Button.HoverStyle](Clockwork.UI.Button.md\#Clockwork\_UI\_Button\_HoverStyle), 
[Button.PressedStyle](Clockwork.UI.Button.md\#Clockwork\_UI\_Button\_PressedStyle), 
[Button.IsHovered](Clockwork.UI.Button.md\#Clockwork\_UI\_Button\_IsHovered), 
[Button.IsPressed](Clockwork.UI.Button.md\#Clockwork\_UI\_Button\_IsPressed), 
[Button.Cancelled](Clockwork.UI.Button.md\#Clockwork\_UI\_Button\_Cancelled), 
[Button.OnHoverEntered\(\)](Clockwork.UI.Button.md\#Clockwork\_UI\_Button\_OnHoverEntered), 
[Button.OnHoverExited\(\)](Clockwork.UI.Button.md\#Clockwork\_UI\_Button\_OnHoverExited), 
[Button.OnPressed\(\)](Clockwork.UI.Button.md\#Clockwork\_UI\_Button\_OnPressed), 
[Button.OnReleased\(\)](Clockwork.UI.Button.md\#Clockwork\_UI\_Button\_OnReleased), 
[Button.OnDisabled\(\)](Clockwork.UI.Button.md\#Clockwork\_UI\_Button\_OnDisabled), 
[FrameContainer.OnXUpdated\(\)](Clockwork.UI.FrameContainer.md\#Clockwork\_UI\_FrameContainer\_OnXUpdated), 
[FrameContainer.OnYUpdated\(\)](Clockwork.UI.FrameContainer.md\#Clockwork\_UI\_FrameContainer\_OnYUpdated), 
[FrameContainer.OnWidthUpdated\(\)](Clockwork.UI.FrameContainer.md\#Clockwork\_UI\_FrameContainer\_OnWidthUpdated), 
[FrameContainer.OnHeightUpdated\(\)](Clockwork.UI.FrameContainer.md\#Clockwork\_UI\_FrameContainer\_OnHeightUpdated), 
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

### <a id="Clockwork_UI_UploadBox__ctor"></a> UploadBox\(\)

```csharp
public UploadBox()
```

### <a id="Clockwork_UI_UploadBox__ctor_System_Int32_System_Int32_System_Int32_System_Int32_"></a> UploadBox\(int, int, int, int\)

```csharp
public UploadBox(int x, int y, int width, int height)
```

#### Parameters

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_UI_UploadBox__ctor_System_Int32_System_Int32_System_Int32_System_Int32_Clockwork_UI_Style_Clockwork_UI_Style_Clockwork_UI_Style_"></a> UploadBox\(int, int, int, int, Style, Style, Style\)

```csharp
public UploadBox(int x, int y, int width, int height, Style defaultStyle, Style hoverStyle, Style pressedStyle)
```

#### Parameters

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`defaultStyle` [Style](Clockwork.UI.Style.md)

`hoverStyle` [Style](Clockwork.UI.Style.md)

`pressedStyle` [Style](Clockwork.UI.Style.md)

### <a id="Clockwork_UI_UploadBox__ctor_System_Numerics_Vector2_System_Numerics_Vector2_"></a> UploadBox\(Vector2, Vector2\)

```csharp
public UploadBox(Vector2 position, Vector2 size)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`size` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_UI_UploadBox__ctor_System_Numerics_Vector2_System_Numerics_Vector2_Clockwork_UI_Style_Clockwork_UI_Style_Clockwork_UI_Style_"></a> UploadBox\(Vector2, Vector2, Style, Style, Style\)

```csharp
public UploadBox(Vector2 position, Vector2 size, Style style, Style hoverStyle, Style pressedStyle)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`size` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`style` [Style](Clockwork.UI.Style.md)

`hoverStyle` [Style](Clockwork.UI.Style.md)

`pressedStyle` [Style](Clockwork.UI.Style.md)

## Fields

### <a id="Clockwork_UI_UploadBox_DefaultPath"></a> DefaultPath

```csharp
public string DefaultPath
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Clockwork_UI_UploadBox_ExtensionFilters"></a> ExtensionFilters

```csharp
public string[] ExtensionFilters
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)\[\]

### <a id="Clockwork_UI_UploadBox_Type"></a> Type

```csharp
public UploadBoxType Type
```

#### Field Value

 [UploadBoxType](UploadBoxType.md)

## Methods

### <a id="Clockwork_UI_UploadBox_OnItemPathSelected_System_String_"></a> OnItemPathSelected\(string\)

```csharp
protected virtual void OnItemPathSelected(string itemPath)
```

#### Parameters

`itemPath` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Clockwork_UI_UploadBox_OnItemPathsSelected_System_String___"></a> OnItemPathsSelected\(string\[\]\)

```csharp
protected virtual void OnItemPathsSelected(string[] itemPaths)
```

#### Parameters

`itemPaths` [string](https://learn.microsoft.com/dotnet/api/system.string)\[\]

### <a id="Clockwork_UI_UploadBox_OnReleased"></a> OnReleased\(\)

```csharp
public override void OnReleased()
```

### <a id="Clockwork_UI_UploadBox_OnUpdate_Clockwork_UI_DrawContext_"></a> OnUpdate\(DrawContext\)

```csharp
public override void OnUpdate(DrawContext drawContext)
```

#### Parameters

`drawContext` [DrawContext](Clockwork.UI.DrawContext.md)

### <a id="Clockwork_UI_UploadBox_ItemPathSelected"></a> ItemPathSelected

```csharp
public event Action<string> ItemPathSelected
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Clockwork_UI_UploadBox_ItemPathsSelected"></a> ItemPathsSelected

```csharp
public event Action<string[]> ItemPathsSelected
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\[\]\>

