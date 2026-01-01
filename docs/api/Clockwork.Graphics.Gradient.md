# <a id="Clockwork_Graphics_Gradient"></a> Class Gradient

Namespace: [Clockwork.Graphics](Clockwork.Graphics.md)  
Assembly: ClockworkEngine.dll  

```csharp
public class Gradient
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Gradient](Clockwork.Graphics.Gradient.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Clockwork_Graphics_Gradient__ctor_Clockwork_Graphics_Color___"></a> Gradient\(params Color\[\]\)

```csharp
public Gradient(params Color[] colors)
```

#### Parameters

`colors` [Color](Clockwork.Graphics.Color.md)\[\]

## Methods

### <a id="Clockwork_Graphics_Gradient_AddColor_Clockwork_Graphics_Color_System_Single_"></a> AddColor\(Color, float\)

```csharp
public void AddColor(Color color, float position)
```

#### Parameters

`color` [Color](Clockwork.Graphics.Color.md)

`position` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Clockwork_Graphics_Gradient_Sample_System_Single_"></a> Sample\(float\)

```csharp
public Color Sample(float position)
```

#### Parameters

`position` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Color](Clockwork.Graphics.Color.md)

