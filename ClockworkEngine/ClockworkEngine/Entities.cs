using System.Collections.Generic;

namespace Clockwork;

public class Entities
{
	// Entities
	private readonly List<Entity> entitiesToAdd = new();
	private readonly List<Entity> entitiesToMoveUpdate = new();
	private readonly List<Entity> entitiesToMoveDraw = new();
	private readonly List<Entity> entitiesToRemove = new();

	// Layers
	internal readonly SortedList<int, List<Entity>> UpdateLayers = new();
	internal readonly SortedList<int, List<Entity>> DrawLayers = new();

	internal void Add(Entity entity)
	{
		entitiesToAdd.Add(entity);
	}

	internal void Remove(Entity entity)
	{
		entitiesToRemove.Add(entity);
	}

	internal void ProcessAdditions()
	{
		// Loop through entities to add
		foreach (Entity entity in entitiesToAdd)
		{
			AddToUpdateLayer(entity);
			AddToDrawLayer(entity);
		}

		// Reset
		List<Entity> entitiesToAddCopy = new(entitiesToAdd);
		entitiesToAdd.Clear();
		foreach (Entity entity in entitiesToAddCopy) entity.OnAddedToScene();
	}

	private void AddToUpdateLayer(Entity entityToAdd)
	{
		List<Entity> updateLayer = GetLayerEntities(UpdateLayers, entityToAdd.UpdateLayer);
		updateLayer.Add(entityToAdd);
		entityToAdd.lastUpdateLayer = entityToAdd.UpdateLayer;
	}

	private void AddToDrawLayer(Entity entityToAdd)
	{
		List<Entity> drawLayer = GetLayerEntities(DrawLayers, entityToAdd.DrawLayer);
		drawLayer.Add(entityToAdd);
		entityToAdd.lastDrawLayer = entityToAdd.DrawLayer;
	}

	internal void ProcessMoves()
	{
		foreach (Entity entity in entitiesToMoveUpdate)
		{
			// Check if it has already been added
			if (entity.UpdateLayer == entity.lastUpdateLayer) continue;

			// Remove from last layer
			List<Entity> lastUpdateLayer = GetLayerEntities(UpdateLayers, entity.lastUpdateLayer);
			bool removedFromUpdateLayer = lastUpdateLayer.Remove(entity);

			// Add to new layer
			List<Entity> newUpdateLayer = GetLayerEntities(UpdateLayers, entity.UpdateLayer);
			newUpdateLayer.Add(entity);

			// Mark as added
			entity.lastUpdateLayer = entity.UpdateLayer;
		}
		entitiesToMoveUpdate.Clear();

		foreach (Entity entity in entitiesToMoveDraw)
		{
			// Check if it has already been added
			if (entity.DrawLayer == entity.lastDrawLayer) continue;

			// Remove from last layer
			List<Entity> lastDrawLayer = GetLayerEntities(DrawLayers, entity.lastDrawLayer);
			bool removedFromDrawLayer = lastDrawLayer.Remove(entity);

			// Add to new layer
			List<Entity> newDrawLayer = GetLayerEntities(DrawLayers, entity.DrawLayer);
			newDrawLayer.Add(entity);

			// Mark as added
			entity.lastDrawLayer = entity.DrawLayer;
		}
		entitiesToMoveDraw.Clear();
	}

	internal void ProcessRemovals()
	{
		// Loop through entities to remove
		foreach (Entity entity in entitiesToRemove)
		{
			UpdateLayers[entity.UpdateLayer].Remove(entity);
			DrawLayers[entity.DrawLayer].Remove(entity);	
		}

		// Reset
		List<Entity> entitiesToRemoveCopy = new(entitiesToRemove);
		entitiesToRemove.Clear();
		foreach (Entity entity in entitiesToRemoveCopy) entity.OnRemovedFromScene();
	}

	private List<Entity> GetLayerEntities(SortedList<int, List<Entity>> layers, int layer)
	{
		bool layerExists = layers.TryGetValue(layer, out List<Entity> layerEntities);
		if (!layerExists) layers[layer] = layerEntities = new();
		return layerEntities;
	}

	public void MoveUpdateLayer(Entity entity)
	{
		entitiesToMoveUpdate.Add(entity);
	}

	public void MoveDrawLayer(Entity entity)
	{
		entitiesToMoveDraw.Add(entity);
	}
}
