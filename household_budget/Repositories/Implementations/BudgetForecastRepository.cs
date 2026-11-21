using household_budget.DB_Configurations;
using household_budget.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Repositories.Implementations;

public class BudgetForecastRepository : IBudgetForecastRepository
{
    private readonly DataContext _context;

    private readonly ILogger<IBudgetForecastRepository> _logger;

    public BudgetForecastRepository(DataContext context, ILogger<IBudgetForecastRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void CreateBudgetForecast(BudgetForecast budgetForecast)
    {
        _logger.LogInformation("Добавление объекта");
        _logger.LogDebug("Объект: {json}",
            JsonConvert.SerializeObject(budgetForecast));
        try
        {
            _context.BudgetForecasts.Add(budgetForecast);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении объекта");
            throw;
        }
    }

    public IEnumerable<BudgetForecast> ReadBudgetForecasts(DateTime? startDateFrom, DateTime? startDateTo, DateTime? endDateFrom, DateTime? endDateTo, int? familyId = null)
    {
        _logger.LogInformation("Получение всех объектов");
        try
        {
            var forecasts = _context.BudgetForecasts.ToList();
            _logger.LogDebug("Объект: {json}",
            JsonConvert.SerializeObject(forecasts));
            return forecasts;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при чтении объектов");
            throw;
        }
    }
}