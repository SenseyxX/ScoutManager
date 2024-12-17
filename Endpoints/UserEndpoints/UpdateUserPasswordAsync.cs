namespace ScoutManager.Endpoints.UserEndpoints;

public class UpdateUserPasswordAsync
{
    public Guid UserId { get; set; }
    public string Password { get; set; }
}