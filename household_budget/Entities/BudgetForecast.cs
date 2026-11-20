using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace household_budget.Entities;

public class BudgetForecast
{
    [Key]
    public int Id { get; private set; }

    [Column("start_date")]
    public DateTime StartDate { get; private set; }

    [Column("end_date")]
    public DateTime EndDate { get; private set; }

    [Column("projected_income")]
    public decimal ProjectedIncome { get; private set;  }

    [Column("projected_expense")]
    public decimal ProjectedExpense { get; private set; }

    [ForeignKey(nameof(Family))]
    [Column("family_id")]
    public int FamilyId { get; private set; }

    public static BudgetForecast CreateBudget(int id, DateTime startDate, DateTime endDate, decimal projectedIncome, decimal projectedExpense, int familyId)
    {
        return new BudgetForecast
        {
            Id = id,
            StartDate = startDate,
            EndDate = endDate,
            ProjectedIncome = projectedIncome,
            ProjectedExpense = projectedExpense,
            FamilyId = familyId
        };
    }

    public Family Family = null!;

}

