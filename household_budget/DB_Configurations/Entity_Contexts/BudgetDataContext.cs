using household_budget.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using static Unity.Storage.RegistrationSet;

namespace household_budget.DB_Configurations.Entity_Contexts;

public class BudgetDataContext : IEntityTypeConfiguration<Budget>
{
    public void Configure(EntityTypeBuilder<Budget> builder)
    {
        builder.ToTable(t =>
        {
            t.HasCheckConstraint(
                "CK_Budget_EndDate_After_StartDate",
                "\"end_date\" > \"start_date\""
            );
        });

        builder.HasOne(b => b.Family)
              .WithMany(f => f.Budgets)     
              .HasForeignKey(b => b.FamilyId)
              .OnDelete(DeleteBehavior.Cascade);

    }
}
