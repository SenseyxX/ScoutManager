using ScoutManager.Entities.User;
using Half = ScoutManager.Entities.User.Half;
namespace ScoutManager.Factories;

public static class DueFactory
{
    public static Due Create(Guid userId, Half half, int amount)
        => new(
            Guid.NewGuid(),
            userId,
            half,
            amount,
            DueStatus.Waiting);
}