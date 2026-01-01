# <a id="Clockwork_Utilities_TriggerTimer"></a> Class TriggerTimer

Namespace: [Clockwork.Utilities](Clockwork.Utilities.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class TriggerTimer : Entity
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Clockwork.Entity.md) ← 
[TriggerTimer](Clockwork.Utilities.TriggerTimer.md)

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

### <a id="Clockwork_Utilities_TriggerTimer__ctor_System_Single_"></a> TriggerTimer\(float\)

```csharp
public TriggerTimer(float triggerSeconds)
```

#### Parameters

`triggerSeconds` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Fields

### <a id="Clockwork_Utilities_TriggerTimer_RemoveOnTriggered"></a> RemoveOnTriggered

```csharp
public bool RemoveOnTriggered
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Clockwork_Utilities_TriggerTimer_OnTriggered"></a> OnTriggered\(\)

```csharp
public virtual void OnTriggered()
```

### <a id="Clockwork_Utilities_TriggerTimer_OnUpdate"></a> OnUpdate\(\)

```csharp
public override void OnUpdate()
```

### <a id="Clockwork_Utilities_TriggerTimer_Skip"></a> Skip\(\)

```csharp
public void Skip()
```

### <a id="Clockwork_Utilities_TriggerTimer_Start"></a> Start\(\)

```csharp
public void Start()
```

### <a id="Clockwork_Utilities_TriggerTimer_Trigger"></a> Trigger\(\)

```csharp
protected void Trigger()
```

### <a id="Clockwork_Utilities_TriggerTimer_Triggered"></a> Triggered

```csharp
public event TriggerTimer.TriggeredDelegate Triggered
```

#### Event Type

 [TriggerTimer](Clockwork.Utilities.TriggerTimer.md).[TriggeredDelegate](Clockwork.Utilities.TriggerTimer.TriggeredDelegate.md)

