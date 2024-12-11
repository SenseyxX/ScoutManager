using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScoutManager.Entities.Squad;

namespace ScoutManager.Database;

internal sealed class SquadTypeConfiguration : IEntityTypeConfiguration<Squad>
{
    private const string TableName = "Squads";

    public void Configure(EntityTypeBuilder<Squad> entityTypeBuilder)
    {
        entityTypeBuilder
            .ToTable(TableName, ScoutManagerContext.DefaultSchemaName)
            .HasKey(squad => squad.Id);

        entityTypeBuilder
            .Property(nameof(Squad.Name))
            .HasMaxLength(30)
            .HasColumnName(nameof(Squad.Name))
            .IsRequired();

        entityTypeBuilder
            .Property(nameof(Squad.State))
            .HasColumnType("smallint")
            .HasColumnName(nameof(Squad.State))
            .IsRequired();

        entityTypeBuilder
            .Property(nameof(Squad.SquadOwnerId))
            .HasColumnName(nameof(Squad.SquadOwnerId))
            .IsRequired(false);

        entityTypeBuilder
            .HasMany(squad => squad.Users)
            .WithOne()
            .HasForeignKey(user => user.SquadId)
            .OnDelete(DeleteBehavior.SetNull);

        entityTypeBuilder
            .HasMany(squad => squad.Teams)
            .WithOne()
            .HasForeignKey(team => team.SquadId);
    }
}