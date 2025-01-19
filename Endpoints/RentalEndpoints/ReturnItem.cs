namespace ScoutManager.Endpoints.RentalEndpoints;

public class ReturnItem
{
    
}

public class ReturnItemRequest
{
    public Guid RentalId { get; set; }
    public string RentalItemCode { get; init; }
}