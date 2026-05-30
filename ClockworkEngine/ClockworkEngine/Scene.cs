using Clockwork.Graphics;
using Clockwork.Graphics.Cameras;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

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

	public Scene(IEnumerable<Entity> entities)
	{
		foreach (Entity entity in entities) AddEntity(entity);
	}

	public Scene(IEnumerable<Entity> entities, Color backgroundColor)
	{
		BackgroundColor = backgroundColor;
		foreach (Entity entity in entities) AddEntity(entity);
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
		IList<List<Entity>> updateLayers = Entities.UpdateLayers.Values;
		for (int layerIndex = 0; layerIndex < updateLayers.Count; layerIndex++)
		{
			Span<Entity> layerEntities = CollectionsMarshal.AsSpan(updateLayers[layerIndex]);
			for (int entityIndex = 0; entityIndex < layerEntities.Length; entityIndex++)
			{
				Entity entity = layerEntities[entityIndex];
				if (entity.IsUpdating) entity.OnUpdate();
			}
		}
	}

	public void Draw()
	{
		Drawing.Clear(BackgroundColor);
		if (Camera is not null) Camera.Begin();

		IList<List<Entity>> drawLayers = Entities.DrawLayers.Values;
		for (int layerIndex = 0; layerIndex < drawLayers.Count; layerIndex++)
		{
			Span<Entity> layerEntities = CollectionsMarshal.AsSpan(drawLayers[layerIndex]);
			for (int entityIndex = 0; entityIndex < layerEntities.Length; entityIndex++)
			{
				Entity entity = layerEntities[entityIndex];
				if (entity.IsRendering) entity.OnDraw();
			}
		}

		if (Camera is not null) Camera.End();
	}

	public void DrawGUI()
	{
		IList<List<Entity>> drawLayers = Entities.DrawLayers.Values;
		for (int layerIndex = 0; layerIndex < drawLayers.Count; layerIndex++)
		{
			Span<Entity> layerEntities = CollectionsMarshal.AsSpan(drawLayers[layerIndex]);
			for (int entityIndex = 0; entityIndex < layerEntities.Length; entityIndex++)
			{
				Entity entity = layerEntities[entityIndex];
				if (entity.IsRendering) entity.OnDrawGUI();
			}
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