using Microsoft.EntityFrameworkCore;
using ScoutManager.Database;
using ScoutManager.Entities.Item;
using ScoutManager.Entities.User;

namespace ScoutManager.Repositories;

public sealed class UserRepository : Repository<User>, IUserRepository
{
    public UserRepository(ScoutManagerContext scoutManagerContext) : base(scoutManagerContext)
    {
    }

    public override async Task<User> GetAsync(Guid userId, CancellationToken cancellationToken)
        => await GetWithDependencies()
            .FirstOrDefaultAsync(user => user.Id == userId, cancellationToken);

    public override async Task<ICollection<User>> GetRangeAsync(CancellationToken cancellationToken)
        => await GetWithDependencies()
            .ToListAsync(cancellationToken);

    public async Task<IEnumerable<Item>> GetUserItemsAsync(
        Guid userId,
        CancellationToken cancellationToken)
        => await DbContext
            .Set<Item>()
            .AsNoTracking()
            .Include(item => item.OwnerId)
            .Include(item => item.ActualOwnerId)
            .Where(user => user.Id == userId)
            .ToListAsync(cancellationToken);

    public async Task<bool> IsEmailRegisteredAsync(string emailAddress, CancellationToken cancellationToken) =>
        await DbContext.Set<User>()
            .AnyAsync(user => user.Email == emailAddress, cancellationToken);

    public async Task<ICollection<User>> GetUsersAsync(IEnumerable<string> userEmails, CancellationToken cancellationToken) =>
        await DbContext.Set<User>()
            .AsNoTracking()
            .Where(user => userEmails.Any(email => user.Email == email))
            .ToListAsync(cancellationToken);

    private IQueryable<User> GetWithDependencies()
        => DbContext
            .Set<User>()
            .AsNoTrackingWithIdentityResolution()
            .Include(user => user.Dues)
            .Include(user => user.OwnedItems)
            .Include(user => user.StoredItems);
}