using System.Numerics;
using Clockwork.Windowing;
using System.Runtime.InteropServices;

namespace Clockwork.Input;

public static class Mouse
{
	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IsMouseButtonPressed")]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool IsButtonPressed(MouseButton mouseButton);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IsMouseButtonDown")]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool IsButtonDown(MouseButton mouseButton);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IsMouseButtonReleased")]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool IsButtonReleased(MouseButton mouseButton);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetMouseX")]
	private static extern int GetWindowX();
	public static int WindowX => GetWindowX();

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetMouseY")]
	private static extern int GetWindowY();
	public static int WindowY => GetWindowY();

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetMousePosition")]
	private static extern Vector2 GetWindowPosition();
	public static Vector2 WindowPosition => GetWindowPosition();

	public static int GameX => Window.Renderer.MouseGameX;
	public static int GameY => Window.Renderer.MouseGameY;
	public static Vector2 GamePosition => new(GameX, GameY);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetMouseDelta")]
	private static extern Vector2 GetDelta();
	public static Vector2 Delta => GetDelta();

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetMouseWheelMove")]
	private static extern float GetWheelDelta();
	public static float WheelDelta => GetWheelDelta();

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetMouseCursor")]
	public static extern void SetCursor(MouseCursor mouseCursor);
}
