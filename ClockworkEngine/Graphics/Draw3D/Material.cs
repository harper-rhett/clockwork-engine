namespace ClockworkEngine.Graphics.Draw3D;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct Material
{
	public Shader Shader;
	public MaterialMap* Maps;
	public fixed float Param[4];
}