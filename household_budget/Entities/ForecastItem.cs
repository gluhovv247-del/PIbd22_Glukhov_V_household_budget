using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Entities;

public class ForecastItem
{

    public int Id { get; private set; }

    public decimal Amount { get; private set; }

    public int BudgetForecastId { get; private set; }

    public int FamilyMemberId { get; private set; }

    public int OperationCategoryId { get; private set; }

    public static ForecastItem CreateForecastItem(int id, decimal amount, int budgetForecastId, int familyMemberId, int operationCategoryId)
    {
        return new ForecastItem
        {
            Id = id,
            Amount = amount,
            BudgetForecastId = budgetForecastId,
            FamilyMemberId = familyMemberId,
            OperationCategoryId = operationCategoryId
        };
    }
}
