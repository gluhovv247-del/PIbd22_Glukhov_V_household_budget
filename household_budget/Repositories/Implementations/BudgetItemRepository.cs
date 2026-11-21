using household_budget.DB_Configurations;
using household_budget.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Repositories.Implementations;

public class BudgetItemRepository : IBudgetItemRepository
{
    private readonly DataContext _context;

    private readonly ILogger<IBudgetItemRepository> _logger;

    public BudgetItemRepository(ILogger<IBudgetItemRepository> logger, DataContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IEnumerable<BudgetItem> ReadBudgetItems(int? BudgetId = null, int? OperationCategoryId = null, int? FamilyMemberId = null)
    {
        _logger.LogInformation("Получение всех объектов");
        
        try
        {
            var budgetItems = _context.BudgetItems.AsNoTracking().ToList();
            _logger.LogDebug("Объект: {json}",
            JsonConvert.SerializeObject(budgetItems));
            return budgetItems;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при чтении объектов");
            throw;
        }
    }
}