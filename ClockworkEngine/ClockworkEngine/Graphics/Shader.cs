using System.Numerics;

namespace Clockwork.Graphics;

public class Shader : IDisposable
{
	public ShaderData Data { get; private set; }
	private Dictionary<string, int> variableLocations = new();

	public Shader() { }

	public Shader(string vertexFileName, string fragmentFileName)
	{
		LoadFromFile(vertexFileName, fragmentFileName);
	}

	public static void BeginUsing(Shader shader) => ShaderData.BeginUsing(shader.Data);
	public static void EndUsing() => ShaderData.EndUsing();

	public void LoadFromFile(string vertexFileName, string fragmentFileName)
	{
		Data = ShaderData.LoadFromFile(vertexFileName, fragmentFileName);
		if (!Data.IsValid) throw new Exception();
	}
	public void LoadFromCode(string vertexCode, string fragmentCode)
	{
		Data = ShaderData.LoadFromCode(vertexCode, fragmentCode);
		if (!Data.IsValid) throw new Exception();
	}

	internal int GetVariableLocation(string variableName)
	{
		bool containsLocation = variableLocations.TryGetValue(variableName, out int variableLocation);
		if (containsLocation) return variableLocation;
		variableLocation = Data.GetVariableLocation(variableName);
		variableLocations[variableName] = variableLocation;
		return variableLocation;
	}

	public void SetValue(string variableName, IntPtr value, UniformDataType dataType)
	{
		int location = GetVariableLocation(variableName);
		Data.SetValue(location, value, dataType);
	}
	public void SetFloat(string variableName, float value) => Data.SetFloat(GetVariableLocation(variableName), value);
	public void SetInteger(string variableName, int value) => Data.SetInteger(GetVariableLocation(variableName), value);
	public void SetVector2(string variableName, Vector2 value) => Data.SetVector2(GetVariableLocation(variableName), value);
	public void SetVector3(string variableName, Vector3 value) => Data.SetVector3(GetVariableLocation(variableName), value);
	public void SetVector4(string variableName, Vector4 value) => Data.SetVector4(GetVariableLocation(variableName), value);

	public void SetArray(string variableName, IntPtr value, UniformDataType dataType, int count)
	{
		int location = GetVariableLocation(variableName);
		Data.SetArray(location, value, dataType, count);
	}
	public void SetFloats(string variableName, float[] values) => Data.SetFloats(GetVariableLocation(variableName), values);
	public void SetIntegers(string variableName, int[] values) => Data.SetIntegers(GetVariableLocation(variableName), values);
	public void SetVector2s(string variableName, Vector2[] values) => Data.SetVector2s(GetVariableLocation(variableName), values);
	public void SetVector3s(string variableName, Vector3[] values) => Data.SetVector3s(GetVariableLocation(variableName), values);
	public void SetVector4s(string variableName, Vector4[] values) => Data.SetVector4s(GetVariableLocation(variableName), values);

	public void SetMatrix(string variableName, Matrix4x4 matrix)
	{
		int location = GetVariableLocation(variableName);
		Data.SetMatrix(location, matrix);
	}

	public void SetTexture(string variableName, Texture texture)
	{
		int location = GetVariableLocation(variableName);
		Data.SetTexture(location, texture);
	}

	public void Dispose() => Data.Dispose();
}
