namespace ClockworkEngine.Graphics.Draw3D;

[StructLayout(LayoutKind.Sequential)]
public struct RaylibTransform
{
	public Vector3 Translation;
	public Quaternion Rotation;
	public Vector3 Scale;

	public void TranslateLocal(Vector3 translation)
	{
		Translation += Vector3.Transform(translation, Rotation);
	}

	public void TranslateGlobal(Vector3 translation)
	{
		Translation += translation;
	}
}