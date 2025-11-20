# <a id="HarpEngine_Utilities_TriggerTimer"></a> Class TriggerTimer

Namespace: [HarpEngine.Utilities](HarpEngine.Utilities.md)  
Assembly: HarpEngine.dll  

```csharp
public class TriggerTimer : Entity
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](HarpEngine.Entity.md) ← 
[TriggerTimer](HarpEngine.Utilities.TriggerTimer.md)

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

### <a id="HarpEngine_Utilities_TriggerTimer__ctor_System_Single_"></a> TriggerTimer\(float\)

```csharp
public TriggerTimer(float triggerSeconds)
```

#### Parameters

`triggerSeconds` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Fields

### <a id="HarpEngine_Utilities_TriggerTimer_RemoveOnTriggered"></a> RemoveOnTriggered

```csharp
public bool RemoveOnTriggered
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="HarpEngine_Utilities_TriggerTimer_OnTriggered"></a> OnTriggered\(\)

```csharp
public virtual void OnTriggered()
```

### <a id="HarpEngine_Utilities_TriggerTimer_OnUpdate"></a> OnUpdate\(\)

```csharp
public override void OnUpdate()
```

### <a id="HarpEngine_Utilities_TriggerTimer_Skip"></a> Skip\(\)

```csharp
public void Skip()
```

### <a id="HarpEngine_Utilities_TriggerTimer_Start"></a> Start\(\)

```csharp
public void Start()
```

### <a id="HarpEngine_Utilities_TriggerTimer_Trigger"></a> Trigger\(\)

```csharp
protected void Trigger()
```

### <a id="HarpEngine_Utilities_TriggerTimer_Triggered"></a> Triggered

```csharp
public event TriggerTimer.TriggeredDelegate Triggered
```

#### Event Type

 [TriggerTimer](HarpEngine.Utilities.TriggerTimer.md).[TriggeredDelegate](HarpEngine.Utilities.TriggerTimer.TriggeredDelegate.md)

