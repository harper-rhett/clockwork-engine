# <a id="Clockwork_PerformanceTracker"></a> Class PerformanceTracker

Namespace: [Clockwork](Clockwork.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class PerformanceTracker
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[PerformanceTracker](Clockwork.PerformanceTracker.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Fields

### <a id="Clockwork_PerformanceTracker_FramesTracked"></a> FramesTracked

```csharp
public static int FramesTracked
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Clockwork_PerformanceTracker_IsActive"></a> IsActive

```csharp
public bool IsActive { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Clockwork_PerformanceTracker_Finish"></a> Finish\(\)

```csharp
public void Finish()
```

### <a id="Clockwork_PerformanceTracker_GetAverageTime"></a> GetAverageTime\(\)

```csharp
public float GetAverageTime()
```

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_PerformanceTracker_Pause"></a> Pause\(\)

```csharp
public void Pause()
```

### <a id="Clockwork_PerformanceTracker_StartOrResume"></a> StartOrResume\(\)

```csharp
public void StartOrResume()
```

