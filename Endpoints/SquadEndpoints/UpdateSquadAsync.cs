namespace ScoutManager.Endpoints.SquadEndpoints;

public class UpdateSquadAsync
{
    
}

public class UpdateSquadRequest
{
    public Guid SquadId { get; set; }
    public Guid SquadOwnerId { get; init; }
    public string  Name { get; init; }
}