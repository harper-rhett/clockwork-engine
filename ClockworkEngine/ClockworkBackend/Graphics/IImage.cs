namespace Clockwork.Graphics;

public interface IImage : IDisposable
{
	public int Width { get; }
	public int Height { get; }
	public bool IsValid { get; }

	public void Export(string fileName, out bool success);
}
