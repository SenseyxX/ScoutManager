using ScoutManager.Entites.Abstractions;

namespace ScoutManager.Entities.Squad;

public sealed class Squad : Aggregate
{
    public Squad(
        Guid id,
        string name,
        Guid? squadOwnerId,
        State state)
        : base(id)
    {
        SquadOwnerId = squadOwnerId;
        Name = name;
        State = state;
        Teams = new List<Team>();
        Users = new List<User.User>();
    }

    public Guid? SquadOwnerId { get; private set; }
    public string Name { get; private set; }
    public State State { get; private set; }
    public ICollection<Team> Teams { get; }
    public ICollection<User.User> Users { get; }
}