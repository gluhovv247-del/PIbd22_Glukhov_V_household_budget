using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Entities;

public class OperationCategory
{

    public int Id { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public string Type { get; private set; } = string.Empty;

    public string? Description { get; private set; }

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
