using household_budget.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Repositories.Implementations;

public class BudgetRepository : IBudgetRepository
{
    public void CreateBudget(Budget budget)
    {
    }

    public void DeleteBudget(int id)
    {
    }

    public Budget ReadBudgetById(int id)
    {
        return Budget.CreateBudget(0, new DateTime(), new DateTime(), 0);
    }

    public IEnumerable<Budget> ReadBudgets(DateTime? startDateFrom, DateTime? startDateTo, DateTime? endDateFrom, DateTime? endDateTo, int? familyId = null)
    {
        return [];
    }
}
