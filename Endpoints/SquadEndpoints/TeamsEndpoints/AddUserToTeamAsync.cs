namespace ScoutManager.Endpoints.SquadEndpoints.TeamsEndpoints;

public class AddUserToTeamAsync
{
    
}

public class AddUserToTeamRequest
{
    public Guid userId { get; set; }
    public Guid squadId { get; init; }
    public Guid teamId { get; set; }
}