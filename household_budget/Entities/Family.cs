using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace household_budget.Entities;

public class Family{
    [Key]
    public int Id { get; private set; }

    [Column("surname")]
    [Required]
    [MaxLength(50)]
    public string Surname { get; private set; } = string.Empty;
    public List<Budget>? Budgets { get; private set; }
    public List<BudgetForecast>? BudgetForecasts { get; internal set; }
    public List<FamilyMember>? FamilyMembers { get; internal set; }

    public static Family CreateFamily(int id, string surname)
    {
        return new Family
        {
            Id = id,
            Surname = surname
        };

    }

}

