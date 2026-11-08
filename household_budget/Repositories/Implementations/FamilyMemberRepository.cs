using household_budget.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Repositories.Implementations;

public class FamilyMemberRepository : IFamilyMemberRepository
{
    public void CreateFamilyMember(FamilyMember family)
    {
    }

    public void DeleteFamilyMember(int id)
    {
    }

    public FamilyMember ReadFamilyMemberById(int id)
    {
        return FamilyMember.CreateFamilyMember(0, string.Empty, 0, DateTime.Now, 0, 0);
    }

    public IEnumerable<FamilyMember> ReadFamilyMembers()
    {
        return [];
    }

    public void UpdateFamilyMember(FamilyMember family)
    {
    }
}
