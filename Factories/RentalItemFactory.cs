using ScoutManager.Entities.Rental;

namespace ScoutManager.Factories;

public class RentalItemFactory
{
    public static RentalItem Create(
        string rentalItemCode)
        => new(
            Guid.NewGuid(),
            rentalItemCode,
            RentalItemStatus.Picked);
}