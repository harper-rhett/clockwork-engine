using System.Runtime.InteropServices;

namespace Clockwork.Graphics.Draw3D;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct Material
{
	public ShaderData Shader;
	public MaterialMap* Maps;
	public fixed float Param[4];
}