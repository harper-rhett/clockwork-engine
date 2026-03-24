namespace Clockwork;

public abstract class Entity
{
	// Scene
	public Scene Scene;
	public bool IsUpdating = true;
	public bool IsRendering = true;
	public event Action Removed;

	// Update layer
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

	// Draw layer
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

	// Update loops
	public virtual void OnUpdate() { }
	public virtual void OnDraw() { }
	public virtual void OnDrawGUI() { }

	// Scene removal
	public void RemoveFromScene()
	{
		Scene.Entities.Remove(this);
		Removed?.Invoke();
	}

	// Callbacks
	public virtual void OnAddedToScene() { }
	public virtual void OnRemovedFromScene() { }
}
