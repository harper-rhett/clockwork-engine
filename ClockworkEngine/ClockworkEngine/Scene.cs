using Clockwork.Graphics;

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
		Time += Engine.FrameTime * TimeModifier;

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
		DrawGame();
		DrawGUI();
	}

	private void DrawGame()
	{
		Drawing.Clear(BackgroundColor);
		if (Camera is not null) Camera.Begin();
		foreach (Entity entity in Entities.InDrawOrder)
		{
			if (entity.IsRendering) entity.OnDraw();
		}
		if (Camera is not null) Camera.End();
	}

	private void DrawGUI()
	{
		foreach (Entity entity in Entities.InDrawOrder)
		{
			if (entity.IsRendering) entity.OnDrawGUI();
		}
	}

	public EntitySubclass AddEntity<EntitySubclass>(EntitySubclass entity) where EntitySubclass : Entity
	{
		entity.Scene = this;
		Entities.Add(entity);
		entity.OnAddedToScene();
		return entity;
	}
}
