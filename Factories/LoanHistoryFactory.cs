using ScoutManager.Entities.Item;

namespace ScoutManager.Factories;

public static class LoanHistoryFactory
{
    internal static LoanHistory Create(
        DateTime timestamp,
        Guid itemId,
        Guid borrowerId,
        Guid receiverId)
        => new (
            Guid.NewGuid(),
            timestamp,
            itemId,
            borrowerId,
            receiverId);
}