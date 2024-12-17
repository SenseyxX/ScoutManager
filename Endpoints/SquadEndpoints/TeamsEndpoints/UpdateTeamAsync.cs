namespace ScoutManager.Endpoints.SquadEndpoints.TeamsEndpoints;

public class UpdateTeamAsync
{
    
}

public class UpdateTeamRequest
{
    public Guid TeamId { get; set; }
    public string Name { get; set; }
    public Guid SquadId { get; set; }
    public Guid TeamOwnerId { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }
}