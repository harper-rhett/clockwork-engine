namespace HarpEngine.Graphics;

public static class Text
{
	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawText")]
	public static extern void Draw(string text, int x, int y, int fontSize, Color color);
	public static void Draw(string text, Vector2 position, int fontSize, Color color) => Draw(text, (int)float.Round(position.X), (int)float.Round(position.Y), fontSize, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawTextEx")]
	public static extern void Draw(Font font, string text, Vector2 position, float fontSize, float spacing, Color color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawTextPro")]
	public static extern void Draw(Font font, string text, Vector2 position, Vector2 origin, float rotation, float fontSize, float spacing, Color color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetTextLineSpacing")]
	public static extern void SetLineSpacing(int spacing);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MeasureText")]
	public static extern int MeasureWidth(string text, int fontSize);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MeasureTextEx")]
	public static extern Vector2 MeasureSize(Font font, string text, float fontSize, float spacing);
}
