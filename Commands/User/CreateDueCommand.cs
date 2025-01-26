namespace ScoutManager.Commands.User;
using Half = Entities.User.Half;

public sealed class CreateDueCommand
{
    public Guid UserId { get; set; }
    public Half Half { get; init; }
    public int Amount { get; init; }
}