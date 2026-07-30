namespace Clockwork.Graphics.Draw3D;

public static class MaterialMapIndex
{
	public static int Albedo = 0;
	public static int Metalness = 1;
	public static int Normal = 2;
	public static int Roughness = 3;
	public static int Occlusion = 4;
	public static int Emission = 5;
	public static int Height = 6;
	public static int Cubemap = 7;
	public static int Irradiance = 8;
	public static int Prefilter = 9;
	public static int BRDF = 10;
	public static int Diffuse => Albedo;
	public static int Specular => Metalness;
}
