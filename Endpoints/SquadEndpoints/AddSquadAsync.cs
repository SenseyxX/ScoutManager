namespace ScoutManager.Endpoints.SquadEndpoints;

public class AddSquadAsync
{
    
}

public class AddSquadRequest
{
    public string Name { get; init; }
    public Guid SquadOwnerId { get; init; }
}