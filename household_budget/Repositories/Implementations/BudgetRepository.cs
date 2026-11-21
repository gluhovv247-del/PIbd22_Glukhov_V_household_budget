using household_budget.DB_Configurations;
using household_budget.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace household_budget.Repositories.Implementations;

public class BudgetRepository : IBudgetRepository
{
    private readonly DataContext _context;

    private readonly ILogger<IBudgetRepository> _logger;


    public BudgetRepository(ILogger<IBudgetRepository> logger, DataContext context)
    {
        _logger = logger;
        _context = context;
    }

    public void CreateBudget(Budget budget, List<BudgetItem> budgetItems)
    {
        _logger.LogInformation("Добавление объекта");
        _logger.LogDebug("Объект: {json}",
            JsonConvert.SerializeObject(budget));
        _logger.LogDebug("Статьи бюджета: {json}",
            JsonConvert.SerializeObject(budgetItems));
        using var transaction = _context.Database.BeginTransaction();
        try
        {
            _context.Budgets.Add(budget);
            _context.SaveChanges();

            foreach (var budgetItem in budgetItems)
            {
                budgetItem.BudgetId = budget.Id;
            }

            _context.BudgetItems.AddRange(budgetItems);
            _context.SaveChanges();

            transaction.Commit();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении объекта");
            transaction.Rollback();
            throw;
        }
    }

    public void DeleteBudget(int id)
    {
        _logger.LogInformation("Удаление объекта");
        _logger.LogDebug("Объект с id: {id}", id);

        try
        {
            var budget = _context.Budgets.Find(id);
            _context.Budgets.Remove(budget);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при удалении объекта");
            throw;
        }
    }

    public IEnumerable<Budget> ReadBudgets(DateTime? startDateFrom, DateTime? startDateTo, DateTime? endDateFrom, DateTime? endDateTo, int? familyId = null)
    {
        _logger.LogInformation("Получение всех объектов");
        try
        {
            var budgets = _context.Budgets.AsNoTracking().ToList();
            _logger.LogDebug("Объект: {json}",
            JsonConvert.SerializeObject(budgets));
            return budgets;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при чтении объектов");
            throw;
        }
    }
}