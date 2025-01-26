using ScoutManager.Dtos.Item;

namespace ScoutManager.Dtos.Category;

public sealed class FullCategoryDto : CategoryDto
{
    private FullCategoryDto(
        Guid id,
        string name,
        string description,
        IEnumerable<ItemDto> itemDtos)
        : base(id, name, description)
    {
        ItemDtos = itemDtos;
    }

    public IEnumerable<ItemDto> ItemDtos { get; }

    public static explicit operator FullCategoryDto(Entities.Category.Category category)
        => new(category.Id,
            category.Name,
            category.Description,
            category.Items.Select(item => (ItemDto) item));        
}