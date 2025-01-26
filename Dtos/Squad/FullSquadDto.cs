using ScoutManager.Dtos.User;
using ScoutManager.Entities;

namespace ScoutManager.Dtos.Squad;

public sealed class FullSquadDto : SquadDto
{
    private FullSquadDto(
        Guid id,
        string name,
        Guid? squadOwnerId,
        State state,
        IEnumerable<TeamDto> teams,
        IEnumerable<UserDto> users)
        : base(id,name,squadOwnerId,state)
    {
        Users = users;
        Teams = teams;
    }

    public IEnumerable<TeamDto> Teams { get; }
    public IEnumerable<UserDto> Users { get; }

    public static explicit operator FullSquadDto(Entities.Squad.Squad squad)
        => new(
            squad.Id,
            squad.Name,
            squad.SquadOwnerId,
            squad.State,
            squad.Teams.Select(team => (TeamDto)team),
            squad.Users.Select(user => (UserDto)user));
}