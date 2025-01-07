using ScoutManager.Entities.Item;
using ScoutManager.Entities.User;

namespace ScoutManager.Repositories;

public interface IUserRepository : IRepository<User>
{
    Task<IEnumerable<Item>> GetUserItemsAsync(Guid userId, CancellationToken cancellationToken);

    Task<bool> IsEmailRegisteredAsync(string emailAddress, CancellationToken cancellationToken);

    Task<ICollection<User>> GetUsersAsync(IEnumerable<string> userEmails, CancellationToken cancellationToken);

}