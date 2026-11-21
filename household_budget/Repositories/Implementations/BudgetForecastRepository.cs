using household_budget.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Repositories.Implementations;

public class BudgetForecastRepository : IBudgetForecastRepository
{

    public void CreateBudgetForecast(BudgetForecast budgetForecast)
    {
    }

    public IEnumerable<BudgetForecast> ReadBudgetForecasts(DateTime? startDateFrom, DateTime? startDateTo, DateTime? endDateFrom, DateTime? endDateTo, int? familyId = null)
    {
        return [];
    }
}