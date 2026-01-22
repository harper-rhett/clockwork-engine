using Clockwork.Graphics;
using System.Numerics;

namespace Clockwork.Windowing;

public interface IWindow
{
	public void Initialize(int width, int height, string title);
	public void Close();
	public void Resize(int width, int height);
	public void Focus();
	public void SetIcon(IImage image);

	public int Width { get; }
	public int Height { get; }
	public string Title { set; }
	public Vector2 Position { get; set; }
	public int Monitor { set; }

	public void SetVsync(bool isEnabled);
	public void SetFullscreen(bool isFullscreen);
	public void SetResizable(bool isResizable);
	public void SetUndecorated(bool isUndecorated);
	public void SetMinimized(bool isMinimized);
	public void SetMaximized(bool isMaximized);
	public void SetBorderless(bool isBorderless);
	public void SetMSAA4x(bool isEnabled);
}
