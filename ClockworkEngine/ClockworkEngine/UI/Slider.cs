using Clockwork.Graphics;

namespace Clockwork.UI;

public class Slider : Container
{
	public Element Rail { get; private set; }
	public Button Handle { get; private set; }
	public delegate void OnValueChanged(float value);
	public event OnValueChanged ValueChanged;
	private float value;
	public float Value
	{
		get => value;
		set
		{
			this.value = value;
		}
	}

	public Slider() : base()
	{
		Initialize();
	}

	private void Initialize()
	{
		Height = 100;

		Style railStyle = new(Colors.White, Colors.Black, 5);
		Rail = new();
		Rail.Width = Width;
		Rail.Height = 10;
		AddChild(Rail);

		Handle = new();
		Handle.Width = 75;
		Handle.Height = 75;
		Handle.Released += OnHandleReleased;
		AddChild(Handle);

		ForceUpdate();
	}

	private void OnHandleReleased()
	{

	}

	protected override void OnXUpdated()
	{
		
	}

	protected override void OnYUpdated()
	{
		
	}

	protected override void OnWidthUpdated()
	{
		
	}

	protected override void OnHeightUpdated()
	{
		
	}
}