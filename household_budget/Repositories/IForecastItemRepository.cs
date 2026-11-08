using household_budget.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Repositories;

public interface IForecastItemRepository
{
    IEnumerable<ForecastItem> ReadForecastItems(
        int? BudgetForecastId = null, int? FamilyMemberId = null,
        int? OperationCategoryId = null
        );
    void CreateForecastItem(ForecastItem forecastItems);
}
