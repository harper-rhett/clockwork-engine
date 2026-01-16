using System.Numerics;

namespace Clockwork.Graphics.Draw3D;

public interface IPrimitives3D
{
	public void DrawLine(Vector3 startPosition, Vector3 endPosition, float thickness, Color color);

	public void DrawTriangle(Vector3 corner1, Vector3 corner2, Vector3 corner3, Color color);

	public void DrawCube(Vector3 position, float width, float height, float length, Color color);
	public void DrawCube(Vector3 position, Vector3 size, Color color);
	public void DrawCubeWires(Vector3 position, float width, float height, float length, Color color);
	public void DrawCubeWires(Vector3 position, Vector3 size, Color color);

	public void DrawSphere(Vector3 center, float radius, Color color);
	public void DrawSphere(Vector3 center, float radius, int rings, int slices, Color color);
	public void DrawSphereWires(Vector3 center, float radius, int rings, int slices, Color color);

	public void DrawCylinder(Vector3 position, float radius, float height, int slices, Color color);
	public void DrawCylinderWires(Vector3 position, float radius, float height, int slices, Color color);
	public void DrawCapsule(Vector3 position, float radius, float height, int slices, Color color);
	public void DrawCapsuleWires(Vector3 position, float radius, float height, int slices, Color color);
}
