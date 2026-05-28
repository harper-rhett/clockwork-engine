using Clockwork.Windowing;

namespace Clockwork;

public class SimpleGame : Game
{
	public Scene Scene;

	public SimpleGame(Scene scene)
	{
		Scene = scene;
	}

	public override void OnUpdate()
	{
		Scene.Update();
	}

	public override void OnDraw()
	{
		Scene.Draw();
	}
}
