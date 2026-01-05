using System.Runtime.InteropServices;

namespace Clockwork.Graphics;

public enum BlendMode
{
	Alpha = 0,
	Additive,
	Multiplied,
	AddColors,
	SubtractColors,
	AlphaPremultiply,
	Custom,
	CustomSeparate
}

public static class Drawing
{
	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ClearBackground")]
	public static extern void Clear(Color color);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "BeginDrawing")]
	public static extern void Begin();

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "EndDrawing")]
	public static extern void End();

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "BeginBlendMode")]
	public static extern void BeginBlending(BlendMode blendMode);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "EndBlending")]
	public static extern void EndBlending();
}
