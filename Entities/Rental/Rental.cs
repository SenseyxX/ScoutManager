using ScoutManager.Entites.Abstractions;

namespace ScoutManager.Entities.Rental;

public sealed class Rental : Aggregate
{
    internal Rental(
        Guid id,
        string name,
        Guid userId,
        RentalStatus rentalStatus)
        : base(id)
    {
        UserId = userId;
        Name = name;
        RentalStatus = rentalStatus;
        RentalItems = new List<RentalItem>();
    }

    public Guid UserId { get; }
    public string Name { get; }
    public RentalStatus RentalStatus { get; private set; }
    public ICollection<RentalItem> RentalItems { get; }

}