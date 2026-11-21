using household_budget.DB_Configurations;
using household_budget.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Repositories.Implementations;

public class FamilyMemberRepository : IFamilyMemberRepository
{
    private readonly DataContext _context;
    private readonly ILogger<IFamilyMemberRepository> _logger;

    public FamilyMemberRepository(
        ILogger<IFamilyMemberRepository> logger,
        DataContext context)
    {
        _logger = logger;
        _context = context;
    }

    public void CreateFamilyMember(FamilyMember family)
    {
        _logger.LogInformation("Добавление объекта");
        _logger.LogDebug("Объект: {json}",
            JsonConvert.SerializeObject(family));

        try
        {
            _context.FamilyMembers.Add(family);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении объекта");
            throw;
        }
    }

    public void DeleteFamilyMember(int id)
    {
        _logger.LogInformation("Удаление объекта");
        _logger.LogDebug("Объект с id: {id}", id);

        try
        {
            var familyMember = _context.FamilyMembers.Find(id);

            if (familyMember == null)
                return;

            _context.FamilyMembers.Remove(familyMember);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при удалении объекта");
            throw;
        }
    }

    public FamilyMember ReadFamilyMemberById(int id)
    {
        _logger.LogInformation("Поиск объекта");
        _logger.LogDebug("Объект с id: {id}", id);

        try
        {
            var familyMember = _context.FamilyMembers.Find(id);

            _logger.LogDebug("Найденный объект: {json}",
                JsonConvert.SerializeObject(familyMember));

            return familyMember;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при поиске объекта");
            throw;
        }
    }

    public IEnumerable<FamilyMember> ReadFamilyMembers()
    {
        _logger.LogInformation("Получение всех объектов");

        try
        {
            var familyMembers = _context.FamilyMembers
                .AsNoTracking()
                .ToList();

            _logger.LogDebug("Объект: {json}",
                JsonConvert.SerializeObject(familyMembers));

            return familyMembers;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при чтении объектов");
            throw;
        }
    }

    public void UpdateFamilyMember(FamilyMember family)
    {
        _logger.LogInformation("Редактирование объекта");
        _logger.LogDebug("Объект: {json}",
            JsonConvert.SerializeObject(family));

        try
        {
            var existingFamilyMember =
                _context.FamilyMembers.Find(family.Id);

            if (existingFamilyMember == null)
                return;

            existingFamilyMember.FirstName = family.FirstName;
            existingFamilyMember.BirthDate = family.BirthDate;
            existingFamilyMember.Role = family.Role;

            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при редактировании объекта");
            throw;
        }
    }
}

