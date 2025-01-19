namespace ScoutManager.Endpoints.SquadEndpoints;

public class UpdateSquad
{
    
}

public class UpdateSquadRequest
{
    public Guid SquadId { get; set; }
    public Guid SquadOwnerId { get; init; }
    public string  Name { get; init; }
}