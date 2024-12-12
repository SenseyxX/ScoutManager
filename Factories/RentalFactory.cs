using ScoutManager.Entities.Rental;

namespace ScoutManager.Factories;

public static class RentalFactory
{
    public static Rental Create( 
        Guid userId,
        string name)
        => new (
            Guid.NewGuid(),
            name,
            userId,
            RentalStatus.Started);
}