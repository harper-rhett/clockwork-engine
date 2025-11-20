# <a id="HarpEngine_Animation_Transform2DEaser"></a> Class Transform2DEaser

Namespace: [HarpEngine.Animation](HarpEngine.Animation.md)  
Assembly: HarpEngine.dll  

```csharp
public class Transform2DEaser : Easer
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](HarpEngine.Entity.md) ← 
[Easer](HarpEngine.Animation.Easer.md) ← 
[Transform2DEaser](HarpEngine.Animation.Transform2DEaser.md)

#### Inherited Members

[Easer.Curve](HarpEngine.Animation.Easer.md\#HarpEngine\_Animation\_Easer\_Curve), 
[Easer.Easing](HarpEngine.Animation.Easer.md\#HarpEngine\_Animation\_Easer\_Easing), 
[Easer.Finished](HarpEngine.Animation.Easer.md\#HarpEngine\_Animation\_Easer\_Finished), 
[Easer.IsEasing](HarpEngine.Animation.Easer.md\#HarpEngine\_Animation\_Easer\_IsEasing), 
[Easer.Progress](HarpEngine.Animation.Easer.md\#HarpEngine\_Animation\_Easer\_Progress), 
[Easer.CurveProgress](HarpEngine.Animation.Easer.md\#HarpEngine\_Animation\_Easer\_CurveProgress), 
[Easer.RemoveOnFinished](HarpEngine.Animation.Easer.md\#HarpEngine\_Animation\_Easer\_RemoveOnFinished), 
[Easer.Rewind](HarpEngine.Animation.Easer.md\#HarpEngine\_Animation\_Easer\_Rewind), 
[Easer.OnUpdate\(\)](HarpEngine.Animation.Easer.md\#HarpEngine\_Animation\_Easer\_OnUpdate), 
[Easer.OnDraw\(\)](HarpEngine.Animation.Easer.md\#HarpEngine\_Animation\_Easer\_OnDraw), 
[Easer.OnEasing\(\)](HarpEngine.Animation.Easer.md\#HarpEngine\_Animation\_Easer\_OnEasing), 
[Easer.Start\(\)](HarpEngine.Animation.Easer.md\#HarpEngine\_Animation\_Easer\_Start), 
[Easer.Skip\(\)](HarpEngine.Animation.Easer.md\#HarpEngine\_Animation\_Easer\_Skip), 
[Easer.EaseFloat\(float, float\)](HarpEngine.Animation.Easer.md\#HarpEngine\_Animation\_Easer\_EaseFloat\_System\_Single\_System\_Single\_), 
[Easer.EaseVector2\(Vector2, Vector2\)](HarpEngine.Animation.Easer.md\#HarpEngine\_Animation\_Easer\_EaseVector2\_System\_Numerics\_Vector2\_System\_Numerics\_Vector2\_), 
[Easer.EaseVector3\(Vector3, Vector3\)](HarpEngine.Animation.Easer.md\#HarpEngine\_Animation\_Easer\_EaseVector3\_System\_Numerics\_Vector3\_System\_Numerics\_Vector3\_), 
[Easer.EaseQuaternion\(Quaternion, Quaternion\)](HarpEngine.Animation.Easer.md\#HarpEngine\_Animation\_Easer\_EaseQuaternion\_System\_Numerics\_Quaternion\_System\_Numerics\_Quaternion\_), 
[Easer.EaseColor\(Color, Color\)](HarpEngine.Animation.Easer.md\#HarpEngine\_Animation\_Easer\_EaseColor\_HarpEngine\_Graphics\_Color\_HarpEngine\_Graphics\_Color\_), 
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

### <a id="HarpEngine_Animation_Transform2DEaser__ctor_HarpEngine_Utilities_Transform2D_System_Single_"></a> Transform2DEaser\(Transform2D, float\)

```csharp
public Transform2DEaser(Transform2D transform, float easeSeconds)
```

#### Parameters

`transform` [Transform2D](HarpEngine.Utilities.Transform2D.md)

`easeSeconds` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Fields

### <a id="HarpEngine_Animation_Transform2DEaser_TargetLocalPosition"></a> TargetLocalPosition

```csharp
public Vector2 TargetLocalPosition
```

#### Field Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="HarpEngine_Animation_Transform2DEaser_TargetLocalRotation"></a> TargetLocalRotation

```csharp
public float TargetLocalRotation
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="HarpEngine_Animation_Transform2DEaser_TargetWorldPosition"></a> TargetWorldPosition

```csharp
public Vector2 TargetWorldPosition
```

#### Field Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="HarpEngine_Animation_Transform2DEaser_TargetWorldRotation"></a> TargetWorldRotation

```csharp
public float TargetWorldRotation
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="HarpEngine_Animation_Transform2DEaser_OnEasing"></a> OnEasing\(\)

```csharp
protected override void OnEasing()
```

### <a id="HarpEngine_Animation_Transform2DEaser_SerializeTransform"></a> SerializeTransform\(\)

```csharp
public void SerializeTransform()
```

