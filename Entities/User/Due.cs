using ScoutManager.Entites.Abstractions;

namespace ScoutManager.Entities.User;

public sealed class Due : Entity
{
    public Due(
        Guid id,
        Guid userId,
        Half half,
        int amount,
        DueStatus dueStatus)
        : base(id)
    {
        UserId = userId;
        Half = half;
        Amount = amount;
        DueStatus = dueStatus;
    }

    public Guid UserId { get; }
    public Half Half { get; }
    public int Amount { get; private set; }
    public DueStatus DueStatus { get; private set; }

    internal void UpdateAmount(int amount)
    {
        if (DueStatus == DueStatus.Paid || Amount == amount)
        {
            throw new Exception();
        }

        Amount = amount;
    }

    internal void Pay()
    {
        if (DueStatus == DueStatus.Paid)
        {
            throw new Exception();
        }

        DueStatus = DueStatus.Paid;
    }
}