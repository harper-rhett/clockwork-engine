# <a id="HarpEngine_Shapes_PolygonShape"></a> Class PolygonShape

Namespace: [HarpEngine.Shapes](HarpEngine.Shapes.md)  
Assembly: HarpEngine.dll  

```csharp
public class PolygonShape : Entity, ITransform2D
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](HarpEngine.Entity.md) ← 
[PolygonShape](HarpEngine.Shapes.PolygonShape.md)

#### Implements

[ITransform2D](HarpEngine.Utilities.ITransform2D.md)

#### Inherited Members

[Entity.Scene](HarpEngine.Entity.md\#HarpEngine\_Entity\_Scene), 
[Entity.IsUpdating](HarpEngine.Entity.md\#HarpEngine\_Entity\_IsUpdating), 
[Entity.IsRendering](HarpEngine.Entity.md\#HarpEngine\_Entity\_IsRendering), 
[Entity.UpdateLayer](HarpEngine.Entity.md\#HarpEngine\_Entity\_UpdateLayer), 
[Entity.DrawLayer](HarpEngine.Entity.md\#HarpEngine\_Entity\_DrawLayer), 
[Entity.OnUpdate\(\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_OnUpdate), 
[Entity.OnDraw\(\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_OnDraw), 
[Entity.OnDrawGUI\(\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_OnDrawGUI), 
[Entity.Remove\(\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_Remove), 
[Entity.OnAddedToScene\(\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_OnAddedToScene), 
[Entity.OnRemovedFromScene\(\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_OnRemovedFromScene), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="HarpEngine_Shapes_PolygonShape__ctor_System_Single_System_Int32_HarpEngine_Graphics_Color_"></a> PolygonShape\(float, int, Color\)

```csharp
public PolygonShape(float radius, int sideCount, Color color)
```

#### Parameters

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`sideCount` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`color` [Color](HarpEngine.Graphics.Color.md)

## Fields

### <a id="HarpEngine_Shapes_PolygonShape_Color"></a> Color

```csharp
public Color Color
```

#### Field Value

 [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Shapes_PolygonShape_Radius"></a> Radius

```csharp
public float Radius
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="HarpEngine_Shapes_PolygonShape_SideCount"></a> SideCount

```csharp
public int SideCount
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="HarpEngine_Shapes_PolygonShape_Transform"></a> Transform

```csharp
public Transform2D Transform { get; set; }
```

#### Property Value

 [Transform2D](HarpEngine.Utilities.Transform2D.md)

## Methods

### <a id="HarpEngine_Shapes_PolygonShape_OnDraw"></a> OnDraw\(\)

```csharp
public override void OnDraw()
```

