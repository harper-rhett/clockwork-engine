# LDtk Importer

> `using Clockwork.LDTKImporter;`

Building levels by hand in code gets tedious fast. [LDtk](https://ldtk.io/) is a free, modern level editor, and Clockwork has a companion importer that loads `.ldtk` files straight into the [tiles](tiled-world.md) system.

> **Note:** The importer is a separate, still-evolving companion library — the [clockwork-ldtk-importer](https://github.com/harper-rhett/clockwork-ldtk-importer) repository — rather than part of the core engine. Add it as a project or package reference. There is no in-engine level editing yet; you author levels in LDtk and import them here.

## Importing a World

Create an `LDTKImporter` with your project path and tile size, then import a world by naming its tile and entity layers. You get back an `LDTKGameLayer`, which is a [`TiledLayer`](tiled-world.md) you can add to the scene:

```csharp
LDTKImporter importer = new("world.ldtk", 8); // file path, tile size

LDTKGameLayer world = AddEntity(importer.ImportWorld("tiles", "entities"));
LDTKGameArea startArea = world.AreasByName["start"];
```

Decoration layers (parallax backgrounds, foreground detail) import separately and hand back a dictionary of areas keyed by level name:

```csharp
TiledLayer background = AddEntity(importer.ImportDecorationLayer("background", out var backgroundsByName));
background.DrawLayer = -1;
```

## Spawning Entities

Levels usually contain entities — spawn points, doors, pickups. The importer raises `GameAreaImported` for each area as it loads, which is your hook to turn LDtk entity data into your own game entities. Subscribe *before* calling `ImportWorld`:

```csharp
private void ImportWorld()
{
	LDTKImporter importer = new("world.ldtk", 8);
	importer.GameAreaImported += ProcessArea;
	World = AddEntity(importer.ImportWorld("tiles", "entities"));
}

private void ProcessArea(LDTKGameArea area)
{
	foreach (LDTKEntity ldtkEntity in area.Entities)
	{
		Entity entity = null;
		if (ldtkEntity.Name == "dialogue") entity = new DialogueEntity(ldtkEntity, this);
		else if (ldtkEntity.Name == "upgrade") entity = new UpgradeEntity(ldtkEntity, this);

		if (entity is null) continue;
		AddEntity(entity);
		area.RegisterEntity(entity); // ties the entity's lifecycle to the area
	}
}
```

Each `LDTKEntity` carries its `Name`, `Position`, and any custom `Fields` you defined in LDtk, so your entity constructors can read placement and configuration directly from the level data.

Because `LDTKGameArea` extends [`TiledGameArea`](tiled-area.md), everything from the tiles system — registering entities, activating and deactivating areas, tile-type queries — works as documented there.
