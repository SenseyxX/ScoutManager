using ScoutManager.Dtos.User;
using ScoutManager.Entities.Squad;

namespace ScoutManager.Dtos.Squad;

public sealed class FullTeamDto : TeamDto
{
    private FullTeamDto(
        Guid id,
        string name,
        Guid squadId,
        Guid teamOwnerId,
        int points,
        IEnumerable<UserDto> userDtos)
        : base(id, name, squadId, teamOwnerId)
    {
        Points = points;
        UserDtos = userDtos;
    }

    public string TeamOwnerName { get; set; }
    public string SquadName { get; set; }
    public int Points { get; }
    public IEnumerable<UserDto> UserDtos { get; }
		  

    public static explicit operator FullTeamDto(Team team)
        =>new (
            team.Id,
            team.Name,
            team.SquadId,
            team.TeamOwnerId,
            team.Points,
            team.Users.Select(user => (UserDto)user));
}