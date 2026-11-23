using household_budget.DB_Configurations;
using household_budget.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Repositories.Implementations;

public class OperationCategoryRepository : IOperationCategoryRepository
{
    private readonly DataContext _context;
    private readonly ILogger<IOperationCategoryRepository> _logger;

    public OperationCategoryRepository(
        ILogger<IOperationCategoryRepository> logger,
        DataContext context)
    {
        _logger = logger;
        _context = context;
    }

    public void CreateOperationCategory(OperationCategory operationCategory)
    {
        _logger.LogInformation("Добавление объекта");
        _logger.LogDebug("Объект: {json}",
            JsonConvert.SerializeObject(operationCategory));

        try
        {
            _context.OperationCategories.Add(operationCategory);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении объекта");
            throw;
        }
    }

    public void DeleteOperationCategory(int id)
    {
        _logger.LogInformation("Удаление объекта");
        _logger.LogDebug("Объект с id: {id}", id);

        try
        {
            var operationCategory = _context.OperationCategories.Find(id);

            if (operationCategory == null)
            {
                throw new Exception("Категория не найдена");
            }

            var hasOperations = _context.Operations.Any(o => o.OperationCategoryId == id);
            var hasBudgetItems = _context.BudgetItems.Any(b => b.OperationCategoryId == id);
            if (hasOperations || hasBudgetItems)
            {
                throw new Exception("Категория не может быть удалена, пока ей принадлежат какие то операции или статьи бюджета");
            }

            _context.OperationCategories.Remove(operationCategory);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при удалении объекта");
            throw;
        }
    }

    public IEnumerable<OperationCategory> ReadOperationCategories()
    {
        _logger.LogInformation("Получение всех объектов");

        try
        {
            var operationCategories = _context.OperationCategories
                .AsNoTracking()
                .ToList();

            _logger.LogDebug("Объект: {json}",
                JsonConvert.SerializeObject(operationCategories));

            return operationCategories;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при чтении объектов");
            throw;
        }
    }

    public OperationCategory ReadOperationCategoryById(int id)
    {
        _logger.LogInformation("Поиск объекта");
        _logger.LogDebug("Объект с id: {id}", id);

        try
        {
            var operationCategory = _context.OperationCategories
                .Find(id);

            if (operationCategory == null)
            {
                throw new Exception("Категория не найдена");
            }

            _logger.LogDebug("Найденный объект: {json}",
                JsonConvert.SerializeObject(operationCategory));

            return operationCategory;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при поиске объекта");
            throw;
        }
    }

    public void UpdateOperationCategory(OperationCategory operationCategory)
    {
        _logger.LogInformation("Редактирование объекта");
        _logger.LogDebug("Объект: {json}",
            JsonConvert.SerializeObject(operationCategory));

        try
        {
            var existingOperationCategory = _context.OperationCategories
                .Find(operationCategory.Id);

            if (existingOperationCategory == null)
            {
                throw new Exception("Категория не найдена");
            }

            existingOperationCategory.Name = operationCategory.Name;
            existingOperationCategory.Description = operationCategory.Description;
            existingOperationCategory.Type = operationCategory.Type;

            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при редактировании объекта");
            throw;
        }
    }
}
