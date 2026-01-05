using System.Runtime.InteropServices;
using System.Numerics;

namespace Clockwork.Windowing;

public class Monitor
{
	public readonly int index;

	internal Monitor(int index)
	{
		this.index = index;
	}

	public static Monitor GetCurrent()
	{
		return new Monitor(CurrentIndex);
	}

	public static Monitor[] GetAll()
	{
		Monitor[] monitors = new Monitor[Count];
		for (int monitorIndex = 0; monitorIndex < Count; monitorIndex++)
		{
			monitors[monitorIndex] = new Monitor(monitorIndex);
		}
		return monitors;
	}

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetMonitorCount")]
	private static extern int GetCount();
	public static int Count => GetCount();

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetCurrentMonitor")]
	private static extern int GetCurrentIndex();
	public static int CurrentIndex => GetCurrentIndex();

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetMonitorPosition")]
	private static extern Vector2 GetPosition(int monitor);
	public Vector2 Position => GetPosition(index);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetMonitorWidth")]
	private static extern int GetWidth(int monitor);
	public int Width => GetWidth(index);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetMonitorHeight")]
	private static extern int GetHeight(int monitor);
	public int Height => GetHeight(index);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetMonitorPhysicalWidth")]
	private static extern int GetPhysicalWidth(int monitor);
	public int WidthInMillimeters => GetPhysicalWidth(index);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetPhysicalHeight")]
	private static extern int GetPhysicalHeight(int monitor);
	public int HeightInMillimeters => GetPhysicalHeight(index);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetMonitorRefreshRate")]
	private static extern int GetRefreshRate(int monitor);
	public int RefreshRate => GetRefreshRate(index);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetMonitorName")]
	private static extern string GetName(int monitor);
	public string Name => GetName(index);
}
