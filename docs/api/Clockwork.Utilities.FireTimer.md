# <a id="Clockwork_Utilities_FireTimer"></a> Class FireTimer

Namespace: [Clockwork.Utilities](Clockwork.Utilities.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class FireTimer : Entity
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Clockwork.Entity.md) ← 
[FireTimer](Clockwork.Utilities.FireTimer.md)

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

### <a id="Clockwork_Utilities_FireTimer__ctor_System_Single_"></a> FireTimer\(float\)

```csharp
public FireTimer(float cooldownTime)
```

#### Parameters

`cooldownTime` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Fields

### <a id="Clockwork_Utilities_FireTimer_CooldownTime"></a> CooldownTime

```csharp
public float CooldownTime
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Clockwork_Utilities_FireTimer_OnDraw"></a> OnDraw\(\)

```csharp
public override void OnDraw()
```

### <a id="Clockwork_Utilities_FireTimer_OnFired"></a> OnFired\(\)

```csharp
protected virtual void OnFired()
```

### <a id="Clockwork_Utilities_FireTimer_OnUpdate"></a> OnUpdate\(\)

```csharp
public override void OnUpdate()
```

### <a id="Clockwork_Utilities_FireTimer_Start"></a> Start\(\)

```csharp
public void Start()
```

### <a id="Clockwork_Utilities_FireTimer_Fired"></a> Fired

```csharp
public event FireTimer.FiredDelegate Fired
```

#### Event Type

 [FireTimer](Clockwork.Utilities.FireTimer.md).[FiredDelegate](Clockwork.Utilities.FireTimer.FiredDelegate.md)

