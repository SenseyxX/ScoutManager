namespace ScoutManager.Endpoints.UserEndpoints;

public class UpdateUserAsync
{
    
}

public class UpdateUserRequest
{
    public Guid UserId { get; set; }
    public string Name { get; init; }
    public string LastName { get; init; }
    public string Email { get; init; }
    public string PhoneNumber { get; init; }

}