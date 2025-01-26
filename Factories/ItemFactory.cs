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
    
    public async Task<ICollection<Item>> CreateAsync(ICollection<ItemModel> itemModels, CancellationToken cancellationToken)
    {
        var categories = await _categoryRepository.GetRangeAsync(cancellationToken);

        var ownerNames = itemModels
            .Select(model => model.Owner)
            .ToList();

        var actualOwnerNames = itemModels
            .Select(model => model.ActualOwner)
            .ToList();

        ownerNames.AddRange(actualOwnerNames);

        ownerNames = ownerNames.Distinct().ToList();

        var users = await _userRepository.GetUsersAsync(ownerNames, cancellationToken);

        var result = new List<Item>();

        foreach (var itemModel in itemModels)
        {
            var categoryId = categories.First(category => category.Name == itemModel.Category).Id;
            var ownerId = users.First(user => user.Email == itemModel.Owner).Id;
            var actualOwnerId = users.First(user => user.Email == itemModel.ActualOwner).Id;

            var item = new Entities.Item(
                Guid.NewGuid(),
                itemModel.Name,
                itemModel.Description,
                categoryId,
                itemModel.QualityLevel,
                itemModel.Quantity,
                State.Active,
                ownerId,
                actualOwnerId);

            result.Add(item);
            await _itemRepository.CreateAsync(item, cancellationToken);
        }

        return result;
    }
    
    //ToDo: Add factory to create item from import file
}