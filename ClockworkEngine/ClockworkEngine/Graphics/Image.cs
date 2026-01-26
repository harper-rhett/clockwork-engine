using System.Runtime.InteropServices;

namespace Clockwork.Graphics;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct Image
{
	public void* Data;
	public int Width;
	public int Height;
	public int Mipmaps;
	public PixelFormat Format;
	 
	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LoadImage")]
	public static extern Image Load(string fileName);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LoadImageRaw")]
	public static extern Image LoadRaw(string fileName, int width, int height, PixelFormat pixelFormat, int headerSize);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LoadImageFromTexture")]
	public static extern Image Load(Texture texture);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IsImageValid")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool IsThisValid(Image image);
	public bool IsValid => IsThisValid(this);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "UnloadImage")]
	private static extern void Unload(Image image);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ExportImage")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool Export(Image image, string fileName);
	public void Export(string fileName, out bool success)
	{
		success = Export(this, fileName);
	}

	public void Dispose()
	{
		Unload(this);
	}
}