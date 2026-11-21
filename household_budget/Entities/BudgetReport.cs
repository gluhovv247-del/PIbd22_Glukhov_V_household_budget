using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Entities;

public class BudgetReport
{

    public int Id { get; private set; }
    public decimal TotalIncome { get; private set; }

    public decimal TotalExpense { get; private set; }

    public decimal PlannedIncome { get; private set; }

    public decimal PlannedExpense { get; private set; }

    public DateTime CreateTime { get; private set; }

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
}
