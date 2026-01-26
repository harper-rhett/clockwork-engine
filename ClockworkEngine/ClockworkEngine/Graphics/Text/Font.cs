using System.Runtime.InteropServices;

namespace Clockwork.Graphics.Text;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct Font
{
	public int BaseSize;
	public int GlyphCount;
	public int GlyphPadding;
	public Texture Texture;
	public Rectangle* Recs;
	public GlyphInfo* Glyphs;

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetFontDefault")]
	private static extern Font GetFont();
	public static Font Default => GetFont();

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LoadFont")]
	public static extern Font Load(string fileName);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LoadFontFromImage")]
	public static extern Font Load(Image image, Color key, int firstCharacter);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IsFontValid")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool IsThisValid(Font font);
	public bool IsValid => IsThisValid(this);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "UnloadFont")]
	public static extern void Unload(Font font);

	public void Dispose()
	{
		Unload(this);
	}
}