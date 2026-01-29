namespace Clockwork.Graphics.Draw3D;

public class Material : IDisposable
{
	public MaterialData Data { get; private set; }

	public Material()
	{
		Data = MaterialData.LoadDefault();
	}

	public void Dispose()
	{
		Data.Dispose();
	}
}
