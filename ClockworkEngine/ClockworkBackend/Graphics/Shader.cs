using System.Runtime.InteropServices;
using System.Numerics;
using Clockwork.Interface;

namespace Clockwork.Graphics;

public static class Shader
{
	private static IShaders backend => BackendInterface.Rendering.Shaders;

	public static void BeginUsing(IShader shader) => backend.BeginUsing(shader);
	public static void EndUsing() => backend.EndUsing();
	public static IShader LoadFromFile(string vertexFileName, string fragmentFileName) => backend.LoadFromFile(vertexFileName, fragmentFileName);
	public static IShader LoadFromCode(string vertexCode, string fragmentCode) => backend.LoadFromCode(vertexCode, fragmentCode);
}