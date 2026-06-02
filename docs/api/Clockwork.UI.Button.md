# <a id="Clockwork_UI_Button"></a> Class Button

Namespace: [Clockwork.UI](Clockwork.UI.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class Button : Container
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Clockwork.Entity.md) ← 
[Element](Clockwork.UI.Element.md) ← 
[Container](Clockwork.UI.Container.md) ← 
[Button](Clockwork.UI.Button.md)

#### Inherited Members

[Container.Children](Clockwork.UI.Container.md\#Clockwork\_UI\_Container\_Children), 
[Container.Padding](Clockwork.UI.Container.md\#Clockwork\_UI\_Container\_Padding), 
[Container.PaddingLeft](Clockwork.UI.Container.md\#Clockwork\_UI\_Container\_PaddingLeft), 
[Container.PaddingRight](Clockwork.UI.Container.md\#Clockwork\_UI\_Container\_PaddingRight), 
[Container.PaddingTop](Clockwork.UI.Container.md\#Clockwork\_UI\_Container\_PaddingTop), 
[Container.PaddingBottom](Clockwork.UI.Container.md\#Clockwork\_UI\_Container\_PaddingBottom), 
[Container.AddChild\(Element\)](Clockwork.UI.Container.md\#Clockwork\_UI\_Container\_AddChild\_Clockwork\_UI\_Element\_), 
[Container.OnXUpdated\(\)](Clockwork.UI.Container.md\#Clockwork\_UI\_Container\_OnXUpdated), 
[Container.OnYUpdated\(\)](Clockwork.UI.Container.md\#Clockwork\_UI\_Container\_OnYUpdated), 
[Container.OnWidthUpdated\(\)](Clockwork.UI.Container.md\#Clockwork\_UI\_Container\_OnWidthUpdated), 
[Container.OnHeightUpdated\(\)](Clockwork.UI.Container.md\#Clockwork\_UI\_Container\_OnHeightUpdated), 
[Element.BackgroundColor](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_BackgroundColor), 
[Element.BorderColor](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_BorderColor), 
[Element.BorderThickness](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_BorderThickness), 
[Element.HoverEntered](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_HoverEntered), 
[Element.HoverExited](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_HoverExited), 
[Element.Pressed](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_Pressed), 
[Element.Released](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_Released), 
[Element.X](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_X), 
[Element.Y](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_Y), 
[Element.Width](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_Width), 
[Element.Height](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_Height), 
[Element.OnUpdate\(\)](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_OnUpdate), 
[Element.OnDraw\(\)](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_OnDraw), 
[Element.OnXUpdated\(\)](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_OnXUpdated), 
[Element.OnYUpdated\(\)](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_OnYUpdated), 
[Element.OnWidthUpdated\(\)](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_OnWidthUpdated), 
[Element.OnHeightUpdated\(\)](Clockwork.UI.Element.md\#Clockwork\_UI\_Element\_OnHeightUpdated), 
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

## Constructors

### <a id="Clockwork_UI_Button__ctor"></a> Button\(\)

```csharp
public Button()
```

### <a id="Clockwork_UI_Button__ctor_System_Int32_System_Int32_System_Int32_System_Int32_"></a> Button\(int, int, int, int\)

```csharp
public Button(int x, int y, int width, int height)
```

#### Parameters

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_UI_Button__ctor_System_Int32_System_Int32_System_Int32_System_Int32_Clockwork_Graphics_Color_Clockwork_Graphics_Color_System_Int32_"></a> Button\(int, int, int, int, Color, Color, int\)

```csharp
public Button(int x, int y, int width, int height, Color backgroundColor, Color borderColor, int borderThickness)
```

#### Parameters

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`backgroundColor` [Color](Clockwork.Graphics.Color.md)

`borderColor` [Color](Clockwork.Graphics.Color.md)

`borderThickness` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_UI_Button__ctor_System_Numerics_Vector2_System_Numerics_Vector2_Clockwork_Graphics_Color_Clockwork_Graphics_Color_System_Int32_"></a> Button\(Vector2, Vector2, Color, Color, int\)

```csharp
public Button(Vector2 position, Vector2 size, Color backgroundColor, Color borderColor, int borderThickness)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`size` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`backgroundColor` [Color](Clockwork.Graphics.Color.md)

`borderColor` [Color](Clockwork.Graphics.Color.md)

`borderThickness` [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Fields

### <a id="Clockwork_UI_Button_AccentColor"></a> AccentColor

```csharp
public Color AccentColor
```

#### Field Value

 [Color](Clockwork.Graphics.Color.md)

## Methods

### <a id="Clockwork_UI_Button_OnHoverEntered_Clockwork_UI_Element_"></a> OnHoverEntered\(Element\)

```csharp
public virtual void OnHoverEntered(Element element)
```

#### Parameters

`element` [Element](Clockwork.UI.Element.md)

### <a id="Clockwork_UI_Button_OnHoverExited_Clockwork_UI_Element_"></a> OnHoverExited\(Element\)

```csharp
public virtual void OnHoverExited(Element element)
```

#### Parameters

`element` [Element](Clockwork.UI.Element.md)

### <a id="Clockwork_UI_Button_OnPressed_Clockwork_UI_Element_"></a> OnPressed\(Element\)

```csharp
public virtual void OnPressed(Element element)
```

#### Parameters

`element` [Element](Clockwork.UI.Element.md)

### <a id="Clockwork_UI_Button_OnReleased_Clockwork_UI_Element_"></a> OnReleased\(Element\)

```csharp
public virtual void OnReleased(Element element)
```

#### Parameters

`element` [Element](Clockwork.UI.Element.md)

