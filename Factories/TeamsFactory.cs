using ScoutManager.Entities;
using ScoutManager.Entities.Squad;

namespace ScoutManager.Factories;

public class TeamsFactory
{
    public static Team Create(
        string name,
        Guid teamOwnerId,
        Guid squadId,
        string description)
        => new(
            Guid.Empty,
            name,
            teamOwnerId,
            squadId,
            description,
            0,
            State.Active);
}