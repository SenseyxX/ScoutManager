namespace ScoutManager.Endpoints.UserEndpoints.DuesEndpoints;

public class UpdateUserDue
{
    
}

public class UpdateUserDueRequest
{
    public Guid UserId { get; set; }
    public Guid DueId { get; set; }
    public int Amount { get; init; }
}