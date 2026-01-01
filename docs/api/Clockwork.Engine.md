# <a id="Clockwork_Engine"></a> Class Engine

Namespace: [Clockwork](Clockwork.md)  
Assembly: ClockworkEngine.dll  

```csharp
public static class Engine
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Engine](Clockwork.Engine.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Properties

### <a id="Clockwork_Engine_FPS"></a> FPS

```csharp
public static float FPS { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Engine_FrameTime"></a> FrameTime

```csharp
public static float FrameTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Engine_GameHeight"></a> GameHeight

```csharp
public static int GameHeight { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Engine_GameSize"></a> GameSize

```csharp
public static Coordinate GameSize { get; set; }
```

#### Property Value

 [Coordinate](Clockwork.Utilities.Coordinate.md)

### <a id="Clockwork_Engine_GameWidth"></a> GameWidth

```csharp
public static int GameWidth { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Engine_HalfGameHeight"></a> HalfGameHeight

```csharp
public static int HalfGameHeight { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Engine_HalfGameWidth"></a> HalfGameWidth

```csharp
public static int HalfGameWidth { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Engine_IsScreenshotBursting"></a> IsScreenshotBursting

```csharp
public static bool IsScreenshotBursting { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Engine_TargetFPS"></a> TargetFPS

```csharp
public static int TargetFPS { set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Clockwork_Engine_DrawDebug_System_Int32_System_Int32_"></a> DrawDebug\(int, int\)

```csharp
public static void DrawDebug(int fontSize, int spacing)
```

#### Parameters

`fontSize` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`spacing` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Engine_Initialize_System_String_System_Int32_System_Int32_"></a> Initialize\(string, int, int\)

```csharp
public static void Initialize(string windowTitle, int gameWidth, int gameHeight)
```

#### Parameters

`windowTitle` [string](https://learn.microsoft.com/dotnet/api/system.string)

`gameWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`gameHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Engine_Start_Clockwork_Game_"></a> Start\(Game\)

```csharp
public static void Start(Game game)
```

#### Parameters

`game` [Game](Clockwork.Game.md)

### <a id="Clockwork_Engine_StartScreenshotBurst_System_String_"></a> StartScreenshotBurst\(string\)

```csharp
public static void StartScreenshotBurst(string folderPath)
```

#### Parameters

`folderPath` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Clockwork_Engine_StopScreenshotBurst"></a> StopScreenshotBurst\(\)

```csharp
public static void StopScreenshotBurst()
```

### <a id="Clockwork_Engine_TakeScreenshot_System_String_"></a> TakeScreenshot\(string\)

```csharp
public static void TakeScreenshot(string folderPath)
```

#### Parameters

`folderPath` [string](https://learn.microsoft.com/dotnet/api/system.string)

