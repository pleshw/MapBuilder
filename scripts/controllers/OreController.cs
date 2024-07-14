using System.Numerics;
using System.Reflection.Metadata;
using Game;

namespace Build;

public static class OreController
{

  public static readonly List<GatherComponent> OreList = [
  //// STONE
   new GatherComponent
      {
        RequiredLevel = 0,
        UniqueName = "StoneOre",
        Resource =  ItemController.GetItemByUniqueName("StoneOreItem"),
        TimeToRenew = Constants.DayLength/4,
        CompletedAt = null,
        Amount = 3,
        TotalProgress = 10,
        CurrentProgress = 0,
        Position = -Vector2.One,
        LevelByRequiredMastery = new()
        {
          {MasteryTypes.MINING, 1}
        }
      },

  //// COAL
   new GatherComponent
      {
        RequiredLevel = 0,
        UniqueName = "CoalOre",
        Resource = ItemController.GetItemByUniqueName("CoalOreItem"),
        TimeToRenew = Constants.DayLength/3,
        CompletedAt = null,
        Amount = 2,
        TotalProgress = 10,
        CurrentProgress = 0,
        Position = -Vector2.One,
        LevelByRequiredMastery = new()
        {
          {MasteryTypes.MINING, 1}
        }
      },

  //// COOPER
   new GatherComponent
      {
        RequiredLevel = 0,
        UniqueName = "CooperOre",
        Resource = ItemController.GetItemByUniqueName("CooperOreItem"),
        TimeToRenew = Constants.DayLength/3,
        CompletedAt = null,
        Amount = 2,
        TotalProgress = 15,
        CurrentProgress = 0,
        Position = -Vector2.One,
        LevelByRequiredMastery = new()
        {
          {MasteryTypes.MINING, 5}
        }
      },

  //// IRON
   new GatherComponent
      {
        RequiredLevel = 0,
        UniqueName = "IronOre",
        Resource = ItemController.GetItemByUniqueName("IronOreItem"),
        TimeToRenew = Constants.DayLength/3,
        CompletedAt = null,
        Amount = 2,
        TotalProgress = 25,
        CurrentProgress = 0,
        Position = -Vector2.One,
        LevelByRequiredMastery = new()
        {
          {MasteryTypes.MINING, 15}
        }
      },

      
  //// GOLD
   new GatherComponent
      {
        RequiredLevel = 0,
        UniqueName = "GoldOre",
        Resource = ItemController.GetItemByUniqueName("GoldOreItem"),
        TimeToRenew = Constants.DayLength,
        CompletedAt = null,
        Amount = 2,
        TotalProgress = 35,
        CurrentProgress = 0,
        Position = -Vector2.One,
        LevelByRequiredMastery = new()
        {
          {MasteryTypes.MINING, 25}
        }
      },

  //// PLATINUM
   new GatherComponent
      {
        RequiredLevel = 0,
        UniqueName = "PlatinumOre",
        Resource = ItemController.GetItemByUniqueName("PlatinumOreItem"),
        TimeToRenew = Constants.DayLength * 2,
        CompletedAt = null,
        Amount = 2,
        TotalProgress = 60,
        CurrentProgress = 0,
        Position = -Vector2.One,
        LevelByRequiredMastery = new()
        {
          {MasteryTypes.MINING, 50}
        }
      },
 ];

  public static IGatherComponent GetOreByUniqueName(string uniqueName)
  {
    return OreList.Where(q => q.UniqueName == uniqueName).FirstOrDefault() ?? throw new Exception($"Invalid deserialization. Entity {uniqueName} does not exist.");
  }

  public static List<IGatherComponent> GetOresByUniqueName(List<IUniqueNameComponent> uniqueNames)
  {
    return GetOresCloneByUniqueName(uniqueNames.Select(u => u.UniqueName).ToList());
  }

  public static List<IGatherComponent> GetOresCloneByUniqueName(List<string> uniqueNames)
  {
    return uniqueNames.Select(uniqueName => OreList.FirstOrDefault(q => q.UniqueName == uniqueName) ?? throw new Exception($"Invalid deserialization. Entity {uniqueName} does not exist."))
          .Select(o => o.Clone())
          .Cast<IGatherComponent>()
          .ToList();
  }
}