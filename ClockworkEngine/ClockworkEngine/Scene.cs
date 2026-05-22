using Clockwork.Graphics;
using Clockwork.Graphics.Cameras;

namespace Clockwork;

public class Scene
{
	// Interface
	public Entities Entities { get; private set; } = new();
	/// <summary>Seconds since creation that this world has been unpaused.</summary>
	public float Time { get; private set; }
	/// <summary>If the update loop is paused. The draw loop is unaffected/</summary>
	public bool IsPaused;
	public CameraEntity Camera;
	public float TimeModifier = 1;
	public Color BackgroundColor;

	public float FrameTime => Engine.GlobalFrameTime * TimeModifier;

	public Scene()
	{
		BackgroundColor = Colors.Black;
	}

	public Scene(Color backgroundColor)
	{
		BackgroundColor = backgroundColor;
	}

	public void Update()
	{
		if (IsPaused) return;
		Time += FrameTime;

		Entities.ProcessAdditions();
		Entities.ProcessMoves();
		UpdateEntities();
		Entities.ProcessRemovals();
	}

	private void UpdateEntities()
	{
		foreach (Entity entity in Entities.InUpdateOrder)
		{
			if (entity.IsUpdating) entity.OnUpdate();
		}
	}

	public void Draw()
	{
		Drawing.Clear(BackgroundColor);
		if (Camera is not null) Camera.Begin();
		foreach (Entity entity in Entities.InDrawOrder)
		{
			if (entity.IsRendering) entity.OnDraw();
		}
		if (Camera is not null) Camera.End();
	}

	public void DrawGUI()
	{
		foreach (Entity entity in Entities.InDrawOrder)
		{
			if (entity.IsRendering) entity.OnDrawGUI();
		}
	}

	public EntitySubclass AddEntity<EntitySubclass>(EntitySubclass entity) where EntitySubclass : Entity
	{
		entity.RegisterScene(this);
		Entities.Add(entity);
		return entity;
	}

	public void RemoveEntity(Entity entity)
	{
		entity.UnregisterScene();
		Entities.Remove(entity);
	}
}
