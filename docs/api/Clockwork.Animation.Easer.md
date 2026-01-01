# <a id="Clockwork_Animation_Easer"></a> Class Easer

Namespace: [Clockwork.Animation](Clockwork.Animation.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class Easer : Entity
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Clockwork.Entity.md) ← 
[Easer](Clockwork.Animation.Easer.md)

#### Derived

[Transform2DEaser](Clockwork.Animation.Transform2DEaser.md)

#### Inherited Members

[Entity.Scene](Clockwork.Entity.md\#Clockwork\_Entity\_Scene), 
[Entity.IsUpdating](Clockwork.Entity.md\#Clockwork\_Entity\_IsUpdating), 
[Entity.IsRendering](Clockwork.Entity.md\#Clockwork\_Entity\_IsRendering), 
[Entity.UpdateLayer](Clockwork.Entity.md\#Clockwork\_Entity\_UpdateLayer), 
[Entity.DrawLayer](Clockwork.Entity.md\#Clockwork\_Entity\_DrawLayer), 
[Entity.OnUpdate\(\)](Clockwork.Entity.md\#Clockwork\_Entity\_OnUpdate), 
[Entity.OnDraw\(\)](Clockwork.Entity.md\#Clockwork\_Entity\_OnDraw), 
[Entity.OnDrawGUI\(\)](Clockwork.Entity.md\#Clockwork\_Entity\_OnDrawGUI), 
[Entity.Remove\(\)](Clockwork.Entity.md\#Clockwork\_Entity\_Remove), 
[Entity.OnAddedToScene\(\)](Clockwork.Entity.md\#Clockwork\_Entity\_OnAddedToScene), 
[Entity.OnRemovedFromScene\(\)](Clockwork.Entity.md\#Clockwork\_Entity\_OnRemovedFromScene), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Clockwork_Animation_Easer__ctor_System_Single_"></a> Easer\(float\)

```csharp
public Easer(float easeSeconds)
```

#### Parameters

`easeSeconds` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Fields

### <a id="Clockwork_Animation_Easer_Curve"></a> Curve

```csharp
public Curve Curve
```

#### Field Value

 [Curve](Clockwork.Animation.Curve.md)

### <a id="Clockwork_Animation_Easer_RemoveOnFinished"></a> RemoveOnFinished

```csharp
public bool RemoveOnFinished
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Animation_Easer_Rewind"></a> Rewind

```csharp
public bool Rewind
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Properties

### <a id="Clockwork_Animation_Easer_CurveProgress"></a> CurveProgress

```csharp
public float CurveProgress { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Animation_Easer_IsEasing"></a> IsEasing

```csharp
public bool IsEasing { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Animation_Easer_Progress"></a> Progress

```csharp
public float Progress { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Clockwork_Animation_Easer_EaseColor_Clockwork_Graphics_Color_Clockwork_Graphics_Color_"></a> EaseColor\(Color, Color\)

```csharp
public Color EaseColor(Color from, Color to)
```

#### Parameters

`from` [Color](Clockwork.Graphics.Color.md)

`to` [Color](Clockwork.Graphics.Color.md)

#### Returns

 [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Animation_Easer_EaseFloat_System_Single_System_Single_"></a> EaseFloat\(float, float\)

```csharp
public float EaseFloat(float from, float to)
```

#### Parameters

`from` [float](https://learn.microsoft.com/dotnet/api/system.single)

`to` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Animation_Easer_EaseQuaternion_System_Numerics_Quaternion_System_Numerics_Quaternion_"></a> EaseQuaternion\(Quaternion, Quaternion\)

```csharp
public Quaternion EaseQuaternion(Quaternion from, Quaternion to)
```

#### Parameters

`from` [Quaternion](https://learn.microsoft.com/dotnet/api/system.numerics.quaternion)

`to` [Quaternion](https://learn.microsoft.com/dotnet/api/system.numerics.quaternion)

#### Returns

 [Quaternion](https://learn.microsoft.com/dotnet/api/system.numerics.quaternion)

### <a id="Clockwork_Animation_Easer_EaseVector2_System_Numerics_Vector2_System_Numerics_Vector2_"></a> EaseVector2\(Vector2, Vector2\)

```csharp
public Vector2 EaseVector2(Vector2 from, Vector2 to)
```

#### Parameters

`from` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`to` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_Animation_Easer_EaseVector3_System_Numerics_Vector3_System_Numerics_Vector3_"></a> EaseVector3\(Vector3, Vector3\)

```csharp
public Vector3 EaseVector3(Vector3 from, Vector3 to)
```

#### Parameters

`from` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`to` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Clockwork_Animation_Easer_Finish"></a> Finish\(\)

```csharp
public void Finish()
```

### <a id="Clockwork_Animation_Easer_OnDraw"></a> OnDraw\(\)

```csharp
public override void OnDraw()
```

### <a id="Clockwork_Animation_Easer_OnEasing"></a> OnEasing\(\)

```csharp
protected virtual void OnEasing()
```

### <a id="Clockwork_Animation_Easer_OnUpdate"></a> OnUpdate\(\)

```csharp
public override void OnUpdate()
```

### <a id="Clockwork_Animation_Easer_Skip"></a> Skip\(\)

```csharp
public void Skip()
```

### <a id="Clockwork_Animation_Easer_Start"></a> Start\(\)

```csharp
public void Start()
```

### <a id="Clockwork_Animation_Easer_Easing"></a> Easing

```csharp
public event Easer.EasingDelegate Easing
```

#### Event Type

 [Easer](Clockwork.Animation.Easer.md).[EasingDelegate](Clockwork.Animation.Easer.EasingDelegate.md)

### <a id="Clockwork_Animation_Easer_Finished"></a> Finished

```csharp
public event Easer.FinishedDelegate Finished
```

#### Event Type

 [Easer](Clockwork.Animation.Easer.md).[FinishedDelegate](Clockwork.Animation.Easer.FinishedDelegate.md)

