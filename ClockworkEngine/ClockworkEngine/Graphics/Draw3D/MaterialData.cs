using System.Runtime.InteropServices;

namespace Clockwork.Graphics.Draw3D;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct MaterialData : IDisposable
{
	public ShaderData Shader;
	public MaterialMap* Maps;
	public fixed float Param[4];

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LoadMaterialDefault")]
	public static extern MaterialData LoadDefault();

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "UnloadMaterial")]
	private static extern void Unload(MaterialData materialData);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IsMaterialValid")]
	private static extern bool IsThisValid(MaterialData materialData);
	public bool IsValid => IsThisValid(this);

	public void Dispose()
	{
		Unload(this);
	}
}