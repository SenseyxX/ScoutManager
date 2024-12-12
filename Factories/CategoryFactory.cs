using ScoutManager.Entities;
using ScoutManager.Entities.Category;

namespace ScoutManager.Factories;

public static class CategoryFactory
{
    public static Category Create(
        string name,
        string description)
        => new(
            Guid.NewGuid(),
            name,
            description,
            State.Active);
}