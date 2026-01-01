namespace Clockwork.Windowing;

internal class Cursor
{
	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ShowCursor")]
	public static extern void Show();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "HideCursor")]
	public static extern void Hide();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "EnableCursor")]
	public static extern void Enable();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DisableCursor")]
	public static extern void Disable();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IsCursorOnScreen")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool IsThisOnScreen();
	public static bool IsOnScreen => IsThisOnScreen();
}
