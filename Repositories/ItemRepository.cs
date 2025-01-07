using Microsoft.EntityFrameworkCore;
using ScoutManager.Database;
using ScoutManager.Entities.Item;

namespace ScoutManager.Repositories;

public sealed class ItemRepository : Repository<Item>, IItemRepository
{
    public ItemRepository(ScoutManagerContext scoutManagerContext)
        : base(scoutManagerContext)
    {
    }

    public override async Task<Item> GetAsync(Guid squadId, CancellationToken cancellationToken)
        => await DbContext
            .Set<Item>()
            .Include(item => item.LoanHistories)
            .AsNoTrackingWithIdentityResolution()
            .FirstOrDefaultAsync(item => item.Id == squadId, cancellationToken);

    public async Task<Item> GetByCodeAsync(string itemCode, CancellationToken cancellationToken)
        => await DbContext
            .Set<Item>()
            .AsNoTrackingWithIdentityResolution()
            .Include(item => item.LoanHistories)
            .FirstOrDefaultAsync(item => item.Name == itemCode, cancellationToken);

    public async Task<ICollection<Item>> GetByUserIdAsync(Guid userId, CancellationToken cancellationToken)
        => await DbContext
            .Set<Item>()
            .Include(item => item.LoanHistories)
            .AsNoTrackingWithIdentityResolution()
            .Where(item => item.OwnerId == userId)
            .ToListAsync(cancellationToken);
}