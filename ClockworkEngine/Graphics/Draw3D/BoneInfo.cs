namespace ClockworkEngine.Graphics.Draw3D;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct BoneInfo
{
	public fixed sbyte Name[32];
	public int Parent;
}
