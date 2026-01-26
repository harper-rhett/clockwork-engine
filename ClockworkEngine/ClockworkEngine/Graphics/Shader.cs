using System.Runtime.InteropServices;
using System.Numerics;
using Clockwork.Graphics;

namespace Clockwork.Graphics;

[StructLayout(LayoutKind.Sequential, Size = 16)]
public unsafe struct Shader : IDisposable
{
	private uint ID;
	private int* Locations;

	private Dictionary<string, int> variableLocations;

	public Shader()
	{
		variableLocations = new();
	}

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "BeginShaderMode")]
	public static extern void BeginUsing(Shader shader);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "EndShaderMode")]
	public static extern void EndUsing();

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LoadShader")]
	public static extern Shader LoadFromFile(string vertexFileName, string fragmentFileName);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LoadShaderFromMemory")]
	public static extern Shader LoadFromCode(string vertexCode, string fragmentCode);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IsShaderValid")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool IsThisValid(Shader shader);
	public bool IsValid => IsThisValid(this);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetShaderLocation")]
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

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetShaderValue")]
	private static extern void SetValue(Shader shader, int location, IntPtr value, UniformDataType dataType);
	public void SetValue(string variableName, IntPtr value, UniformDataType dataType)
	{
		int location = GetCachedVariableLocation(variableName);
		SetValue(this, location, value, dataType);
	}
	public void SetFloat(string variableName, float value) => SetValue(variableName, (IntPtr)(&value), UniformDataType.Float);
	public void SetInteger(string variableName, int value) => SetValue(variableName, (IntPtr)(&value), UniformDataType.Int);
	public void SetVector2(string variableName, Vector2 value) => SetValue(variableName, (IntPtr)(&value), UniformDataType.Vec2);
	public void SetVector3(string variableName, Vector3 value) => SetValue(variableName, (IntPtr)(&value), UniformDataType.Vec3);
	public void SetVector4(string variableName, Vector4 value) => SetValue(variableName, (IntPtr)(&value), UniformDataType.Vec4);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetShaderValueV")]
	private static extern void SetArray(Shader shader, int locIndex, IntPtr value, UniformDataType dataType, int count);
	public void SetArray(string variableName, IntPtr value, UniformDataType dataType, int count)
	{
		int location = GetCachedVariableLocation(variableName);
		SetArray(this, location, value, dataType, count);
	}
	public void SetFloats(string variableName, float[] values)
	{
		fixed (float* ptr = values)
		{
			SetArray(variableName, (IntPtr)ptr, UniformDataType.Float, values.Length);
		}
	}
	public void SetIntegers(string variableName, int[] values)
	{
		fixed (int* ptr = values)
		{
			SetArray(variableName, (IntPtr)ptr, UniformDataType.Int, values.Length);
		}
	}
	public void SetVector2s(string variableName, Vector2[] values)
	{
		fixed (Vector2* ptr = values)
		{
			SetArray(variableName, (IntPtr)ptr, UniformDataType.Vec2, values.Length);
		}
	}
	public void SetVector3s(string variableName, Vector3[] values)
	{
		fixed (Vector3* ptr = values)
		{
			SetArray(variableName, (IntPtr)ptr, UniformDataType.Vec3, values.Length);
		}
	}
	public void SetVector4s(string variableName, Vector4[] values)
	{
		fixed (Vector4* ptr = values)
		{
			SetArray(variableName, (IntPtr)ptr, UniformDataType.Vec4, values.Length);
		}
	}

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetShaderValueMatrix")]
	private static extern void SetMatrix(Shader shader, int location, Matrix4x4 matrix);
	public void SetMatrix(string variableName, Matrix4x4 matrix)
	{
		int location = GetCachedVariableLocation(variableName);
		SetMatrix(this, location, matrix);
	}

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetShaderValueTexture")]
	private static extern void SetTexture(Shader shader, int location, Texture texture);
	public void SetTexture(string variableName, Texture texture)
	{
		int location = GetCachedVariableLocation(variableName);
		SetTexture(this, location, texture);
	}

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "UnloadShader")]
	private static extern void Unload(Shader shader);

	public void Dispose()
	{
		Unload(this);
	}
}