using ScoutManager.Entities.Squad;

namespace ScoutManager.Repositories;

public interface ISquadRepository : IRepository<Squad>
{
    Task<Team> GetTeamAsync(Guid teamId, CancellationToken cancellationToken);
    Task<Squad> GetByOwnerId(Guid squadOwnerId, CancellationToken cancellationToken);
}