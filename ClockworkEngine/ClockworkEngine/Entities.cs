namespace Clockwork;

public class Entities
{
	// Entities
	private List<Entity> entitiesToAdd = new();
	private List<Entity> entitiesToMoveUpdate = new();
	private List<Entity> entitiesToMoveDraw = new();
	private List<Entity> entitiesToRemove = new();

	// Layers
	private SortedList<int, List<Entity>> updateLayers = new();
	private SortedList<int, List<Entity>> drawLayers = new();

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
		List<Entity> updateLayer = GetLayerEntities(updateLayers, entityToAdd.UpdateLayer);
		updateLayer.Add(entityToAdd);
		entityToAdd.lastUpdateLayer = entityToAdd.UpdateLayer;
	}

	private void AddToDrawLayer(Entity entityToAdd)
	{
		List<Entity> drawLayer = GetLayerEntities(drawLayers, entityToAdd.DrawLayer);
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
			List<Entity> lastUpdateLayer = GetLayerEntities(updateLayers, entity.lastUpdateLayer);
			bool removedFromUpdateLayer = lastUpdateLayer.Remove(entity);

			// Add to new layer
			List<Entity> newUpdateLayer = GetLayerEntities(updateLayers, entity.UpdateLayer);
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
			List<Entity> lastDrawLayer = GetLayerEntities(drawLayers, entity.lastDrawLayer);
			bool removedFromDrawLayer = lastDrawLayer.Remove(entity);

			// Add to new layer
			List<Entity> newDrawLayer = GetLayerEntities(drawLayers, entity.DrawLayer);
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
			updateLayers[entity.UpdateLayer].Remove(entity);
			drawLayers[entity.DrawLayer].Remove(entity);	
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

	public IEnumerable<Entity> InUpdateOrder
	{
		get
		{
			foreach (List<Entity> entityLayer in updateLayers.Values)
				foreach (Entity entity in entityLayer)
					yield return entity;
		}
	}

	public IEnumerable<Entity> InDrawOrder
	{
		get
		{
			foreach (List<Entity> entityLayer in drawLayers.Values)
				foreach (Entity entity in entityLayer)
					yield return entity;
		}
	}
}
