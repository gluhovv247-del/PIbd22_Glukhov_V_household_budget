using household_budget.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.DB_Configurations.Entity_Contexts
{
    internal class BudgetItemDataContext : IEntityTypeConfiguration<BudgetItem>
{
    public void Configure(EntityTypeBuilder<BudgetItem> builder)
    {
        builder.ToTable("budget_items");

        builder.HasOne(b => b.FamilyMember)
              .WithMany(f => f.BudgetItems)
              .HasForeignKey(b => b.FamilyMemberId)
              .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(b => b.OperationCategory)
              .WithMany(o => o.BudgetItems)
              .HasForeignKey(b => b.OperationCategoryId)
              .OnDelete(DeleteBehavior.Restrict);

       builder.HasOne(bi => bi.Budget)
               .WithMany(b => b.BudgetItems)
               .HasForeignKey(bi => bi.BudgetId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    
    }
}
