using Clockwork.Interface;
using System.Numerics;

namespace Clockwork.Graphics.Draw3D;

public static class Primitives3D
{
	private static IPrimitives3D backend => BackendInterface.Rendering.Primitives3D;

	public static void DrawLine(Vector3 startPosition, Vector3 endPosition, float thickness, Color color) => backend.DrawLine(startPosition, endPosition, thickness, color);

	public static void DrawTriangle(Vector3 corner1, Vector3 corner2, Vector3 corner3, Color color) => backend.DrawTriangle(corner1, corner2, corner3, color);

	public static void DrawCube(Vector3 position, float width, float height, float length, Color color) => backend.DrawCube(position, width, height, length, color);
	public static void DrawCube(Vector3 position, Vector3 size, Color color) => backend.DrawCube(position, size, color);
	public static void DrawCubeWires(Vector3 position, float width, float height, float length, Color color) => backend.DrawCubeWires(position, width, height, length, color);
	public static void DrawCubeWires(Vector3 position, Vector3 size, Color color) => backend.DrawCubeWires(position, size, color);

	public static void DrawSphere(Vector3 center, float radius, Color color) => backend.DrawSphere(center, radius, color);
	public static void DrawSphere(Vector3 center, float radius, int rings, int slices, Color color) => backend.DrawSphere(center, radius, rings, slices, color);
	public static void DrawSphereWires(Vector3 center, float radius, int rings, int slices, Color color) => backend.DrawSphereWires(center, radius, rings, slices, color);

	public static void DrawCylinder(Vector3 position, float radius, float height, int slices, Color color) => backend.DrawCylinder(position, radius, height, slices, color);
	public static void DrawCylinderWires(Vector3 position, float radius, float height, int slices, Color color) => backend.DrawCylinderWires(position, radius, height, slices, color);
	public static void DrawCapsule(Vector3 position, float radius, float height, int slices, Color color) => backend.DrawCapsule(position, radius, height, slices, color);
	public static void DrawCapsuleWires(Vector3 position, float radius, float height, int slices, Color color) => backend.DrawCapsuleWires(position, radius, height, slices, color);
}
