namespace ScoutManager.Commands.User;

public sealed class AuthenticateUserCommand
{
    public string Email { get; init; }
    public string Password { get; init; }
}