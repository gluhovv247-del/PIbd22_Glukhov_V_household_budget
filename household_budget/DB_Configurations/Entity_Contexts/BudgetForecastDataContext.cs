using household_budget.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.DB_Configurations.Entity_Contexts;

public class BudgetForecastDataContext : IEntityTypeConfiguration<BudgetForecast>
{
    public void Configure(EntityTypeBuilder<BudgetForecast> builder)
    {
        builder.ToTable("budget_forecasts");

        builder.HasOne(b => b.Family)
              .WithMany(f => f.BudgetForecasts)
              .HasForeignKey(b => b.FamilyId)
              .OnDelete(DeleteBehavior.Cascade);
    }
}
