namespace HarpEngine.Graphics;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct Font : IDisposable
{
	public int BaseSize;
	public int GlyphCount;
	public int GlyphPadding;
	public Texture Texture;
	public Rectangle* Recs;
	public GlyphInfo* Glyphs;

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetFontDefault")]
	private static extern Font GetFont();
	public static Font Default => GetFont();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LoadFont")]
	public static extern Font Load(string fileName);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LoadFontFromImage")]
	public static extern Font Load(Image image, Color key, int firstCharacter);

	//[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LoadFontEx")]
	//public static extern Font Load(string fileName, int fontSize, int* codepoints, int codepointCount);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IsFontValid")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool IsThisValid(Font font);
	public bool IsValid => IsThisValid(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "UnloadFont")]
	public static extern void Unload(Font font);

	public void Dispose()
	{
		Unload(this);
	}
}

[StructLayout(LayoutKind.Sequential)]
public struct GlyphInfo
{
	public int Value;
	public int OffsetX;
	public int OffsetY;
	public int AdvanceX;
	public Image Image;
}