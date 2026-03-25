using System.Collections;
using Clockwork.Graphics;
using Clockwork.Graphics.Text;

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

	// Registry
	private Dictionary<Type, object> entityLists = new();
	private Dictionary<Type, Entity> latestEntities = new();

	internal void Add(Entity entity)
	{
		entitiesToAdd.Add(entity);
		Index(entity);
	}

	internal void Remove(Entity entity)
	{
		entitiesToRemove.Add(entity);
		Unindex(entity);
	}

	internal void ProcessAdditions()
	{
		foreach (Entity entity in entitiesToAdd)
		{
			AddToUpdateLayer(entity);
			AddToDrawLayer(entity);
			entity.OnAddedToScene();
		}
		entitiesToAdd.Clear();
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
		foreach (Entity entity in entitiesToRemove)
		{
			updateLayers[entity.UpdateLayer].Remove(entity);
			drawLayers[entity.DrawLayer].Remove(entity);
			entity.OnRemovedFromScene();
		}
		entitiesToRemove.Clear();
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

	internal void Index(Entity entity)
	{
		// Get the entity list
		Type type = entity.GetType();
		bool setExists = entityLists.TryGetValue(type, out object entityListObject);

		// Index as latest
		latestEntities[type] = entity;

		// Create list if needed
		if (!setExists)
		{
			Type listType = typeof(List<>).MakeGenericType(type);
			entityListObject = (IList)Activator.CreateInstance(listType);
			entityLists[type] = entityListObject;
		}

		// Add entity to list
		((IList)entityListObject).Add(entity);
	}

	internal void Unindex(Entity entity)
	{
		Type type = entity.GetType();
		object entityListObject = entityLists[type];
		IList entityList = (IList)entityListObject;
		entityList.Remove(entity);
		if (entityList.Count > 0) latestEntities[type] = (Entity)entityList[entityList.Count - 1];
		else latestEntities.Remove(type);
	}

	public IReadOnlyList<EntityType> GetEntities<EntityType>() where EntityType : Entity
	{
		// Get the entity list
		Type type = typeof(EntityType);
		bool setExists = entityLists.TryGetValue(type, out object entityListObject);

		// Return
		if (setExists) return (List<EntityType>)entityListObject;
		else return Array.Empty<EntityType>();
	}

	public EntityType GetEntity<EntityType>() where EntityType : Entity
	{
		Type type = typeof(EntityType);
		return (EntityType)latestEntities[type];
	}

	public void DrawDebug(int fontSize, int spacing)
	{
		int index = 0;
		foreach (KeyValuePair<Type, object> entityListPair in entityLists)
		{
			// Get type
			Type type = entityListPair.Key;
			string typeString = type.ToString();

			// Convert to list
			IList entityList = (IList)entityListPair.Value;
			int typeCount = entityList.Count;
			if (typeCount == 0) continue;

			// Draw type
			string text = $"{typeString}: {typeCount}";
			int y = spacing + index * (fontSize + spacing);
			Text.Draw(text, spacing, y, fontSize, Colors.White);
			index++;
		}
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
