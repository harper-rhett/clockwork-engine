# <a id="Clockwork_UI_Element"></a> Class Element

Namespace: [Clockwork.UI](Clockwork.UI.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class Element : Entity
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Clockwork.Entity.md) ← 
[Element](Clockwork.UI.Element.md)

#### Derived

[Container](Clockwork.UI.Container.md)

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

## Constructors

### <a id="Clockwork_UI_Element__ctor"></a> Element\(\)

```csharp
public Element()
```

### <a id="Clockwork_UI_Element__ctor_System_Int32_System_Int32_System_Int32_System_Int32_"></a> Element\(int, int, int, int\)

```csharp
public Element(int x, int y, int width, int height)
```

#### Parameters

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_UI_Element__ctor_System_Numerics_Vector2_System_Numerics_Vector2_"></a> Element\(Vector2, Vector2\)

```csharp
public Element(Vector2 position, Vector2 size)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`size` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

## Fields

### <a id="Clockwork_UI_Element_BackgroundColor"></a> BackgroundColor

```csharp
public Color BackgroundColor
```

#### Field Value

 [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_UI_Element_BorderColor"></a> BorderColor

```csharp
public Color BorderColor
```

#### Field Value

 [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_UI_Element_BorderThickness"></a> BorderThickness

```csharp
public int BorderThickness
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Clockwork_UI_Element_Height"></a> Height

```csharp
public int Height { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

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

### <a id="Clockwork_UI_Element_OnDraw"></a> OnDraw\(\)

```csharp
public override void OnDraw()
```

### <a id="Clockwork_UI_Element_OnHeightUpdated"></a> OnHeightUpdated\(\)

```csharp
protected virtual void OnHeightUpdated()
```

### <a id="Clockwork_UI_Element_OnUpdate"></a> OnUpdate\(\)

```csharp
public override void OnUpdate()
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
public event Action<Element> HoverEntered
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[Element](Clockwork.UI.Element.md)\>

### <a id="Clockwork_UI_Element_HoverExited"></a> HoverExited

```csharp
public event Action<Element> HoverExited
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[Element](Clockwork.UI.Element.md)\>

### <a id="Clockwork_UI_Element_Pressed"></a> Pressed

```csharp
public event Action<Element> Pressed
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[Element](Clockwork.UI.Element.md)\>

### <a id="Clockwork_UI_Element_Released"></a> Released

```csharp
public event Action<Element> Released
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[Element](Clockwork.UI.Element.md)\>

