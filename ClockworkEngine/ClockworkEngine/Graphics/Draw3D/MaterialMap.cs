using System.Runtime.InteropServices;

namespace Clockwork.Graphics.Draw3D;

[StructLayout(LayoutKind.Sequential)]
public struct MaterialMap
{
	public Texture Texture;
	public Color Color;
	public float Value;
}