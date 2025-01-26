using ScoutManager.Entities.Item;

namespace ScoutManager.Commands.Item;

public sealed class CreateItemCommand
{
    public string Name { get; init; }
    public string Description { get; init; }
    public Guid CategoryId { get; init; }
    public QualityLevel QualityLevel { get; init; }
    public int Quantity { get; init; }
    public Guid OwnerId { get; init; }
}