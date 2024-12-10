using Microsoft.EntityFrameworkCore;
using ScoutManager.Entities.Category;
using ScoutManager.Entities.Item;
using ScoutManager.Entities.Squad;
using ScoutManager.Entities.User;

namespace ScoutManager.Database;

public sealed class ScoutManagerContext : DbContext
{
    public const string DefaultSchemaName = "ScoutManager";

    public ScoutManagerContext(DbContextOptions<ScoutManagerContext> options)
        : base(options)
    {
    }
    public DbSet<Category> Categories { get; init; }
    public DbSet<Due> Dues { get; init; }
    public DbSet<Item> Items { get; init; }
    public DbSet<LoanHistory> LoanHistories { get; init; }
    // public DbSet<Rental> Rentals { get; init; }
    // public DbSet<RentalItem> RentalItems { get; init; }
    public DbSet<Squad>Squads  { get; init; }
    public DbSet<User> Users { get; init; }
    public DbSet<Team> Teams { get; init; }


    // Inicjowanie plików konfiguracyjnych encje
    protected override void OnModelCreating(ModelBuilder modelBuilder)
        => modelBuilder
            .ApplyConfiguration(new CategoryTypeConfiguration())
            .ApplyConfiguration(new DueTypeConfiguration())
            .ApplyConfiguration(new ItemTypeConfiguration())
            .ApplyConfiguration(new LoanHistoryTypeConfiguration())
            // .ApplyConfiguration(new RentalTypeConfiguration())
            // .ApplyConfiguration(new RentalItemTypeConfiguration())
            .ApplyConfiguration(new SquadTypeConfiguration())
            .ApplyConfiguration(new TeamTypeConfiguration())
            .ApplyConfiguration(new UserTypeConfiguration());
}