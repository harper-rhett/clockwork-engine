using Clockwork.Interface;
using System.Numerics;
using Clockwork.Graphics.Draw2D;
using Clockwork.Graphics.Draw3D;

namespace Clockwork.Graphics;

public static class Camera
{
	private static ICameras backend => BackendInterface.Rendering.Cameras;

	public static ICamera2D Create2D(Vector2 position, float rotation, float zoom) => backend.Create2D(position, rotation, zoom);
	public static void BeginRendering2D(ICamera2D camera2D) => backend.BeginRendering2D(camera2D);
	public static void EndRendering2D() => backend.EndRendering2D();

	public static ICamera3D Create3D(Vector3 position, Quaternion rotation, float FOV) => backend.Create3D(position, rotation, FOV);
	public static void BeginRendering3D(ICamera3D camera2D) => backend.BeginRendering3D(camera2D);
	public static void EndRendering3D() => backend.EndRendering3D();
}
