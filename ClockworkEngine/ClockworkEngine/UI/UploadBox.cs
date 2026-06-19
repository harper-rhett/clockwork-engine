using Clockwork.Windowing;
using System;

namespace Clockwork.UI;

public class UploadBox : Button
{
	public event Action<string[]> ItemPathsDropped;

	public override void OnUpdate()
	{
		base.OnUpdate();
		if (Window.ItemPathsDropped)
		{
			Window.Focus();
			string[] itemPaths = Window.ConsumeDroppedItemPaths();
			if (IsHovered && ItemPathsDropped is not null)
			{
				ItemPathsDropped.Invoke(itemPaths);
			}
		}
	}

	public override void OnPressed(Element element)
	{
		base.OnPressed(element);
		// Item selection window would open here
		// Maybe use tinyfiledialogs (a C library that works on many OS)
	}
}
