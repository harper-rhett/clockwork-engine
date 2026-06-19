using System;

namespace Clockwork.UI;

public class ItemUpload : Button
{
	public event Action<string[]> ItemPathsDropped;

	public override void OnPressed(Element element)
	{
		base.OnPressed(element);
		// Item selection window would open here
		// Maybe use tinyfiledialogs (a C library that works on many OS)
	}

	public override void OnReleased(Element element)
	{
		base.OnReleased(element);
		if (IsHovered && ItemPathsDropped is not null && Engine.ItemPathDropped)
		{
			ItemPathsDropped.Invoke(Engine.GetDroppedItemPaths());
		}
	}
}
