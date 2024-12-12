using ScoutManager.Entities;
using ScoutManager.Entities.Item;

namespace ScoutManager.Factories;

public class ItemFactory
{
    public static Item Create(
        string name,
        string description,
        Guid categoryId,
        QualityLevel qualityLevel,
        int quantity,
        Guid ownerId)
        => new (
            Guid.NewGuid(),
            name,
            description,
            categoryId,
            qualityLevel,
            quantity,
            State.Active,
            ownerId,
            ownerId);
    
    //ToDo: Add factory to create item from import file
}