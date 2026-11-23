using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace household_budget.Entities;

public class Budget
{
    [Key]
    public int Id { get; private set; }

    [Column("start_date")]
    public DateTime StartDate { get; private set; }

    [Column("end_date")]
    public DateTime EndDate { get; private set; }

    [ForeignKey(nameof(Family))]
    [Column("family_id")]
    public int FamilyId { get; private set; }

    public static Budget CreateBudget(int id, DateTime startDate, DateTime endDate, int familyId)
    {
        return new Budget
        {
            Id = id,
            StartDate = startDate,
            EndDate = endDate,
            FamilyId = familyId
        };
    }

    public Family Family { get; private set; } = null!;
    public List<BudgetItem>? BudgetItems { get; internal set; }
    public List<BudgetReport>? BudgetReports { get; internal set; }
}
