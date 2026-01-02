namespace ClockworkEngine.Graphics.Draw3D;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct Model
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
}