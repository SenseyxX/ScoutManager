namespace ScoutManager.Commands.Rental;

public sealed class ReturnItemCommand
{
    public Guid RentalId { get; set; }
    public string RentalItemCode { get; init; }
}