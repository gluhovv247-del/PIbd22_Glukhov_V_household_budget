using household_budget.DB_Configurations;
using household_budget.Entities;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Repositories.Implementations;

public class BudgetReportRepository : IBudgetReportRepository
{
    private readonly DataContext _context;

    private readonly ILogger<IBudgetReportRepository> _logger;

    public BudgetReportRepository(ILogger<IBudgetReportRepository> logger, DataContext context)
    {
        _logger = logger;
        _context = context;
    }

    public void CreateBudgetReport(BudgetReport budgetReport)
    {
        _logger.LogInformation("Добавление объекта");
        _logger.LogDebug("Объект: {json}",
            JsonConvert.SerializeObject(budgetReport));
        try
        {
            _context.BudgetReports.Add(budgetReport);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении объекта");
            throw;
        }
    }

    public IEnumerable<BudgetReport> ReadBudgetReports(DateTime? dateFrom, DateTime? dateTo, int? budgetId = null)
    {
        _logger.LogInformation("Получение всех объектов");
        try
        {
            var reports = _context.BudgetReports.ToList();
            _logger.LogDebug("Объект: {json}",
            JsonConvert.SerializeObject(reports));
            return reports;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при чтении объектов");
            throw;
        }
    }
}
