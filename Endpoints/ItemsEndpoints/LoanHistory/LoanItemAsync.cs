namespace ScoutManager.Endpoints.Items.LoanHistory;

public class LoanItemAsync
{
    
}

public class LoanItemRequest
{
    public Guid ItemId { get; set; }
    public Guid ReceiverId { get; init; } 
}