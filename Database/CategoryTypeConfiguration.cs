using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScoutManager.Entities.Category;

namespace ScoutManager.Database;

internal sealed class CategoryTypeConfiguration : IEntityTypeConfiguration<Category>
{
    private const string TableName = "Category";

    public void Configure(EntityTypeBuilder<Category> entityTypeBuilder)
    {
        entityTypeBuilder
            .ToTable(TableName, ScoutManagerContext.DefaultSchemaName)
            .HasKey(category => category.Id);

        entityTypeBuilder
            .Property(nameof(Category.Name))
            .HasMaxLength(30)
            .HasColumnName(nameof(Category.Name))
            .IsRequired();

        entityTypeBuilder
            .Property(nameof(Category.Description))
            .HasMaxLength(1000)
            .HasColumnName(nameof(Category.Description))
            .IsRequired();

        entityTypeBuilder
            .Property(nameof(Category.State))
            .HasColumnType("smallint")
            .HasColumnName(nameof(Category.State))
            .IsRequired();

        entityTypeBuilder
            .HasMany(category => category.Items)
            .WithOne()
            .HasForeignKey(item => item.CategoryId);
    }
}