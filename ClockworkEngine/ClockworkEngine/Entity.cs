namespace Clockwork;

public abstract class Entity
{
	public Scene Scene;
	public bool IsUpdating = true;
	public bool IsRendering = true;
	public event Action Removed;

	internal int lastUpdateLayer;
	private int updateLayer;
	public int UpdateLayer
	{
		get => updateLayer;
		set
		{
			lastUpdateLayer = updateLayer;
			updateLayer = value;
			if (Scene is not null) Scene.Entities.MoveUpdateLayer(this);
		}
	}
	internal int lastDrawLayer;
	private int drawLayer;
	public int DrawLayer
	{
		get => drawLayer;
		set
		{
			lastDrawLayer = drawLayer;
			drawLayer = value;
			if (Scene is not null) Scene.Entities.MoveDrawLayer(this);
		}
	}

	public virtual void OnUpdate() { }
	public virtual void OnDraw() { }
	public virtual void OnDrawGUI() { }

	public void Remove()
	{
		Scene.Entities.Remove(this);
		Removed?.Invoke();
	}

	public virtual void OnAddedToScene() { }
	public virtual void OnRemovedFromScene() { }
}
