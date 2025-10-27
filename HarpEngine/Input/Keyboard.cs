namespace HarpEngine.Input;

public static class Keyboard
{
	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IsKeyPressed")]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool IsKeyPressed(KeyboardKey key);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IsKeyRepeating")]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool IsKeyRepeating(KeyboardKey key);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IsKeyDown")]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool IsKeyDown(KeyboardKey key);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IsKeyReleased")]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool IsKeyReleased(KeyboardKey key);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetKeyPressed")]
	public static extern KeyboardKey GetKeyPressed();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetCharPressed")]
	public static extern int GetUnicodePressed();
}
