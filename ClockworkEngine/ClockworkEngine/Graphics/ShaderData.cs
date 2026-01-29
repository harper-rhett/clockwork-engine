using System.Runtime.InteropServices;
using System.Numerics;
using Clockwork.Graphics;
using System;

namespace Clockwork.Graphics;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct ShaderData : IDisposable
{
	public uint ID;
	public int* Locations;

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "BeginShaderMode")]
	public static extern void BeginUsing(ShaderData shaderData);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "EndShaderMode")]
	public static extern void EndUsing();

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LoadShader")]
	public static extern ShaderData LoadFromFile(string vertexFileName, string fragmentFileName);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LoadShaderFromMemory")]
	public static extern ShaderData LoadFromCode(string vertexCode, string fragmentCode);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IsShaderValid")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool IsThisValid(ShaderData shaderData);
	public bool IsValid => IsThisValid(this);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetShaderLocation")]
	private static extern int GetVariableLocation(ShaderData shaderData, string variableName);
	public int GetVariableLocation(string variableName) => GetVariableLocation(this, variableName);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetShaderValue")]
	private static extern void SetValue(ShaderData shaderData, int location, IntPtr value, UniformDataType dataType);
	public void SetValue(int location, IntPtr value, UniformDataType dataType) => SetValue(this, location, value, dataType);
	public void SetFloat(int location, float value) => SetValue(location, (IntPtr)(&value), UniformDataType.Float);
	public void SetInteger(int location, int value) => SetValue(location, (IntPtr)(&value), UniformDataType.Int);
	public void SetVector2(int location, Vector2 value) => SetValue(location, (IntPtr)(&value), UniformDataType.Vec2);
	public void SetVector3(int location, Vector3 value) => SetValue(location, (IntPtr)(&value), UniformDataType.Vec3);
	public void SetVector4(int location, Vector4 value) => SetValue(location, (IntPtr)(&value), UniformDataType.Vec4);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetShaderValueV")]
	internal static extern void SetArray(ShaderData shader, int location, IntPtr value, UniformDataType dataType, int count);
	public void SetArray(int location, IntPtr value, UniformDataType dataType, int count) => SetArray(this, location, value, dataType, count);
	public void SetFloats(int location, float[] values)
	{
		fixed (float* ptr = values)
		{
			SetArray(location, (IntPtr)ptr, UniformDataType.Float, values.Length);
		}
	}
	public void SetIntegers(int location, int[] values)
	{
		fixed (int* ptr = values)
		{
			SetArray(location, (IntPtr)ptr, UniformDataType.Int, values.Length);
		}
	}
	public void SetVector2s(int location, Vector2[] values)
	{
		fixed (Vector2* ptr = values)
		{
			SetArray(location, (IntPtr)ptr, UniformDataType.Vec2, values.Length);
		}
	}
	public void SetVector3s(int location, Vector3[] values)
	{
		fixed (Vector3* ptr = values)
		{
			SetArray(location, (IntPtr)ptr, UniformDataType.Vec3, values.Length);
		}
	}
	public void SetVector4s(int location, Vector4[] values)
	{
		fixed (Vector4* ptr = values)
		{
			SetArray(location, (IntPtr)ptr, UniformDataType.Vec4, values.Length);
		}
	}

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetShaderValueMatrix")]
	private static extern void SetMatrix(ShaderData shader, int location, Matrix4x4 matrix);
	public void SetMatrix(int location, Matrix4x4 matrix) => SetMatrix(this, location, matrix);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetShaderValueTexture")]
	private static extern void SetTexture(ShaderData shader, int location, Texture texture);
	public void SetTexture(int location, Texture texture) => SetTexture(this, location, texture);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "UnloadShader")]
	private static extern void Unload(ShaderData shader);

	public void Dispose()
	{
		Unload(this);
	}
}