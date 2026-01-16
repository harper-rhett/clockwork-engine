namespace Clockwork;

public abstract class Game
{
	public Game(string windowTitle, int gameWidth, int gameHeight)
	{
		Engine.Initialize(windowTitle, gameWidth, gameHeight);
	}

	public abstract void OnUpdate();
	public abstract void OnDraw();
}
