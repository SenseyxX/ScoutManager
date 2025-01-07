using Microsoft.EntityFrameworkCore;
using ScoutManager.Database;
using ScoutManager.Entities.Category;

namespace ScoutManager.Repositories;

public sealed class CategoryRepository : Repository<Category> ,ICategoryRepository
{
    public CategoryRepository(ScoutManagerContext scoutManagerContext)
        : base(scoutManagerContext)
    {
    }
    
    public override async Task<Category> GetAsync(Guid squadId, CancellationToken cancellationToken)
        => await DbContext
            .Set<Category>()
            .Include(category => category.Items)
            .FirstOrDefaultAsync(entity => entity.Id == squadId, cancellationToken);
}