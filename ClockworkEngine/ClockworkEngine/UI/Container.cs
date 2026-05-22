using System.Collections.Generic;

namespace Clockwork.UI;

public class Container : Element
{
	public readonly List<Element> Children = new();
	public int Padding;

	public override void OnUpdate()
	{
		base.OnUpdate();
	}
}
