using System.Numerics;

namespace Clockwork.Graphics;

public interface IShader : IDisposable
{
	public bool IsValid { get; }

	public void SetFloat(string variableName, float value);
	public void SetInteger(string variableName, int value);
	public void SetVector2(string variableName, Vector2 value);
	public void SetVector3(string variableName, Vector3 value);
	public void SetVector4(string variableName, Vector4 value);

	public void SetFloats(string variableName, float[] values);
	public void SetIntegers(string variableName, int[] values);
	public void SetVector2s(string variableName, Vector2[] values);
	public void SetVector3s(string variableName, Vector3[] values);
	public void SetVector4s(string variableName, Vector4[] values);

	public void SetMatrix(string variableName, Matrix4x4 matrix);
	public void SetTexture(string variableName, ITexture texture);
}
