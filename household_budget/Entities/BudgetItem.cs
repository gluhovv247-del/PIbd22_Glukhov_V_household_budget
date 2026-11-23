using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Entities;

public class BudgetItem
{

    public int Id { get; private set; }

    public decimal PlannedAmount { get; private set; }

    public int BudgetId { get; private set; }

    public int OperationCategoryId { get; private set; }

    public int FamilyMemberId { get; private set; }

    public static BudgetItem CreateBudgetItem(int id, decimal plannedAmount, int budgetId, int operationCategoryId, int familyMemberId)
    {
        return new BudgetItem
        {
            Id = id,
            PlannedAmount = plannedAmount,
            BudgetId = budgetId,
            OperationCategoryId = operationCategoryId,
            FamilyMemberId = familyMemberId
        };
    }

}
