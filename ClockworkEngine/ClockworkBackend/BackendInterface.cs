namespace Clockwork.Backend;

public static class BackendInterface
{
	public static IRenderingBackend Rendering;

	public static void Initialize(IRenderingBackend renderingBackend)
	{
		Rendering = renderingBackend;
	}
}
