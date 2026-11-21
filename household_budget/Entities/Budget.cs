using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Entities;

public class Budget
{
    public int Id { get; private set; }

    public DateTime StartDate { get; private set; }

    public DateTime EndDate { get; private set; }

    public int FamilyId { get; private set; }

    public static Budget CreateBudget(int id, DateTime startDate, DateTime endDate, int familyId)
    {
        return new Budget
        {
            Id = id,
            StartDate = startDate,
            EndDate = endDate,
            FamilyId = familyId
        };
    }
}
