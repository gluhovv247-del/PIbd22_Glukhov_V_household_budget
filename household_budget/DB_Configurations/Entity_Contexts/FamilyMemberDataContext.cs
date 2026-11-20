using household_budget.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.DB_Configurations.Entity_Contexts;

public class FamilyMemberDataContext : IEntityTypeConfiguration<FamilyMember>
{
    public void Configure(EntityTypeBuilder<FamilyMember> builder)
    {
        builder.ToTable("family_members");

        builder.HasOne(fm => fm.Family)
              .WithMany(f => f.FamilyMembers)
              .HasForeignKey(fm => fm.FamilyId)
              .OnDelete(DeleteBehavior.Restrict);
    }
}
