using household_budget.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Repositories.Implementations;

public class FamilyRepository : IFamilyRepository
{
    public void CreateFamily(Family family)
    {
    }

    public void DeleteFamily(int id)
    {
    }

    public IEnumerable<Family> ReadFamilies()
    {
        return [];
    }

    public Family ReadFamilyById(int id)
    {
        return Family.CreateFamily(0, string.Empty);
    }

    public void UpdateFamily(Family family)
    {
    }
}
