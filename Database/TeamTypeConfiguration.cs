using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScoutManager.Entities;
using ScoutManager.Entities.Squad;

namespace ScoutManager.Database;

internal sealed class TeamTypeConfiguration : IEntityTypeConfiguration<Team>
{
    private const string TableName = "Teams";

    public void Configure(EntityTypeBuilder<Team> entityTypeBuilder)
    {
        entityTypeBuilder
            .ToTable(TableName, ScoutManagerContext.DefaultSchemaName)
            .HasKey(team => team.Id);

        entityTypeBuilder
            .Property(nameof(Team.Name))
            .HasMaxLength(30)
            .HasColumnName(nameof(Team.Name))
            .IsRequired();

        entityTypeBuilder
            .Property(nameof(Team.TeamOwnerId))
            .HasColumnName(nameof(Team.TeamOwnerId));

        entityTypeBuilder
            .Property(nameof(Team.Description))
            .HasMaxLength(1000)
            .HasColumnName(nameof(Team.Description));

        entityTypeBuilder
            .Property(nameof(Team.Points))
            .HasColumnType("smallint")
            .HasColumnName(nameof(Team.Points));

        entityTypeBuilder
            .HasMany(team => team.Users)
            .WithOne()
            .HasForeignKey(user => user.TeamId);

        entityTypeBuilder.HasQueryFilter(team => team.State != State.Deleted);
    }
}