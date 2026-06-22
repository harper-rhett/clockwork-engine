using Clockwork.Windowing;
using System;
using System.Numerics;

namespace Clockwork.UI;

public class UploadBox : Button
{
	public UploadBoxType Type;
	public string DefaultPath = string.Empty;
	public string[] ExtensionFilters = Array.Empty<string>();
	public event Action<string> ItemPathSelected;
	public event Action<string[]> ItemPathsSelected;

	public UploadBox() : base()
	{
		
	}

	public UploadBox(int x, int y, int width, int height) : base(x, y, width, height)
	{
		
	}

	public UploadBox(int x, int y, int width, int height, Style defaultStyle, Style hoverStyle, Style pressedStyle) : base(x, y, width, height, defaultStyle, hoverStyle, pressedStyle)
	{
		
	}

	public UploadBox(Vector2 position, Vector2 size) : base(position, size)
	{

	}

	public UploadBox(Vector2 position, Vector2 size, Style style, Style hoverStyle, Style pressedStyle) : base(position, size, style, hoverStyle, pressedStyle)
	{

	}

	public override void OnUpdate()
	{
		base.OnUpdate();
		if (!Enabled) return;
		if (Window.ItemPathsDropped)
		{
			Window.Focus();
			string[] itemPaths = Window.ConsumeDroppedItemPaths();
			if (IsHovered && ItemPathsSelected is not null) Select(itemPaths);
		}
	}

	protected virtual void OnItemPathSelected(string itemPath) { }
	protected virtual void OnItemPathsSelected(string[] itemPaths) { }

	public override void OnReleased(Element element)
	{
		base.OnReleased(element);
		switch (Type)
		{
			case UploadBoxType.SingleFile:
				bool singleFileSuccess = WindowDialogs.TrySelectFile("Select File", out string[] singleFilePaths, defaultPath: DefaultPath, extensionfilters: ExtensionFilters);
				if (singleFileSuccess) Select(singleFilePaths);
				break;

			case UploadBoxType.MultipleFiles:
				bool multipleFilesSuccess = WindowDialogs.TrySelectFile("Select Files", out string[] multipleFilePaths, defaultPath: DefaultPath, extensionfilters: ExtensionFilters);
				if (multipleFilesSuccess) Select(multipleFilePaths);
				break;

			case UploadBoxType.Folder:
				bool folderSuccess = WindowDialogs.TrySelectFolder("Select Folder", out string folderPath, defaultPath: DefaultPath);
				if (folderSuccess) Select([folderPath]);
				break;
		}
	}

	private void Select(string[] itemPaths)
	{
		bool singleItem = itemPaths.Length == 1 && (Type == UploadBoxType.SingleFile || Type == UploadBoxType.Folder);
		bool multipleItems = Type == UploadBoxType.MultipleFiles;
		if (singleItem)
		{
			string itemPath = itemPaths[0];
			ItemPathSelected?.Invoke(itemPath);
			OnItemPathSelected(itemPath);
		}
		else if (multipleItems)
		{
			ItemPathsSelected?.Invoke(itemPaths);
			OnItemPathsSelected(itemPaths);
		}
	}
}