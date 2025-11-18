namespace HarpEngine.Graphics;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct Texture : IDisposable
{
	public uint Id;
	public int Width;
	public int Height;
	public int Mipmaps;
	public PixelFormat Format;

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LoadTexture")]
	public extern static Texture Load(string filePath);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LoadTextureFromImage")]
	public static extern Texture Load(Image image);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IsTextureValid")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool IsThisValid(Texture texture);
	public bool IsValid => IsThisValid(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "UnloadTexture")]
	private static extern void Unload(Texture texture);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetTextureFilter")]
	private static extern void SetFilter(Texture texture, TextureFilter textureFilter);
	public void SetFilter(TextureFilter textureFilter) => SetFilter(this, textureFilter);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawTexture")]
	private static extern void Draw(Texture texture, int x, int y, Color color);
	public void Draw(int x, int y, Color color) => Draw(this, x, y, color);
	public void Draw(Vector2 position, Color color) => Draw(this, (int)float.Round(position.X), (int)float.Round(position.Y), color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawTextureRec")]
	private static extern void Draw(Texture texture, Rectangle source, Vector2 position, Color color);
	public void Draw(Rectangle source, Vector2 position, Color color) => Draw(this, source, position, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawTexturePro")]
	private static extern void Draw(Texture texture, Rectangle source, Rectangle destination, Vector2 origin, float rotation, Color color);
	public void Draw(Rectangle source, Rectangle destination, Vector2 origin, float rotation, Color color) => Draw(this, source, destination, origin, rotation, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawTextureNPatch")]
	private static extern void DrawNinePatch(Texture texture, NinePatch ninePatch, Rectangle destination, Vector2 origin, float rotation, Color color);
	public void DrawNinePatch(NinePatch ninePatch, Rectangle destination, Vector2 origin, float rotation, Color color) => DrawNinePatch(this, ninePatch, destination, origin, rotation, color);

	public void Dispose()
	{
		Unload(this);
	}
}