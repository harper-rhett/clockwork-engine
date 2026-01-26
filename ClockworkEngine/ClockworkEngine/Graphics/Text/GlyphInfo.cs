using System.Runtime.InteropServices;

namespace Clockwork.Graphics.Text;

[StructLayout(LayoutKind.Sequential)]
public struct GlyphInfo
{
	public int Value;
	public int OffsetX;
	public int OffsetY;
	public int AdvanceX;
	public Image Image;
}