using household_budget.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Repositories;

public interface IBudgetRepository
{
    IEnumerable<Budget> ReadBudgets(
        DateTime? startDateFrom, DateTime? startDateTo,
        DateTime? endDateFrom, DateTime? endDateTo,
        int? familyId = null
        );
    void CreateBudget(Budget budget, List<BudgetItem> budgetItems);
    void DeleteBudget(int id);
}
