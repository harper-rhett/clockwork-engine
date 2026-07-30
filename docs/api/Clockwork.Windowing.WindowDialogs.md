# <a id="Clockwork_Windowing_WindowDialogs"></a> Class WindowDialogs

Namespace: [Clockwork.Windowing](Clockwork.Windowing.md)  
Assembly: ClockworkEngine.dll  

```csharp
public static class WindowDialogs
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[WindowDialogs](Clockwork.Windowing.WindowDialogs.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Methods

### <a id="Clockwork_Windowing_WindowDialogs_TrySaveFile_System_String_System_String__System_String_System_String___System_String_"></a> TrySaveFile\(string, out string, string, string\[\], string\)

```csharp
public static bool TrySaveFile(string title, out string filePath, string defaultPath = "", string[] extensionFilters = null, string filterName = null)
```

#### Parameters

`title` [string](https://learn.microsoft.com/dotnet/api/system.string)

`filePath` [string](https://learn.microsoft.com/dotnet/api/system.string)

`defaultPath` [string](https://learn.microsoft.com/dotnet/api/system.string)

`extensionFilters` [string](https://learn.microsoft.com/dotnet/api/system.string)\[\]

`filterName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Windowing_WindowDialogs_TrySelectFile_System_String_System_String____System_String_System_Boolean_System_String___System_String_"></a> TrySelectFile\(string, out string\[\], string, bool, string\[\], string\)

```csharp
public static bool TrySelectFile(string title, out string[] filePaths, string defaultPath = "", bool allowMultipleSelections = false, string[] extensionfilters = null, string filterName = null)
```

#### Parameters

`title` [string](https://learn.microsoft.com/dotnet/api/system.string)

`filePaths` [string](https://learn.microsoft.com/dotnet/api/system.string)\[\]

`defaultPath` [string](https://learn.microsoft.com/dotnet/api/system.string)

`allowMultipleSelections` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`extensionfilters` [string](https://learn.microsoft.com/dotnet/api/system.string)\[\]

`filterName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Clockwork_Windowing_WindowDialogs_TrySelectFolder_System_String_System_String__System_String_"></a> TrySelectFolder\(string, out string, string\)

```csharp
public static bool TrySelectFolder(string title, out string folderPath, string defaultPath = "")
```

#### Parameters

`title` [string](https://learn.microsoft.com/dotnet/api/system.string)

`folderPath` [string](https://learn.microsoft.com/dotnet/api/system.string)

`defaultPath` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

