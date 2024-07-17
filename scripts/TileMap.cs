using Game;
using Godot;
using System;
using System.Collections.Generic;
using System.Linq;

public partial class TileMap : Godot.TileMap
{
	Dictionary<string, Vector2I> test = [];

	// public StageComponent st = new StageComponent()
	// {
	// 	UniqueName = "AliceHouseOutside",
	// 	GatherList = [],
	// 	TerrainLayer = new GridMapComponent()
	// 	{
	// 		GridCells = Enumerable.Range(0, 100)
	// 												.Select(i => new GridCellTileSetComponent
	// 												{
	// 													TileSetPosition = new(i % 10, i / 10),
	// 													Position = new(i % 10, i / 10),
	// 													Size = new(3, 3),
	// 													Index = i,
	// 													Status = (GridCellStatus)(1 << (i % 6))
	// 												} as IGridCellComponent)
	// 												.ToList(),
	// 		Width = 10,
	// 		Height = 10
	// 	},
	// };


	public override void _Ready()
	{
		int layerCount = GetLayersCount();
		Vector2 tileMapSize = GetUsedRect().Size;

		for (int layer = 0; layer < layerCount; ++layer)
		{
			string layerName = GetLayerName(layer);

			if (layerName.Equals("terrain", StringComparison.CurrentCultureIgnoreCase))
			{
				List<Vector2I> layerUsedCells = [.. GetUsedCells(layer)];

				foreach (var cellCoords in layerUsedCells)
				{
					Vector2I cellTileSetPosition = GetCellAtlasCoords(layer, cellCoords);
				}
			}

			if (layerName.Equals("decoration", StringComparison.CurrentCultureIgnoreCase))
			{
				List<Vector2I> layerUsedCells = [.. GetUsedCells(layer)];

				foreach (var cellCoords in layerUsedCells)
				{
					Vector2I cellTileSetPosition = GetCellAtlasCoords(layer, cellCoords);
				}
			}


			if (layerName.Equals("background", StringComparison.CurrentCultureIgnoreCase))
			{
				List<Vector2I> layerUsedCells = [.. GetUsedCells(layer)];

				foreach (var cellCoords in layerUsedCells)
				{
					Vector2I cellTileSetPosition = GetCellAtlasCoords(layer, cellCoords);
				}
			}

			if (layerName.Equals("ores", StringComparison.CurrentCultureIgnoreCase))
			{

			}
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
