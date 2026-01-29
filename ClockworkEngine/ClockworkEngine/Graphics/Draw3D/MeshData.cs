using System.Runtime.InteropServices;
using System.Numerics;
using Clockwork.Utilities;

namespace Clockwork.Graphics.Draw3D;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct MeshData : IDisposable
{
	// General
	public int VertexCount;
	public int TriangleCount;
	public float* Vertices = default;
	public float* TexCoords = default;
	public float* TexCoords2 = default;
	public float* Normals = default;
	public float* Tangents = default;
	public byte* Colors = default;
	public ushort* Indices = default;

	// Amimation
	public float* AnimVertices = default;
	public float* AnimNormals = default;
	public byte* BoneIds = default;
	public float* BoneWeights = default;
	public Matrix4x4* BoneMatrices = default;
	public int BoneCount;

	// OpenGL
	public uint VaoId = default;
	public uint* VboId = default;
	public const int VboIdIndexVertices = 0;
	public const int VboIdIndexTexCoords = 1;
	public const int VboIdIndexNormals = 2;
	public const int VboIdIndexColors = 3;
	public const int VboIdIndexTangents = 4;
	public const int VboIdIndexTexCoords2 = 5;
	public const int VboIdIndexIndices = 6;

	public MeshData(int vertexCount, int triangleCount)
	{
		VertexCount = vertexCount;
		TriangleCount = triangleCount;
	}

	public unsafe void AllocVertices()
	{
		nuint size = (nuint)(3 * VertexCount * sizeof(float));
		Vertices = (float*)NativeMemory.Alloc(size);
	}

	public unsafe void AllocTexCoords()
	{
		nuint size = (nuint)(2 * VertexCount * sizeof(float));
		TexCoords = (float*)NativeMemory.Alloc(size);
	}

	public unsafe void AllocTexCoords2()
	{
		nuint size = (nuint)(2 * VertexCount * sizeof(float));
		TexCoords2 = (float*)NativeMemory.Alloc(size);
	}

	public unsafe void AllocNormals()
	{
		nuint size = (nuint)(3 * VertexCount * sizeof(float));
		Normals = (float*)NativeMemory.Alloc(size);
	}

	public unsafe void AllocTangents()
	{
		nuint size = (nuint)(4 * VertexCount * sizeof(float));
		Tangents = (float*)NativeMemory.Alloc(size);
	}

	public unsafe void AllocColors()
	{
		nuint size = (nuint)(4 * VertexCount * sizeof(byte));
		Colors = (byte*)NativeMemory.Alloc(size);
	}

	public unsafe void AllocIndices()
	{
		nuint size = (nuint)(3 * TriangleCount * sizeof(ushort));
		Indices = (ushort*)NativeMemory.Alloc(size);
	}

	public readonly Span<T> VerticesAs<T>() where T : unmanaged
	{
		return new(Vertices, 3 * VertexCount * sizeof(float) / sizeof(T));
	}

	public readonly Span<T> TexCoordsAs<T>() where T : unmanaged
	{
		return new Span<T>(TexCoords, 2 * VertexCount * sizeof(float) / sizeof(T));
	}

	public readonly Span<T> TexCoords2As<T>() where T : unmanaged
	{
		return new Span<T>(TexCoords2, 2 * VertexCount * sizeof(float) / sizeof(T));
	}

	public readonly Span<T> NormalsAs<T>() where T : unmanaged
	{
		return new Span<T>(Normals, 3 * VertexCount * sizeof(float) / sizeof(T));
	}

	public readonly Span<T> TangentsAs<T>() where T : unmanaged
	{
		return new Span<T>(Tangents, 4 * VertexCount * sizeof(float) / sizeof(T));
	}

	public readonly Span<T> ColorsAs<T>() where T : unmanaged
	{
		return new Span<T>(Colors, 4 * VertexCount * sizeof(byte) / sizeof(T));
	}

	public readonly Span<T> IndicesAs<T>() where T : unmanaged
	{
		return new Span<T>(Indices, 3 * TriangleCount * sizeof(ushort) / sizeof(T));
	}

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DrawMesh")]
	private static extern void Draw(MeshData mesh, MaterialData materialData, Matrix4x4 matrix);
	public void Draw(MaterialData materialData, Matrix4x4 matrix) => Draw(this, materialData, matrix);
	public void Draw(MaterialData materialData, Transform3D transform) => Draw(this, materialData, transform.Matrix);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GenMeshCube")]
	public static extern MeshData GenerateBox(float width, float height, float length);

	[DllImport("raylib", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GenMeshSphere")]
	public static extern MeshData GenerateSphere(float radius, int rings, int slices);

	public unsafe void Dispose()
	{
		NativeMemory.Free(Vertices);
		NativeMemory.Free(TexCoords);
		NativeMemory.Free(TexCoords2);
		NativeMemory.Free(Normals);
		NativeMemory.Free(Tangents);
		NativeMemory.Free(Colors);
		NativeMemory.Free(Indices);
	}
}