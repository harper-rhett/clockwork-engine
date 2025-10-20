namespace HarpEngine.Graphics;

public enum UniformDataType
{
	Float = 0,
	Vec2,
	Vec3,
	Vec4,
	Int,
	IVec2,
	IVec3,
	IVec4,
	UInt,
	UIVec2,
	UIVec3,
	UIVec4,
	Sampler2D
}

[StructLayout(LayoutKind.Sequential, Size = 16)]
public unsafe struct Shader : IDisposable
{
	private uint ID;
	private int* Locations;

	private Dictionary<string, int> variableLocations;

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "BeginShaderMode")]
	public static extern void BeginUsing(Shader shader);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "EndShaderMode")]
	public static extern void EndUsing();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LoadShader")]
	public static extern Shader LoadFromFile(string vertexFileName, string fragmentFileName);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LoadShaderFromMemory")]
	public static extern Shader LoadFromCode(string vertexCode, string fragmentCode);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IsShaderValid")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool IsThisValid(Shader shader);
	public bool IsValid => IsThisValid(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetShaderLocation")]
	private static extern int GetVariableLocation(Shader shader, string variableName);
	internal int GetVariableLocation(string variableName) => GetVariableLocation(this, variableName);

	internal int GetCachedVariableLocation(string variableName)
	{
		bool containsLocation = variableLocations.TryGetValue(variableName, out int variableLocation);
		if (containsLocation) return variableLocation;
		variableLocation = GetVariableLocation(variableName);
		variableLocations[variableName] = variableLocation;
		return variableLocation;
	}

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetShaderValue")]
	private static extern void SetValue(Shader shader, int location, void* value, UniformDataType dataType);
	public void SetValue(string variableName, void* value, UniformDataType dataType)
	{
		int location = GetCachedVariableLocation(variableName);
		SetValue(this, location, value, dataType);
	}

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetShaderValueV")]
	private static extern void SetArray(Shader shader, int locIndex, void* value, UniformDataType dataType, int count);
	public void SetArray(string variableName, void* value, UniformDataType dataType, int count)
	{
		int location = GetCachedVariableLocation(variableName);
		SetArray(this, location, value, dataType, count);
	}

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetShaderValueMatrix")]
	private static extern void SetMatrix(Shader shader, int location, Matrix4x4 matrix);
	public void SetMatrix(string variableName, Matrix4x4 matrix)
	{
		int location = GetCachedVariableLocation(variableName);
		SetMatrix(this, location, matrix);
	}

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetShaderValueTexture")]
	private static extern void SetTexture(Shader shader, int location, Texture texture);
	public void SetTexture(string variableName, Texture texture)
	{
		int location = GetCachedVariableLocation(variableName);
		SetTexture(this, location, texture);
	}

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "UnloadShader")]
	private static extern void Unload(Shader shader);

	public void Dispose()
	{
		Unload(this);
	}
}