using ScoutManager.Entities.Item;

namespace ScoutManager.Endpoints.Items;

public class UpdateItemQuality
{
    
}

public class UpdateItemQualityRequest
{
    public Guid ItemId { get; set; }
    public QualityLevel QualityLevel { get; init; }
}