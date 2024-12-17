using ScoutManager.Entities.Item;

namespace ScoutManager.Endpoints.Items;

public class UpdateItemAsync
{
    
}

public class UpdateItemRequest
{
    public Guid ItemId { get; set; }
    public string Name { get; init; }
    public Guid OwnerId { get; init; }
    public Guid CategoryId { get; init; }
    public string Description { get; init; }
    public int Quantity { get; init; }
    public QualityLevel QualityLevel { get; init; }
}