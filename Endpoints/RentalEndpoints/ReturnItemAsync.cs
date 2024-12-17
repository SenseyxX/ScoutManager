namespace ScoutManager.Endpoints.RentalEndpoints;

public class ReturnItemAsync
{
    
}

public class ReturnItemRequest
{
    public Guid RentalId { get; set; }
    public string RentalItemCode { get; init; }
}