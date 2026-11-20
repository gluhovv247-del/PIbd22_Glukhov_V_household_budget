using household_budget.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.DB_Configurations.Entity_Contexts;

public class OperationDataContext : IEntityTypeConfiguration<Operation>
{
    public void Configure(EntityTypeBuilder<Operation> builder)
    {
        builder.ToTable("operations");

        builder.HasOne(o => o.OperationCategory)
              .WithMany(oc => oc.Operations)
              .HasForeignKey(o => o.OperationCategoryId)
              .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(o => o.FamilyMember)
              .WithMany(f => f.Operations)
              .HasForeignKey(o => o.FamilyMemberId)
              .OnDelete(DeleteBehavior.Restrict);
    }

}
