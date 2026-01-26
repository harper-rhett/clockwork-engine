using System.Runtime.InteropServices;
using System.Numerics;

namespace Clockwork.Graphics.Draw3D;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct Model : IDisposable
{
	public Matrix4x4 Transform;
	public int MeshCount;
	public int MaterialCount;
	public Mesh* Meshes;
	public Material* Materials;
	public int* MeshMaterial;
	public int BoneCount;
	public BoneInfo* Bones;
	public RaylibTransform* BindPose;

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LoadModel")]
	public static extern Model Load(string fileName);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LoadModelFromMesh")]
	public static extern Model LoadModel(Mesh mesh);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IsModelValid")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool IsThisValid(Model model);
	public bool IsValid => IsThisValid(this);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "UnloadModel")]
	private static extern void Unload(Model model);

	public void Dispose()
	{
		Unload(this);
	}
}