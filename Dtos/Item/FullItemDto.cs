using ScoutManager.Entities;
using ScoutManager.Entities.Item;

namespace ScoutManager.Dtos.Item;

public sealed class FullItemDto : ItemDto // Klasa która ma za zadanie odizolować wybrane propy od głownej encji od edycji/wyświetlania w serwisach/controllerach/repozytoriach
// Klasy FullDto głównie są wykorzystowwane przy wyświetlaniu bardziej szczegółowych informacji                                     
{
    private FullItemDto(
        Guid id,
        string name,
        string description,
        Guid categoryId,
        QualityLevel qualityLevel,
        int quantity,
        State state,
        Guid? ownerId,
        Guid actualOwnerId,
        IEnumerable<LoanHistoryDto>loanHistoryDto)
        : base (id,
            name,
            description,
            categoryId,
            qualityLevel,
            quantity,
            state,
            ownerId,
            actualOwnerId)
    {
        LoanHistoryDto = loanHistoryDto;
    }

    public IEnumerable<LoanHistoryDto> LoanHistoryDto { get; }

    public static explicit operator FullItemDto(Entities.Item.Item item)
        => new(
            item.Id,
            item.Name,
            item.Description,
            item.CategoryId,
            item.QualityLevel,
            item.Quantity,
            item.State,
            item.OwnerId,
            item.ActualOwnerId,
            item.LoanHistories.Select(loanHistory => (LoanHistoryDto)loanHistory));
}