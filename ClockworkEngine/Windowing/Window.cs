using System.Numerics;
using Clockwork.Input;
using Clockwork.Graphics;
using System.Runtime.InteropServices;

namespace Clockwork.Windowing;

public unsafe static class Window
{
	private static IWindow backend => Engine.Rendering.Window;
	
	internal static WindowRenderer Renderer { get; private set; } = new UnclippedRenderer(Colors.Black);
	public static void SetRendererUnclipped(Color borderColor) => Renderer = new UnclippedRenderer(borderColor);
	public static void SetRendererClipped() => Renderer = new ClippedRenderer();

	public static void Initialize(int width, int height, string title) => backend.Initialize(width, height, title);
	public static void Close() => backend.Close();
	public static void Resize(int width, int height) => backend.Resize(width, height);
	public static void Focus() => backend.Focus();

	public static int Width => backend.Width;
	public static int Height => backend.Height;
	public static string Title { set => backend.Title = value; }
	public static Vector2 Position { get => backend.Position; set => backend.Position = value; }
	// TODO: public static Image Icon { set => backend.Icon = value; }
	public static int Monitor { set => backend.Monitor = value; }

	public static void SetVsync(bool isEnabled) => backend.SetVsync(isEnabled);
	public static void SetFullscreen(bool isFullscreen) => backend.SetFullscreen(isFullscreen);
	public static void SetResizable(bool isResizable) => backend.SetResizable(isResizable);
	public static void SetUndecorated(bool isUndecorated) => backend.SetUndecorated(isUndecorated);
	public static void SetMinimized(bool isMinimized) => backend.SetMinimized(isMinimized);
	public static void SetMaximized(bool isMaximized) => backend.SetMaximized(isMaximized);
	public static void SetBorderless(bool isBorderless) => backend.SetBorderless(isBorderless);
	public static void SetMSAA4x(bool isEnabled) => backend.SetMSAA4x(isEnabled);
}
