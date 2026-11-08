using household_budget.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Repositories;

public interface IBudgetForecastRepository
{
    IEnumerable<BudgetForecast> ReadBudgetForecasts(
        DateTime? startDateFrom, DateTime? startDateTo,
        DateTime? endDateFrom, DateTime? endDateTo,
        int? familyId = null
        );
    void CreateBudgetForecast(BudgetForecast budgetForecast);
}
