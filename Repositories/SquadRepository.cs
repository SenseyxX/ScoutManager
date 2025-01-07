using Microsoft.EntityFrameworkCore;
using ScoutManager.Database;
using ScoutManager.Entities.Squad;

namespace ScoutManager.Repositories;

public sealed class SquadRepository : Repository<Squad>, ISquadRepository
{
    public SquadRepository(ScoutManagerContext scoutManagerContext)
        : base(scoutManagerContext)
    {
    }

    public override async Task<Squad> GetAsync(Guid squadId, CancellationToken cancellationToken)
        => await GetSquadDependencies()
            .FirstOrDefaultAsync(squad => squad.Id == squadId, cancellationToken);

    public async Task<Team> GetTeamAsync(Guid teamId, CancellationToken cancellationToken)
        => await DbContext
            .Set<Team>()
            .FirstOrDefaultAsync(team => team.Id == teamId);

    public async Task<Squad> GetByOwnerId(Guid squadOwnerId, CancellationToken cancellationToken)
        => await GetSquadDependencies()
            .FirstOrDefaultAsync(squad => squad.SquadOwnerId == squadOwnerId, cancellationToken);

    private IQueryable<Squad> GetSquadDependencies()
        => DbContext
            .Set<Squad>()
            .AsNoTrackingWithIdentityResolution()
            .Include(squad => squad.Users)
            .Include(squad => squad.Teams)
            .ThenInclude(team => team.Users);
}