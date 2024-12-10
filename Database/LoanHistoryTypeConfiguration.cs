using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScoutManager.Entities.Item;

namespace ScoutManager.Database;

internal sealed class LoanHistoryTypeConfiguration : IEntityTypeConfiguration<LoanHistory>
{
    private const string TableName = "LoanHistories";

    public void Configure(EntityTypeBuilder<LoanHistory> entityTypeBuilder)
    {
        entityTypeBuilder
            .ToTable(TableName, ScoutManagerContext.DefaultSchemaName)
            .HasKey(loanHistory => loanHistory.Id);

        entityTypeBuilder
            .Property(nameof(LoanHistory.Timestamp))
            .HasColumnName(nameof(LoanHistory.Timestamp))
            .IsRequired();

        entityTypeBuilder
            .Property(nameof(LoanHistory.ItemId))
            .HasColumnName(nameof(LoanHistory.ItemId))
            .IsRequired();

        entityTypeBuilder
            .Property(nameof(LoanHistory.BorrowerId))
            .HasColumnName(nameof(LoanHistory.BorrowerId))
            .IsRequired();

        entityTypeBuilder
            .Property(nameof(LoanHistory.ReceiverId))
            .HasColumnName(nameof(LoanHistory.ReceiverId))
            .IsRequired();
    }
}