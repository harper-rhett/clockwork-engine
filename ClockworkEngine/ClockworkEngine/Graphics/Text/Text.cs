using Clockwork.Graphics.Text;
using System.Numerics;
using Clockwork.Graphics;
using System.Runtime.InteropServices;
using Clockwork.Graphics.Draw2D;

namespace Clockwork.Graphics.Text;

public static class Text
{
	public static void Draw(string text, int x, int y, int fontSize, Color color) => Draw(text, new Vector2(x, y), fontSize, color);
	public static void Draw(string text, Vector2 position, int fontSize, Color color) => Draw(Font.Default, text, position, fontSize, fontSize / 10f, color);
	public static void Draw(string text, Vector2 position, float fontSize, float characterSpacing, Color color) => Draw(text, position, fontSize, characterSpacing, color);

	[DllImport(Engine.raylibLibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawTextEx")]
	public static extern void Draw(Font font, string text, Vector2 position, float fontSize, float characterSpacing, Color color);

	[DllImport(Engine.raylibLibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawTextPro")]
	public static extern void Draw(Font font, string text, Vector2 position, Vector2 origin, float rotation, float fontSize, float characterSpacing, Color color);

	public static void DrawDebug(int fontSize, Color color, params string[] logs)
	{
		Vector2 startPosition = Vector2.One * (fontSize / 2f);
		for (int log = 0; log < logs.Length; log++)
		{
			string text = logs[log];
			int width = MeasureWidth(text, fontSize);
			Vector2 position = startPosition + Vector2.UnitY * fontSize * log;
			Primitives2D.DrawRectangle(position, new(width, fontSize), Colors.Black);
			Draw(text, position, fontSize, color);
		}
	}

	[DllImport(Engine.raylibLibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetTextLineSpacing")]
	public static extern void SetLineSpacing(int spacing);

	[DllImport(Engine.raylibLibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "MeasureText")]
	public static extern int MeasureWidth(string text, int fontSize);

	[DllImport(Engine.raylibLibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "MeasureTextEx")]
	public static extern Vector2 MeasureSize(Font font, string text, float fontSize, float characterSpacing);
}
