namespace ScoutManager.Endpoints.UserEndpoints.DuesEndpoints;

public class PayUserDue
{
    
}

public class PayUserDueRequest
{
    public Guid UserId { get; set; }
    public Guid DueId { get; set; }
}