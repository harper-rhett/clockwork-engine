using System.Collections.Generic;

namespace Clockwork;

public class SimpleScene : Scene
{
	public SimpleScene(IEnumerable<Entity> entities)
	{
		foreach (Entity entity in entities) AddEntity(entity);
	}
}
