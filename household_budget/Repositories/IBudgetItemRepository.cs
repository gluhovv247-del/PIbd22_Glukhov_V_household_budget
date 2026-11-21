using household_budget.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Repositories;

public interface IBudgetItemRepository
{
    IEnumerable<BudgetItem> ReadBudgetItems(
        int? BudgetId = null, int? OperationCategoryId = null,
        int? FamilyMemberId = null
        );
    BudgetItem ReadBudgetItemById (int id);
    void CreateBudgetItem(BudgetItem budgetItem);
    void UpdateBudgetItem(BudgetItem budgetItem);
    void DeleteBudgetItem(int id);
}
