using ScoutManager.Entites.Abstractions;

namespace ScoutManager.Repositories;

public interface IRepository<TAggregate> 
    where TAggregate : Aggregate
{
    Task<TAggregate> GetAsync(Guid squadId, CancellationToken cancellationToken);
    Task<ICollection<TAggregate>> GetRangeAsync(CancellationToken cancellationToken);
    Task CreateAsync(TAggregate entity, CancellationToken cancellationToken);
    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    Task SaveAsync(CancellationToken cancellationToken);
    void Update(TAggregate entity);
}