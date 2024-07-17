using System.Text.Json.Serialization;
using JSONConverters;

namespace Game;

[JsonConverter(typeof(JsonStageConverter))]
public class StageComponent : IStageComponent
{
  public required string UniqueName { get; set; }

  public required List<IGatherComponent> GatherList { get; set; }

  public required IGridMapComponent TerrainLayer { get; set; }

  public required IGridMapComponent DecorationLayer { get; set; }

  public required IGridMapComponent BackgroundLayer { get; set; }

  public GridMapComponent TerrainLayerGridMap
  {
    get
    {
      return (GridMapComponent)TerrainLayer;
    }
  }

  public GridMapComponent DecorationLayerGridMap
  {
    get
    {
      return (GridMapComponent)DecorationLayer;
    }
  }

  public GridMapComponent BackgroundLayerGridMap
  {
    get
    {
      return (GridMapComponent)BackgroundLayer;
    }
  }
}