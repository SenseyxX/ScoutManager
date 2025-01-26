namespace ScoutManager.Commands.User;

public class UpdateUserPasswordCommand
{
    public Guid UserId { get; set; }
    public string Password { get; set; }
}