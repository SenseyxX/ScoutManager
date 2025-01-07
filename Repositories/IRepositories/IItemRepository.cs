using ScoutManager.Entities.Item;

namespace ScoutManager.Repositories;

public interface IItemRepository : IRepository<Item>
{
    Task<Item> GetByCodeAsync(string itemCode, CancellationToken cancellationToken); // do przemyślenia
}