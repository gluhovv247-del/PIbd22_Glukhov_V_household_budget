using household_budget.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Repositories.Implementations;

public class BudgetItemRepository : IBudgetItemRepository
{
    public void CreateBudgetItem(BudgetItem budgetItem)
    {
    }

    public void DeleteBudgetItem(int id)
    {
    }

    public BudgetItem ReadBudgetItemById(int id)
    {
        return BudgetItem.CreateBudgetItem(0, 0, 0, 0, 0);
    }

    public IEnumerable<BudgetItem> ReadBudgetItems(int? BudgetId = null, int? OperationCategoryId = null, int? FamilyMemberId = null)
    {
        return [];
    }

    public void UpdateBudgetItem(BudgetItem budgetItem)
    {
    }
}
