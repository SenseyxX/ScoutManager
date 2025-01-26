using ScoutManager.Entities.Item;

namespace ScoutManager.Commands.Item;

public sealed class UpdateItemQualityCommand
{
    public Guid ItemId { get; set; }
    public QualityLevel QualityLevel { get; init; }
}