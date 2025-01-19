namespace ScoutManager.Endpoints.Items.LoanHistory;

public class LoanItem
{
    
}

public class LoanItemRequest
{
    public Guid ItemId { get; set; }
    public Guid ReceiverId { get; init; } 
}