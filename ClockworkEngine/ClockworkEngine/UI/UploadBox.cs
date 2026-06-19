using Clockwork.Windowing;
using System;

namespace Clockwork.UI;

public class UploadBox : Button
{
	public UploadBoxType Type;
	public string DefaultPath = string.Empty;
	public string[] ExtensionFilters = Array.Empty<string>();
	public event Action<string[]> ItemPathsSelected;

	public override void OnUpdate()
	{
		base.OnUpdate();
		if (Window.ItemPathsDropped)
		{
			Window.Focus();
			string[] itemPaths = Window.ConsumeDroppedItemPaths();
			if (IsHovered && ItemPathsSelected is not null)
			{
				bool singleItem = itemPaths.Length == 1 && Type == UploadBoxType.SingleFile || Type == UploadBoxType.Folder;
				bool multipleItems = Type == UploadBoxType.MultipleFiles;
				if (singleItem || multipleItems) ItemPathsSelected.Invoke(itemPaths);
			}
		}
	}

	public override void OnPressed(Element element)
	{
		base.OnPressed(element);
		if (ItemPathsSelected is null) return;
		switch (Type)
		{
			case UploadBoxType.SingleFile:
				WindowDialogs.TrySelectFile("Select File", out string[] singleFilePaths, defaultPath: DefaultPath, extensionfilters: ExtensionFilters);
				ItemPathsSelected.Invoke(singleFilePaths);
				break;

			case UploadBoxType.MultipleFiles:
				WindowDialogs.TrySelectFile("Select Files", out string[] multipleFilePaths, defaultPath: DefaultPath, extensionfilters: ExtensionFilters);
				ItemPathsSelected.Invoke(multipleFilePaths);
				break;

			case UploadBoxType.Folder:
				WindowDialogs.TrySelectFolder("Select Folder", out string folderPath, defaultPath: DefaultPath);
				ItemPathsSelected.Invoke([folderPath]);
				break;
		}
		OnReleased(this);
	}
}
