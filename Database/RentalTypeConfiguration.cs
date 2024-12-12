using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScoutManager.Entities.Rental;

namespace ScoutManager.Database;

internal sealed class RentalTypeConfiguration : IEntityTypeConfiguration<Rental>
{
    private const string TableName = "Rental";

    public void Configure(EntityTypeBuilder<Rental> entityTypeBuilder)
    {
        entityTypeBuilder
            .ToTable(TableName, ScoutManagerContext.DefaultSchemaName)
            .HasKey(rental => rental.Id);

        entityTypeBuilder
            .Property(nameof(Rental.Name))
            .HasColumnName(nameof(Rental.Name))
            .IsRequired();
                
        entityTypeBuilder
            .Property(nameof(Rental.UserId))
            .HasColumnName(nameof(Rental.UserId))
            .IsRequired();

        entityTypeBuilder
            .Property(nameof(Rental.RentalStatus))
            .HasColumnName(nameof(Rental.RentalStatus))
            .IsRequired();

        entityTypeBuilder
            .HasMany(rental => rental.RentalItems)
            .WithOne()
            .HasForeignKey(rentalItem => rentalItem.Id);
    }
}