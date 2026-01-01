namespace Clockwork.Windowing;

public unsafe static class Window
{
	internal static WindowRenderer Renderer { get; private set; } = new UnclippedRenderer(Colors.Black);

	private enum WindowFlags : uint
	{
		VSync = 0x00000040,
		Fullscreen = 0x00000002,
		Resizable = 0x00000004,
		Undecorated = 0x00000008,
		Hidden = 0x00000080,
		Minimized = 0x00000200,
		Maximized = 0x00000400,
		Unfocused = 0x00000800,
		Topmost = 0x00001000,
		AlwaysRun = 0x00000100,
		Transparent = 0x00000010,
		HighDpi = 0x00002000,
		MousePassthrough = 0x00004000,
		Borderless = 0x00008000,
		MSAA4x = 0x00000020,
		Interlaced = 0x00010000,
	}

	public static void SetRendererUnclipped(Color borderColor) => Renderer = new UnclippedRenderer(borderColor);
	public static void SetRendererClipped() => Renderer = new ClippedRenderer();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "InitWindow")]
	public static extern void Initialize(int width, int height, string title);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "CloseWindow")]
	public static extern void Close();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "WindowShouldClose")]
	[return: MarshalAs(UnmanagedType.I1)]
	internal static extern bool ShouldClose();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetWindowState")]
	private static extern void SetState(WindowFlags flags);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ClearWindowState")]
	private static extern void ClearState(WindowFlags flags);

	private static void SetState(WindowFlags flags, bool isEnabled)
	{
		if (isEnabled) SetState(flags);
		else ClearState(flags);
	}

	public static void SetVsync(bool isEnabled) => SetState(WindowFlags.VSync, isEnabled);
	public static void SetFullscreen(bool isFullscreen) => SetState(WindowFlags.Fullscreen, isFullscreen);
	public static void SetResizable(bool isResizable) => SetState(WindowFlags.Resizable, isResizable);
	public static void SetUndecorated(bool isUndecorated) => SetState(WindowFlags.Undecorated, isUndecorated);
	public static void SetMinimized(bool isMinimized) => SetState(WindowFlags.Minimized, isMinimized);
	public static void SetMaximized(bool isMaximized) => SetState(WindowFlags.Maximized, isMaximized);
	public static void SetBorderless(bool isBorderless) => SetState(WindowFlags.Borderless, isBorderless);
	public static void SetMSAA4x(bool isEnabled) => SetState(WindowFlags.MSAA4x, isEnabled);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetScreenWidth")]
	private static extern int GetWidth();
	public static int Width => GetWidth();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetScreenHeight")]
	private static extern int GetHeight();
	public static int Height => GetHeight();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetWindowSize")]
	public static extern void Resize(int width, int height);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetWindowIcon")]
	public static extern void SetIcon(Image image);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetWindowIcons")]
	public static extern void SetIcons(Image* images, int count);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetWindowTitle")]
	public static extern void SetTitle(string title);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetWindowPosition")]
	public static extern void SetPosition(int x, int y);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetWindowMonitor")]
	private static extern void SetMonitor(int monitor);
	public static int Monitor
	{
		set => SetMonitor(value);
	}

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetWindowFocused")]
	public static extern void Focus();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetWindowPosition")]
	private static extern Vector2 GetPosition();
	public static Vector2 Position => GetPosition();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetExitKey")]
	public static extern void SetExitKey(KeyboardKey key);
}
