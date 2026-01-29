using Clockwork.Utilities;
using System.Numerics;

namespace Clockwork.Graphics.Draw3D;

public class Mesh : IDisposable
{
	public MeshData Data { get; private set; }

	public Mesh() { }

	public Mesh(MeshData data)
	{
		Data = data;
	}

	public void Draw(Material material, Matrix4x4 matrix) => Data.Draw(material.Data, matrix);
	public void Draw(Material material, Transform3D transform) => Data.Draw(material.Data, transform.Matrix);

	public static Mesh GenerateBox(float width, float height, float length)
	{
		MeshData boxMesh = MeshData.GenerateBox(width, height, length);
		return new(boxMesh);
	}

	public static Mesh GenerateSphere(float radius, int rings, int slices)
	{
		MeshData sphereMesh = MeshData.GenerateSphere(radius, rings, slices);
		return new(sphereMesh);
	}

	public void Dispose()
	{
		Data.Dispose();
	}
}
