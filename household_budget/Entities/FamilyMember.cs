using household_budget.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Entities;

public class FamilyMember
{

    public int Id { get; private set; }

    public string FirstName { get; private set; } = string.Empty;

    public int FamilyId { get; private set; }

    public DateTime BirthDate { get; private set; }

    public int BudgetItemId { get; private set; }

    public FamilyRole Role { get; private set; }

    public static FamilyMember CreateFamilyMember(int id, string firstName, int familyId, DateTime birthDate, int budgetItemId, FamilyRole role)
    {
        return new FamilyMember
        {
            Id = id,
            FirstName = firstName,
            FamilyId = familyId,
            BirthDate = birthDate,
            BudgetItemId = budgetItemId,
            Role = role
        };
    }
}
