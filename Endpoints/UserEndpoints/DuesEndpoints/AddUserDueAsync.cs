namespace ScoutManager.Endpoints.UserEndpoints.DuesEndpoints;

public class AddUserDueAsync
{
    
}
public class AddUserDueRequest
{
    public Guid UserId { get; set; }
    public Half Half { get; init; }
    public int Amount { get; init; }
}