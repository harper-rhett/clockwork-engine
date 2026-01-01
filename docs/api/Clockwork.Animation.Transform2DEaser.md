# <a id="Clockwork_Animation_Transform2DEaser"></a> Class Transform2DEaser

Namespace: [Clockwork.Animation](Clockwork.Animation.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class Transform2DEaser : Easer
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Clockwork.Entity.md) ← 
[Easer](Clockwork.Animation.Easer.md) ← 
[Transform2DEaser](Clockwork.Animation.Transform2DEaser.md)

#### Inherited Members

[Easer.Curve](Clockwork.Animation.Easer.md\#Clockwork\_Animation\_Easer\_Curve), 
[Easer.Easing](Clockwork.Animation.Easer.md\#Clockwork\_Animation\_Easer\_Easing), 
[Easer.Finished](Clockwork.Animation.Easer.md\#Clockwork\_Animation\_Easer\_Finished), 
[Easer.IsEasing](Clockwork.Animation.Easer.md\#Clockwork\_Animation\_Easer\_IsEasing), 
[Easer.Progress](Clockwork.Animation.Easer.md\#Clockwork\_Animation\_Easer\_Progress), 
[Easer.CurveProgress](Clockwork.Animation.Easer.md\#Clockwork\_Animation\_Easer\_CurveProgress), 
[Easer.RemoveOnFinished](Clockwork.Animation.Easer.md\#Clockwork\_Animation\_Easer\_RemoveOnFinished), 
[Easer.Rewind](Clockwork.Animation.Easer.md\#Clockwork\_Animation\_Easer\_Rewind), 
[Easer.OnUpdate\(\)](Clockwork.Animation.Easer.md\#Clockwork\_Animation\_Easer\_OnUpdate), 
[Easer.OnDraw\(\)](Clockwork.Animation.Easer.md\#Clockwork\_Animation\_Easer\_OnDraw), 
[Easer.OnEasing\(\)](Clockwork.Animation.Easer.md\#Clockwork\_Animation\_Easer\_OnEasing), 
[Easer.Start\(\)](Clockwork.Animation.Easer.md\#Clockwork\_Animation\_Easer\_Start), 
[Easer.Skip\(\)](Clockwork.Animation.Easer.md\#Clockwork\_Animation\_Easer\_Skip), 
[Easer.Finish\(\)](Clockwork.Animation.Easer.md\#Clockwork\_Animation\_Easer\_Finish), 
[Easer.EaseFloat\(float, float\)](Clockwork.Animation.Easer.md\#Clockwork\_Animation\_Easer\_EaseFloat\_System\_Single\_System\_Single\_), 
[Easer.EaseVector2\(Vector2, Vector2\)](Clockwork.Animation.Easer.md\#Clockwork\_Animation\_Easer\_EaseVector2\_System\_Numerics\_Vector2\_System\_Numerics\_Vector2\_), 
[Easer.EaseVector3\(Vector3, Vector3\)](Clockwork.Animation.Easer.md\#Clockwork\_Animation\_Easer\_EaseVector3\_System\_Numerics\_Vector3\_System\_Numerics\_Vector3\_), 
[Easer.EaseQuaternion\(Quaternion, Quaternion\)](Clockwork.Animation.Easer.md\#Clockwork\_Animation\_Easer\_EaseQuaternion\_System\_Numerics\_Quaternion\_System\_Numerics\_Quaternion\_), 
[Easer.EaseColor\(Color, Color\)](Clockwork.Animation.Easer.md\#Clockwork\_Animation\_Easer\_EaseColor\_Clockwork\_Graphics\_Color\_Clockwork\_Graphics\_Color\_), 
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

### <a id="Clockwork_Animation_Transform2DEaser__ctor_Clockwork_Utilities_Transform2D_System_Single_"></a> Transform2DEaser\(Transform2D, float\)

```csharp
public Transform2DEaser(Transform2D transform, float easeSeconds)
```

#### Parameters

`transform` [Transform2D](Clockwork.Utilities.Transform2D.md)

`easeSeconds` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Fields

### <a id="Clockwork_Animation_Transform2DEaser_TargetLocalPosition"></a> TargetLocalPosition

```csharp
public Vector2 TargetLocalPosition
```

#### Field Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_Animation_Transform2DEaser_TargetLocalRotation"></a> TargetLocalRotation

```csharp
public float TargetLocalRotation
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Animation_Transform2DEaser_TargetWorldPosition"></a> TargetWorldPosition

```csharp
public Vector2 TargetWorldPosition
```

#### Field Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Clockwork_Animation_Transform2DEaser_TargetWorldRotation"></a> TargetWorldRotation

```csharp
public float TargetWorldRotation
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Clockwork_Animation_Transform2DEaser_OnEasing"></a> OnEasing\(\)

```csharp
protected override void OnEasing()
```

### <a id="Clockwork_Animation_Transform2DEaser_SerializeTransform"></a> SerializeTransform\(\)

```csharp
public void SerializeTransform()
```

