using household_budget.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.DB_Configurations.Entity_Contexts;

public class FamilyDataContext : IEntityTypeConfiguration<Family>
{
    public void Configure(EntityTypeBuilder<Family> builder)
    {
        builder.ToTable("family");
    }
}
