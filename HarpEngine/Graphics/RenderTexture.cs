namespace HarpEngine.Graphics;

[StructLayout(LayoutKind.Sequential)]
public struct RenderTexture : IDisposable
{
	public uint Id;
	public Texture Texture;
	public Texture Depth;

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "BeginTextureMode")]
	public static extern void BeginDrawing(RenderTexture renderTexture2D);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "EndTextureMode")]
	public static extern void EndDrawing();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LoadRenderTexture")]
	public static extern RenderTexture Load(int width, int height);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IsRenderTextureValid")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool IsThisValid(RenderTexture renderTexture);
	public bool IsValid => IsThisValid(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "UnloadRenderTexture")]
	private static extern void Unload(RenderTexture renderTexture);

	public void Dispose()
	{
		Unload(this);
	}
}
