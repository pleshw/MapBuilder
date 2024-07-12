using Godot;
using System;
using System.Collections.Generic;
using System.Linq;

public partial class TileMap : Godot.TileMap
{
	Dictionary<string, Vector2I> test = [];
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		int layerCount = GetLayersCount();
		for (int layer = 0; layer < layerCount; ++layer)
		{
			List<Vector2I> layerUsedCells = [.. GetUsedCells(layer)];

			foreach (var cellCoords in layerUsedCells)
			{
				Vector2I cellTileSetPosition = GetCellAtlasCoords(layer, cellCoords);
				Console.WriteLine(TileSet.ResourceName);
			}
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
