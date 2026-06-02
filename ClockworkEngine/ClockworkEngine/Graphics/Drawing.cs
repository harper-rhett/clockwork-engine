using System.Runtime.InteropServices;

namespace Clockwork.Graphics;

public static class Drawing
{
	[DllImport(Engine.raylibLibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "ClearBackground")]
	public static extern void Clear(Color color);

	[DllImport(Engine.raylibLibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "BeginDrawing")]
	public static extern void Begin();

	[DllImport(Engine.raylibLibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "EndDrawing")]
	public static extern void End();

	[DllImport(Engine.raylibLibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "BeginBlendMode")]
	public static extern void BeginBlending(BlendMode blendMode);

	[DllImport(Engine.raylibLibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "EndBlending")]
	public static extern void EndBlending();
}
