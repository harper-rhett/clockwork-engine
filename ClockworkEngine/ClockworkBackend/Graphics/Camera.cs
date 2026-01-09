using Clockwork.Interface;
using System.Numerics;

namespace Clockwork.Graphics;

public static class Camera
{
	private static ICameras backend => BackendInterface.Rendering.Cameras;

	public static ICamera2D Create(Vector2 position, Vector2 offset, float rotation, float zoom) => backend.Create(position, offset, rotation, zoom);
	public static void BeginRendering2D(ICamera2D camera2D) => backend.BeginRendering2D(camera2D);
	public static void EndRendering2D() => backend.EndRendering2D();
}
