using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScoutManager.Entities.Rental;

namespace ScoutManager.Database;

internal sealed class RentalItemTypeConfiguration : IEntityTypeConfiguration<RentalItem>
{
    private const string TableName = "RentalItems";
        
    public void Configure(EntityTypeBuilder<RentalItem> entityTypeBuilder)
    {
        entityTypeBuilder
            .ToTable(TableName, ScoutManagerContext.DefaultSchemaName)
            .HasKey(rentalItem => rentalItem.Id);

        entityTypeBuilder
            .Property(nameof(RentalItem.RentalItemCode))
            .HasColumnName(nameof(RentalItem.RentalItemCode))
            .IsRequired();

        entityTypeBuilder
            .Property(nameof(RentalItem.RentalItemStatus))
            .HasColumnName(nameof(RentalItem.RentalItemStatus))
            .IsRequired();
    }
}