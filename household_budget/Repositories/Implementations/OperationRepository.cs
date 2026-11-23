using household_budget.DB_Configurations;
using household_budget.Entities;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Repositories.Implementations;

public class OperationRepository : IOperationRepository
{
    private readonly DataContext _context;
    private readonly ILogger<OperationRepository> _logger;

    public OperationRepository(
        DataContext context,
        ILogger<OperationRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void CreateOperation(Operation operation)
    {
        _logger.LogInformation("Добавление объекта");
        _logger.LogDebug("Объект: {json}",
            JsonConvert.SerializeObject(operation));
        try
        {
            _context.Operations.Add(operation);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении объекта");
            throw;
        }
    }

    public void DeleteOperation(int id)
    {
        try
        {
            var operation = _context.Operations.Find(id);

            if (operation == null)
            {
                throw new Exception("Операция не найдена");
            }

            _context.Operations.Remove(operation);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(
                ex,
                "Ошибка при удалении объекта");
            throw;
        }
    }

    public IEnumerable<Operation> ReadOperations(
        DateTime? dateFrom,
        DateTime? dateTo,
        int? operationCategoryId = null,
        int? familyMemberId = null)
    {
        _logger.LogInformation("Получение всех объектов");
        try
        {
            var operations = _context.Operations.ToList();
            _logger.LogDebug("Объект: {json}",
            JsonConvert.SerializeObject(operations));
            return operations;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при чтении записей");
            throw;
        }
    }
}
