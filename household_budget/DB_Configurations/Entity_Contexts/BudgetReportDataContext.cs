using household_budget.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.DB_Configurations.Entity_Contexts;

public class BudgetReportDataContext : IEntityTypeConfiguration<BudgetReport>
{
    public void Configure(EntityTypeBuilder<BudgetReport> builder)
    {
        builder.ToTable("budget_reports");

        builder.HasOne(br => br.Budget)
              .WithMany(b => b.BudgetReports)
              .HasForeignKey(br => br.BudgetId)
              .OnDelete(DeleteBehavior.Cascade);

    }
}
