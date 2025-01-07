using Microsoft.EntityFrameworkCore;
using ScoutManager.Database;
using ScoutManager.Entities.Rental;

namespace ScoutManager.Repositories;

public sealed class RentalRepository : Repository<Rental>, IRentalRepository
{
    public RentalRepository(ScoutManagerContext scoutManagerContext) 
        : base(scoutManagerContext)
    {
    }
    
    public override async Task<Rental> GetAsync(Guid squadId, CancellationToken cancellationToken)
        => await GetWithDependencies()
            .FirstOrDefaultAsync(rentalItem => rentalItem.Id == squadId, cancellationToken);

    public override async Task<ICollection<Rental>> GetRangeAsync(CancellationToken cancellationToken)
        => await GetWithDependencies()
            .ToListAsync(cancellationToken);

    private IQueryable<Rental> GetWithDependencies()
        => DbContext
            .Set<Rental>()
            .AsNoTracking()
            .Include(rentalItems => rentalItems.RentalItems);
}