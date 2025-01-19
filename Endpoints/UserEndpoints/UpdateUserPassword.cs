namespace ScoutManager.Endpoints.UserEndpoints;

public class UpdateUserPassword
{
    public Guid UserId { get; set; }
    public string Password { get; set; }
}