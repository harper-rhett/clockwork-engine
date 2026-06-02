# <a id="Clockwork_Windowing_WindowRenderer"></a> Class WindowRenderer

Namespace: [Clockwork.Windowing](Clockwork.Windowing.md)  
Assembly: ClockworkEngine.dll  

```csharp
public abstract class WindowRenderer
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[WindowRenderer](Clockwork.Windowing.WindowRenderer.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Fields

### <a id="Clockwork_Windowing_WindowRenderer_gameHeight"></a> gameHeight

```csharp
protected int gameHeight
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Windowing_WindowRenderer_gameWidth"></a> gameWidth

```csharp
protected int gameWidth
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Windowing_WindowRenderer_windowHeight"></a> windowHeight

```csharp
protected int windowHeight
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Windowing_WindowRenderer_windowWidth"></a> windowWidth

```csharp
protected int windowWidth
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Clockwork_Windowing_WindowRenderer_DidResize"></a> DidResize

```csharp
protected bool DidResize { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Clockwork_Windowing_WindowRenderer_RefreshDimensions_Clockwork_Graphics_RenderTexture_"></a> RefreshDimensions\(RenderTexture\)

```csharp
protected void RefreshDimensions(RenderTexture gameRenderTexture)
```

#### Parameters

`gameRenderTexture` [RenderTexture](Clockwork.Graphics.RenderTexture.md)

### <a id="Clockwork_Windowing_WindowRenderer_SetClipped"></a> SetClipped\(\)

```csharp
public static void SetClipped()
```

### <a id="Clockwork_Windowing_WindowRenderer_SetUnclipped_Clockwork_Graphics_Color_"></a> SetUnclipped\(Color\)

```csharp
public static void SetUnclipped(Color borderColor)
```

#### Parameters

`borderColor` [Color](Clockwork.Graphics.Color.md)

