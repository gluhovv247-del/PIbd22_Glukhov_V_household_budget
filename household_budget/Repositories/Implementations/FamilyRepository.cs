using household_budget.DB_Configurations;
using household_budget.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Repositories.Implementations;

public class FamilyRepository : IFamilyRepository
{
    private readonly DataContext _context;

    private readonly ILogger<IFamilyRepository> _logger;

    public FamilyRepository(ILogger<IFamilyRepository> logger, DataContext context)
    {
        _logger = logger;
        _context = context;
    }

    public void CreateFamily(Family family)
    {
        _logger.LogInformation("Добавление объекта");
        _logger.LogDebug("Объект: {json}",
            JsonConvert.SerializeObject(family));
        try
        {
            _context.Families.Add(family);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении объекта");
            throw;
        }
    }

    public void DeleteFamily(int id)
    {
        _logger.LogInformation("Удаление объекта");
        _logger.LogDebug("Объект с id: {id}", id);
        
        try
        {
            var family = _context.Families.Find(id);
            _context.Families.Remove(family);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при удалении объекта");
            throw;
        }
    }

    public IEnumerable<Family> ReadFamilies()
    {
        _logger.LogInformation("Получение всех объектов");
        try
        {
            var families = _context.Families.AsNoTracking().ToList();
            _logger.LogDebug("Объект: {json}",
            JsonConvert.SerializeObject(families));
            return families;
        }
        catch(Exception ex)
        {
            _logger.LogError(ex, "Ошибка при чтении объектов");
            throw;
        }

    }

    public Family ReadFamilyById(int id)
    {
        _logger.LogInformation("Поиск объекта");
        _logger.LogDebug("Объект с id: {id}", id);
        try
        {
            var family = _context.Families.Find(id);
            _logger.LogDebug("Найденный объект: {json}",
                JsonConvert.SerializeObject(family));
            return family;
        }
        catch (Exception ex) 
        {
            _logger.LogError(ex, "Ошибка при поиске объекта");
            throw;
        }
    }

    public void UpdateFamily(Family family)
    {
        _logger.LogInformation("Редактирование объекта");
        _logger.LogDebug("Объект: {json}",
            JsonConvert.SerializeObject(family));
        try
        {
            var existingFamily = _context.Families.Find(family.Id);
            existingFamily.Surname = family.Surname;
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при редактировании объекта");
            throw;
        }
    }
}
