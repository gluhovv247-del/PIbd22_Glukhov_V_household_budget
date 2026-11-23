using household_budget.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Repositories.Implementations;

public class BudgetItemRepository : IBudgetItemRepository
{
    public IEnumerable<BudgetItem> ReadBudgetItems(int? BudgetId = null, int? OperationCategoryId = null, int? FamilyMemberId = null)
    {
        return [];
    }
}
