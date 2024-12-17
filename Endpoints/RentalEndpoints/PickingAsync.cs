namespace ScoutManager.Endpoints.RentalEndpoints;

public class PickingAsync
{
    
}

public class PickingRequest
{
    public Guid RentalId { get; set; }
    public string ItemCode { get; init; }
}
