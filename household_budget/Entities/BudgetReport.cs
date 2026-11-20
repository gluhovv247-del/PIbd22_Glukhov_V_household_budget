using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace household_budget.Entities;

public class BudgetReport
{
    [Key]
    public int Id { get; private set; }

    [Column("planned_income")]
    public decimal TotalIncome { get; private set; }

    [Column("total_expense")]
    public decimal TotalExpense { get; private set; }

    [Column("planned_income")]
    public decimal PlannedIncome { get; private set; }

    [Column("planned_expense")]
    public decimal PlannedExpense { get; private set; }

    [Column("create_time")]
    public DateTime CreateTime { get; private set; }

    [ForeignKey(nameof(Budget))]
    public int BudgetId {  get; private set; }

    public static BudgetReport CreateBudgetReport(int id, decimal totalIncome, decimal totalExpense, decimal plannedIncome, decimal plannedExpense, DateTime createTime, int budgetId)
    {
        return new BudgetReport
        {
            Id = id,
            TotalIncome = totalIncome,
            TotalExpense = totalExpense,
            PlannedIncome = plannedIncome,
            PlannedExpense = plannedExpense,
            CreateTime = createTime,
            BudgetId = budgetId,
        };
    }
    public Budget Budget = null!;

}
