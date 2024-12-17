namespace ScoutManager.Endpoints.SquadEndpoints.TeamsEndpoints;

public class AddTeamAsync
{
    
}

public class AddTeamRequest
{
    public string Name { get; init; }
    public Guid TeamOwnerId { get; init; }
    public Guid SquadId { get; set; }
    public string Description { get; init; }
}