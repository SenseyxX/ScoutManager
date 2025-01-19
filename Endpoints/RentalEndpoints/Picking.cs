namespace ScoutManager.Endpoints.RentalEndpoints;

public class Picking
{
    
}

public class PickingRequest
{
    public Guid RentalId { get; set; }
    public string ItemCode { get; init; }
}
