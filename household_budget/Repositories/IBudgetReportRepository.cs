using household_budget.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Repositories;

public interface IBudgetReportRepository
{
    IEnumerable<BudgetReport> ReadBudgetReports(
        DateTime? dateFrom, DateTime? dateTo,
        int? budgetId = null
        );
    void CreateBudgetReport(BudgetReport budgetReport);
}
