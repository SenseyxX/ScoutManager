using ScoutManager.Entites;
using ScoutManager.Entites.Abstractions;

namespace ScoutManager.Entities.Item;

public sealed class 
    Item : Aggregate // Encja "Item" jest agregatem dla innych encji jak "LoanHistory"
{
    public Item(
        Guid id,
        string name,
        string description,
        Guid categoryId,
        QualityLevel qualityLevel,
        int quantity,
        State state,
        Guid ownerId,
        Guid actualOwnerId)
        : base(id)  // Zdefiniowany constructor z klasy Agregatu
    {
        Name = name; // Przypisanie wartości constructora do danego propa
        Description = description;
        CategoryId = categoryId;
        QualityLevel = qualityLevel;
        Quantity = quantity;
        State = state;
        OwnerId = ownerId;
        ActualOwnerId = actualOwnerId;
        // LoanHistories = new List<LoanHistory>(); // Stworzenie listy i przypisanie do propa
    }

    public string Name { get; private set; }
    public string Description { get; private set; }
    public Guid CategoryId { get; private set; } // Zdefiniowanie wartości która występuje w encji "Category"
    public QualityLevel QualityLevel { get; private set; } // Zdefiniowanie wartości która występuje w enumie "QualityLevel".
    public int Quantity { get; private set; }
    public State State { get; private set; } // Zdefiniowanie wartości która występuje w enumie "State"
    public Guid OwnerId { get;  }
    public Guid ActualOwnerId { get; private set; }
    // public ICollection<LoanHistory> LoanHistories { get; } // Stworzenie relacji jeden do wielu (jeden Item może mieć wiele LoanHistory)

}