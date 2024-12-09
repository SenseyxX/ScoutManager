using ScoutManager.Entites.Abstractions;

namespace ScoutManager.Entities.Category;

public sealed class Category : Aggregate
{
    public Category(Guid id,
        string name,
        string description,
        State state)
        : base(id)
    {
        Name = name;
        Description = description;
        State = state;
        Items = new List<Item.Item>();
    }

    public string Name { get; private set; }
    public string Description { get; private set; }
    public State State { get;private set; }
    public ICollection<Item.Item> Items { get; }


}