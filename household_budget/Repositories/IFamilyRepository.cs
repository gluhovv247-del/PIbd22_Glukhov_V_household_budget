using household_budget.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Repositories;

public interface IFamilyRepository
{
    IEnumerable<Family> ReadFamilies();
    Family ReadFamilyById(int id);
    void CreateFamily(Family family);
    void UpdateFamily(Family family);
    void DeleteFamily(int id);
}
