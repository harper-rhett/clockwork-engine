namespace Clockwork.Graphics;

public interface IFonts
{
	public IFont Default { get; }
	public IFont Load(string fileName);
}
