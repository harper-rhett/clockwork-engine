using Clockwork.Graphics;
using Clockwork.Windowing;

namespace Clockwork.Interface;

public abstract class IRenderingBackend
{
	public abstract IPrimitives Primitives { get; }
	public abstract IWindow Window { get; }
	public abstract IImages Images { get; }
	public abstract ITextures Textures { get; }
	public abstract IFonts Fonts { get; }
	public abstract IText Text { get; }
	public abstract IRenderTextures RenderTextures { get; }
	public abstract IShaders Shaders { get; }
	public abstract IDrawing Drawing { get; }
	public abstract ICameras Cameras { get; }

	public Action MasterLoop;
	public abstract void Start();
}
