using household_budget.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.DB_Configurations.Entity_Contexts;

public class OperationCategoryDataContext : IEntityTypeConfiguration<OperationCategory>
{
    public void Configure(EntityTypeBuilder<OperationCategory> builder)
    {
        builder.ToTable("operation_categories");
    }

}
