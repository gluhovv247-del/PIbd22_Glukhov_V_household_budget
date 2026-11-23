using household_budget.Entities;
using Microsoft.EntityFrameworkCore;

namespace household_budget.DB_Configurations;

public class DataContext : DbContext
{
    public DbSet<Family> Families { get; set; }
    public DbSet<FamilyMember> FamilyMembers { get; set; }
    public DbSet<Budget> Budgets { get; set; }
    public DbSet<BudgetItem> BudgetItems { get; set; }
    public DbSet<BudgetReport> BudgetReports { get; set; }
    public DbSet<BudgetForecast> BudgetForecasts { get; set; }
    public DbSet<OperationCategory> OperationCategories { get; set; }
    public DbSet<Operation> Operations { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(
        "Host=localhost;Port=5432;Database=household_budget;Username=postgres;Password=root");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
    }
}
