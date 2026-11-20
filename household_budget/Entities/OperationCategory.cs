using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace household_budget.Entities;

public class OperationCategory
{
    [Key]
    public int Id { get; private set; }

    [Required]
    [Column("name")]
    public string Name { get; private set; } = string.Empty;

    [Column("type")]
    public string Type { get; private set; } = string.Empty;

    [Column("description")]
    public string? Description { get; private set; }
    public List<BudgetItem>? BudgetItems { get; internal set; }
    public List<Operation>? Operations { get; internal set; }

    public static OperationCategory CreateOperationCategory(int id, string name, string type, string? description)
    {
        return new OperationCategory {
            Id = id,
            Name = name,
            Type = type,
            Description = description
        };
    }
}
