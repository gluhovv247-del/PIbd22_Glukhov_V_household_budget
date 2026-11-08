using household_budget.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Repositories.Implementations;

public class ForecastItemRepository : IForecastItemRepository
{

    public void CreateForecastItem(ForecastItem forecastItems)
    {
    }

    public IEnumerable<ForecastItem> ReadForecastItems(int? BudgetForecastId = null, int? FamilyMemberId = null, int? OperationCategoryId = null)
    {
        return [];
    }

}
