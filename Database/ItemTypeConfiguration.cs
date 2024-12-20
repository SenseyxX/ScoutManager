using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScoutManager.Entities;
using ScoutManager.Entities.Item;

namespace ScoutManager.Database;

internal sealed class ItemTypeConfiguration : IEntityTypeConfiguration<Item>
    {
        private const string TableName = "Items";

        // Konfiguracja każdego propa w danej encji
        public void Configure(EntityTypeBuilder<Item> entityTypeBuilder)
        {
            entityTypeBuilder
                .ToTable(TableName, ScoutManagerContext.DefaultSchemaName) // Stworzenie Tabeli
                .HasKey(item => item.Id); // Dodanie klucza tabeli

            entityTypeBuilder
                .Property(nameof(Item.Name)) // Zdefiniownie że dany prop jest stringiem
                .HasMaxLength(50)   // Określenie maksymalnej ilości znaków w komórce
                .HasColumnName(nameof(Item.Name)) // Określenie Nazwy kolumny
                .IsRequired();      // Czy wartość w danej komórce jest wymagana

            entityTypeBuilder
                .Property(nameof(Item.Description))
                .HasMaxLength(1000)
                .HasColumnName(nameof(Item.Description))
                .IsRequired();

            entityTypeBuilder
                .Property(nameof(Item.QualityLevel))
                .HasColumnType("smallint") // Zdefiniowanie typu komórki tinyint wartości od 0-255
                .HasColumnName(nameof(Item.QualityLevel))
                .IsRequired();

            entityTypeBuilder
               .Property(nameof(Item.Quantity))
               .HasColumnName(nameof(Item.Quantity))
               .IsRequired();

            entityTypeBuilder
                .Property(nameof(Item.State))
                .HasColumnType("smallint")
                .HasColumnName(nameof(Item.State))
                .IsRequired();

            entityTypeBuilder
                .Property(nameof(Item.OwnerId))
                .HasColumnName(nameof(Item.OwnerId))
                .IsRequired();

            entityTypeBuilder
                .Property(nameof(Item.ActualOwnerId))
                .HasColumnName(nameof(Item.ActualOwnerId));

            // entityTypeBuilder
            //     .HasMany(item => item.LoanHistories) // Zdefiniowanie  zalezności pomiędzy encją Item a Loan history , Item posiada wiele LoanHistory
            //     .WithOne()    // Określenie że encja LoanHistory posiada tylko jeden item
            //     .HasForeignKey(loadHistory => loadHistory.ItemId); // Ustawienie ForeignKey

            entityTypeBuilder.HasQueryFilter(item => item.State != State.Deleted); // ToDo OPIS
        }
    }