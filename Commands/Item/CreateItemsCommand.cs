namespace ScoutManager.Commands.Item;

public sealed class CreateItemsCommand
{
    public IEnumerable<ItemModel> Models { get; init; }
}