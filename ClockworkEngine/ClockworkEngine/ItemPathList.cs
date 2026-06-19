using System.Runtime.InteropServices;

// Raylib's FilePathList
[StructLayout(LayoutKind.Sequential)]
internal unsafe struct ItemPathList
{
	public uint Count;
	public byte** Paths;

	public string this[uint index]
	{
		get
		{
			if (index >= 0 && index < Count)
			{
				return Marshal.PtrToStringUTF8((nint)Paths[index]);
			}
			else
			{
				throw new System.IndexOutOfRangeException();
			}
		}
	}

	public readonly string[] ToArray()
	{
		string[] filePaths = new string[Count];
		for (uint index = 0; index < Count; index++)
		{
			filePaths[index] = Marshal.PtrToStringUTF8((nint)Paths[index]);
		}
		return filePaths;
	}
}