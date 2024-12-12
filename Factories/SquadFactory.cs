using ScoutManager.Entities;
using ScoutManager.Entities.Squad;

namespace ScoutManager.Factories;

public static class SquadFactory
{
    public static Squad Create(Guid squadOwnerId, string name)
        => new(
            Guid.NewGuid(),
            name,
            squadOwnerId,
            State.Active);
}