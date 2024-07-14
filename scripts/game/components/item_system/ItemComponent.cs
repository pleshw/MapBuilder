namespace Game;

public class ItemComponent : IItemComponent
{
  public ItemTypes ItemType { get; set; }

  public required string DisplayName { get; set; }

  public required string UniqueName { get; set; }

  public required string Description { get; set; }

  public required string DisplayImage { get; set; }

  public required int RequiredLevel { get; set; }

  public void LoadImage()
  {
    throw new NotImplementedException();
  }

  public object Clone()
  {
    return new ItemComponent
    {
      RequiredLevel = RequiredLevel,
      ItemType = ItemType,
      DisplayName = DisplayName,
      UniqueName = UniqueName,
      Description = Description,
      DisplayImage = DisplayImage,
    };
  }

  public void Copy(ICopyable copyable)
  {
    ItemComponent resourceToCopy = (ItemComponent)copyable ?? throw new Exception($"Cannot copy from {copyable?.GetType()}.");

    RequiredLevel = resourceToCopy.RequiredLevel;
    ItemType = resourceToCopy.ItemType;
    DisplayName = resourceToCopy.DisplayName;
    UniqueName = resourceToCopy.UniqueName;
    Description = resourceToCopy.Description;
    DisplayImage = resourceToCopy.DisplayImage;
  }
}