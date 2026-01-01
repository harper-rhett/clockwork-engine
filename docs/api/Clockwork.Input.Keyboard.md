# <a id="Clockwork_Input_Keyboard"></a> Class Keyboard

Namespace: [Clockwork.Input](Clockwork.Input.md)  
Assembly: ClockworkEngine.dll  

```csharp
public static class Keyboard
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Keyboard](Clockwork.Input.Keyboard.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Methods

### <a id="Clockwork_Input_Keyboard_GetKeyPressed"></a> GetKeyPressed\(\)

```csharp
public static extern KeyboardKey GetKeyPressed()
```

#### Returns

 [KeyboardKey](Clockwork.Input.KeyboardKey.md)

### <a id="Clockwork_Input_Keyboard_GetUnicodePressed"></a> GetUnicodePressed\(\)

```csharp
public static extern int GetUnicodePressed()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Clockwork_Input_Keyboard_IsKeyDown_Clockwork_Input_KeyboardKey_"></a> IsKeyDown\(KeyboardKey\)

```csharp
public static extern bool IsKeyDown(KeyboardKey key)
```

#### Parameters

`key` [KeyboardKey](Clockwork.Input.KeyboardKey.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Input_Keyboard_IsKeyPressed_Clockwork_Input_KeyboardKey_"></a> IsKeyPressed\(KeyboardKey\)

```csharp
public static extern bool IsKeyPressed(KeyboardKey key)
```

#### Parameters

`key` [KeyboardKey](Clockwork.Input.KeyboardKey.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Input_Keyboard_IsKeyReleased_Clockwork_Input_KeyboardKey_"></a> IsKeyReleased\(KeyboardKey\)

```csharp
public static extern bool IsKeyReleased(KeyboardKey key)
```

#### Parameters

`key` [KeyboardKey](Clockwork.Input.KeyboardKey.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Input_Keyboard_IsKeyRepeating_Clockwork_Input_KeyboardKey_"></a> IsKeyRepeating\(KeyboardKey\)

```csharp
public static extern bool IsKeyRepeating(KeyboardKey key)
```

#### Parameters

`key` [KeyboardKey](Clockwork.Input.KeyboardKey.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

