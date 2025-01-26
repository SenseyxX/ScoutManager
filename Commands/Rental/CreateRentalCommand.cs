namespace ScoutManager.Commands.Rental;

public sealed class CreateRentalCommand
{
    public Guid UserId { get; set; }
    public string Name { get; init; }
}