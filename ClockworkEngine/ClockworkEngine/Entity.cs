using System;

namespace Clockwork;

public abstract class Entity
{
	// Scene
	public Scene Scene;
	public bool IsUpdating = true;
	public bool IsDrawing = true;
	public event Action Removed;
	public bool IsInScene { get; private set; }
	public float FrameTime => Scene is null ? Engine.GlobalFrameTime : Scene.FrameTime;
	public float Time => Scene is null ? 0 : Scene.Time;

	// Update layer
	internal int lastUpdateLayer = 0;
	private int updateLayer = 0;
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
	internal int lastDrawLayer = 0;
	private int drawLayer = 0;
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

	// Scene addition
	public void AddToScene(Scene scene)
	{
		scene.AddEntity(this);
	}
	internal void RegisterScene(Scene scene)
	{
		Scene = scene;
		IsInScene = true;
	}

	// Scene removal
	public void RemoveFromScene()
	{
		Scene.RemoveEntity(this);
	}
	internal void UnregisterScene()
	{
		Scene = null;
		IsInScene = false;
		Removed?.Invoke();
	}

	// Callbacks
	public virtual void OnAddedToScene() { }
	public virtual void OnRemovedFromScene() { }

	// Overrides
	public virtual bool IsVisible() => true;
}
