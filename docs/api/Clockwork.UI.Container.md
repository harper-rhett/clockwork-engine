# <a id="Clockwork_UI_Container"></a> Class Container

Namespace: [Clockwork.UI](Clockwork.UI.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class Container : Element
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Clockwork.Entity.md) ← 
[Element](Clockwork.UI.Element.md) ← 
[Container](Clockwork.UI.Container.md)

#### Derived

[Button](Clockwork.UI.Button.md)

#### Inherited Members

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

### <a id="Clockwork_UI_Container__ctor"></a> Container\(\)

```csharp
public Container()
```

### <a id="Clockwork_UI_Container__ctor_System_Int32_System_Int32_System_Int32_System_Int32_"></a> Container\(int, int, int, int\)

```csharp
public Container(int x, int y, int width, int height)
```

#### Parameters

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_UI_Container__ctor_System_Numerics_Vector2_System_Numerics_Vector2_"></a> Container\(Vector2, Vector2\)

```csharp
public Container(Vector2 position, Vector2 size)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`size` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

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

### <a id="Clockwork_UI_Container_PaddingBottom"></a> PaddingBottom

```csharp
public int PaddingBottom { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_UI_Container_PaddingLeft"></a> PaddingLeft

```csharp
public int PaddingLeft { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_UI_Container_PaddingRight"></a> PaddingRight

```csharp
public int PaddingRight { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_UI_Container_PaddingTop"></a> PaddingTop

```csharp
public int PaddingTop { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Clockwork_UI_Container_AddChild_Clockwork_UI_Element_"></a> AddChild\(Element\)

```csharp
public void AddChild(Element element)
```

#### Parameters

`element` [Element](Clockwork.UI.Element.md)

### <a id="Clockwork_UI_Container_OnHeightUpdated"></a> OnHeightUpdated\(\)

```csharp
protected override void OnHeightUpdated()
```

### <a id="Clockwork_UI_Container_OnWidthUpdated"></a> OnWidthUpdated\(\)

```csharp
protected override void OnWidthUpdated()
```

### <a id="Clockwork_UI_Container_OnXUpdated"></a> OnXUpdated\(\)

```csharp
protected override void OnXUpdated()
```

### <a id="Clockwork_UI_Container_OnYUpdated"></a> OnYUpdated\(\)

```csharp
protected override void OnYUpdated()
```

