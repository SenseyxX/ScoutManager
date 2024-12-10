using ScoutManager.Entites.Abstractions;

namespace ScoutManager.Entities.Squad;

public sealed class Team : Entity
{
    public Team(
        Guid id,
        string name,
        Guid teamOwnerId,
        Guid squadId,
        string description,
        int points,
        State state
    ):base (id)
    {
        Name = name;
        TeamOwnerId = teamOwnerId;
        SquadId = squadId;
        Description = description;
        Points = points;
        State = state;
        Users = new List<User.User>();
    }

    public string Name { get; private set; }
    public Guid SquadId { get; }
    public Guid TeamOwnerId { get; private set; }
    public string Description { get; private set; }
    public  int Points { get; private set; }
    public State State { get; private set; }
    public ICollection<User.User> Users { get; }
}