using household_budget.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Repositories.Implementations;

public class BudgetReportRepository : IBudgetReportRepository
{
    public void CreateBudgetReport(BudgetReport budgetReport)
    {
    }

    public IEnumerable<BudgetReport> ReadBudgetReports(DateTime? dateFrom, DateTime? dateTo, int? budgetId = null)
    {
        return [];
    }
}
