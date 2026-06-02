# <a id="Clockwork_Profiler"></a> Class Profiler

Namespace: [Clockwork](Clockwork.md)  
Assembly: ClockworkEngine.dll  

```csharp
public static class Profiler
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Profiler](Clockwork.Profiler.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Properties

### <a id="Clockwork_Profiler_IsActive"></a> IsActive

```csharp
public static bool IsActive { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Clockwork_Profiler_DrawDebug_System_Int32_Clockwork_Graphics_Color_"></a> DrawDebug\(int, Color\)

```csharp
public static void DrawDebug(int fontSize, Color color)
```

#### Parameters

`fontSize` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`color` [Color](Clockwork.Graphics.Color.md)

### <a id="Clockwork_Profiler_FinishTracking_System_String_"></a> FinishTracking\(string\)

```csharp
public static void FinishTracking(string key)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Clockwork_Profiler_PauseTracking_System_String_"></a> PauseTracking\(string\)

```csharp
public static void PauseTracking(string key)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Clockwork_Profiler_StartOrResumeTracking_System_String_"></a> StartOrResumeTracking\(string\)

```csharp
public static void StartOrResumeTracking(string key)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

