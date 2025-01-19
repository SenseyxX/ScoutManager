using ScoutManager.Entities.Item;

namespace ScoutManager.Endpoints.Items;

public class AddItem
{
    
}

public class AddItemRequest
{
    public string Name { get; init; }
    public string Description { get; init; }
    public Guid CategoryId { get; init; }
    public QualityLevel QualityLevel { get; init; }
    public int Quantity { get; init; }
    public Guid OwnerId { get; init; }
}