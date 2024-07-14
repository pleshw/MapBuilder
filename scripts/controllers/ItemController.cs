using System.Numerics;
using System.Reflection.Metadata;
using Game;

namespace Build;

public static class ItemController
{
  public static readonly List<ItemComponent> ItemList = [
      new ItemComponent()
      {
        ItemType = ItemTypes.ORE,
        DisplayName = "Stone",
        UniqueName = "StoneOreItem",
        RequiredLevel = 0,
        Description = "A piece of stone. It's a basic resource for crafting.",
        DisplayImage = "images/stone_item.png",
      },
      new ItemComponent()
      {
        ItemType = ItemTypes.ORE,
        DisplayName = "Coal",
        UniqueName = "CoalOreItem",
        RequiredLevel = 0,
        Description = "I think it can be used as fuel.",
        DisplayImage = "images/coal_item.png",
      },
      new ItemComponent()
      {
        ItemType = ItemTypes.ORE,
        DisplayName = "Cooper",
        UniqueName = "CooperOreItem",
        RequiredLevel = 0,
        Description = "It's a hard metal. If i melt maybe it can be used for crafting.",
        DisplayImage = "images/cooper_item.png",
      },
      new ItemComponent()
      {
        ItemType = ItemTypes.ORE,
        DisplayName = "Iron",
        UniqueName = "IronOreItem",
        RequiredLevel = 0,
        Description = "It definitely can be refined.",
        DisplayImage = "images/iron_item.png",
      },
      new ItemComponent()
      {
          ItemType = ItemTypes.ORE,
          DisplayName = "Gold",
          UniqueName = "GoldOreItem",
          RequiredLevel = 0,
          Description = "It definitely can be refined.",
          DisplayImage = "images/gold_item.png",
      },
      new ItemComponent()
      {
        ItemType = ItemTypes.ORE,
        DisplayName = "Platinum",
        UniqueName = "PlatinumOreItem",
        RequiredLevel = 0,
        Description = "It looks rare and pretty strong.",
        DisplayImage = "images/platinum_item.png",
      },
 ];

  public static IItemComponent GetItemByUniqueName(string uniqueName)
  {
    return ItemList.Where(q => q.UniqueName == uniqueName).FirstOrDefault() ?? throw new Exception($"Invalid deserialization. Entity {uniqueName} does not exist.");
  }

  public static List<IItemComponent> GetItemsByUniqueName(List<IUniqueNameComponent> uniqueNames)
  {
    return GetItemsCloneByUniqueName(uniqueNames.Select(u => u.UniqueName).ToList());
  }

  public static List<IItemComponent> GetItemsCloneByUniqueName(List<string> uniqueNames)
  {
    return uniqueNames.Select(uniqueName => ItemList.FirstOrDefault(q => q.UniqueName == uniqueName) ?? throw new Exception($"Invalid deserialization. Entity {uniqueName} does not exist."))
          .Select(o => o.Clone())
          .Cast<IItemComponent>()
          .ToList();
  }
}