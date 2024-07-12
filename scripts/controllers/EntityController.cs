using System.Numerics;
using Game;

namespace Build;

public static class EntityController
{
  public static List<BaseEntity> GameEntities =
  [
    new JulliaActorBuild().LoadFile(),
  ];

  public static BaseEntity GetEntityByUniqueName(string uniqueName)
  {
    return GameEntities.Where(q => q.UniqueName == uniqueName).FirstOrDefault() ?? throw new Exception($"Invalid deserialization. Entity {uniqueName} does not exist.");
  }

  public static List<BaseEntity> GetEntitiesByUniqueName(List<IUniqueNameComponent> uniqueNames)
  {
    return GetEntitiesCloneByUniqueName(uniqueNames.Select(u => u.UniqueName).ToList());
  }

  public static List<BaseEntity> GetEntitiesCloneByUniqueName(List<string> uniqueNames)
  {
    return uniqueNames.Select(uniqueName => GameEntities.FirstOrDefault(q => q.UniqueName == uniqueName) ?? throw new Exception($"Invalid deserialization. Entity {uniqueName} does not exist."))
          .Select(o => o.Clone())
          .Cast<BaseEntity>()
          .ToList();
  }
}