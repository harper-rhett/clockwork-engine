namespace Clockwork.Graphics;

public interface IShaders
{
	public void BeginUsing(IShader shader);
	public void EndUsing();
	public IShader LoadFromFile(string vertexFileName, string fragmentFileName);
	public IShader LoadFromCode(string vertexCode, string fragmentCode);
}
