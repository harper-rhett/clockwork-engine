# <a id="Clockwork_UI_Panel"></a> Class Panel

Namespace: [Clockwork.UI](Clockwork.UI.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class Panel : Entity, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Clockwork.Entity.md) ← 
[Panel](Clockwork.UI.Panel.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

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

### <a id="Clockwork_UI_Panel__ctor_Clockwork_UI_DrawContext_"></a> Panel\(DrawContext\)

```csharp
public Panel(DrawContext drawContext)
```

#### Parameters

`drawContext` [DrawContext](Clockwork.UI.DrawContext.md)

### <a id="Clockwork_UI_Panel__ctor_Clockwork_UI_Element_Clockwork_UI_DrawContext_"></a> Panel\(Element, DrawContext\)

```csharp
public Panel(Element rootElement, DrawContext drawContext)
```

#### Parameters

`rootElement` [Element](Clockwork.UI.Element.md)

`drawContext` [DrawContext](Clockwork.UI.DrawContext.md)

## Fields

### <a id="Clockwork_UI_Panel_RootElement"></a> RootElement

```csharp
public Element RootElement
```

#### Field Value

 [Element](Clockwork.UI.Element.md)

## Properties

### <a id="Clockwork_UI_Panel_Height"></a> Height

```csharp
public int Height { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_UI_Panel_HorizontalAlignment"></a> HorizontalAlignment

```csharp
public HorizontalAlignment HorizontalAlignment { get; set; }
```

#### Property Value

 [HorizontalAlignment](Clockwork.UI.HorizontalAlignment.md)

### <a id="Clockwork_UI_Panel_Scale"></a> Scale

```csharp
public float Scale { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_UI_Panel_VerticalAlignment"></a> VerticalAlignment

```csharp
public VerticalAlignment VerticalAlignment { get; set; }
```

#### Property Value

 [VerticalAlignment](Clockwork.UI.VerticalAlignment.md)

### <a id="Clockwork_UI_Panel_Width"></a> Width

```csharp
public int Width { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Clockwork_UI_Panel_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="Clockwork_UI_Panel_OnDraw"></a> OnDraw\(\)

```csharp
public override void OnDraw()
```

### <a id="Clockwork_UI_Panel_OnDrawGUI"></a> OnDrawGUI\(\)

```csharp
public override void OnDrawGUI()
```

### <a id="Clockwork_UI_Panel_OnRemovedFromScene"></a> OnRemovedFromScene\(\)

```csharp
public override void OnRemovedFromScene()
```

### <a id="Clockwork_UI_Panel_OnUpdate"></a> OnUpdate\(\)

```csharp
public override void OnUpdate()
```

