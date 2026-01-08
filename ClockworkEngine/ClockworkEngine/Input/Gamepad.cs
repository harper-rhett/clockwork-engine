using System.Runtime.InteropServices;

namespace Clockwork.Input;

public class Gamepad
{
	private int index;

	internal Gamepad(int index)
	{
		this.index = index;
	}

	public static Gamepad GetGamepad(int index)
	{
		if (IsAvailable(index)) return new(index);
		else return null;
	}

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IsGamepadAvailable")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool IsAvailable(int gamepadIndex);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetGamepadName")]
	private static extern string GetName(int gamepadIndex);
	public string Name => GetName(index);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IsGamepadButtonPressed")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool IsButtonPressed(int gamepadIndex, GamepadButton button);
	public bool IsButtonPressed(GamepadButton button) => IsButtonPressed(index, button);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IsGamepadButtonDown")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool IsButtonDown(int gamepadIndex, GamepadButton button);
	public bool IsButtonDown(GamepadButton button) => IsButtonDown(index, button);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IsGamepadButtonReleased")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool IsButtonReleased(int gamepadIndex, GamepadButton button);
	public bool IsButtonReleased(GamepadButton button) => IsButtonReleased(index, button);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetGamepadButtonPressed")]
	private static extern GamepadButton GetButtonPressed();
	public GamepadButton LastButtonPressed => GetButtonPressed();

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetGamepadAxisMovement")]
	private static extern float GetAxisMovement(int gamepadIndex, GamepadAxis axis);
	public float GetAxis(GamepadAxis axis) => GetAxisMovement(index, axis);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetGamepadVibration")]
	private static extern void SetVibration(int gamepadIndex, float leftMotor, float rightMotor, float duration);
	public void Vibrate(float leftMotor, float rightMotor, float duration) => SetVibration(index, leftMotor, rightMotor, duration);
}
