using household_budget.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Repositories;

public interface IFamilyMemberRepository
{
    IEnumerable<FamilyMember> ReadFamilyMembers();
    FamilyMember ReadFamilyMemberById(int id);
    void CreateFamilyMember(FamilyMember family);
    void UpdateFamilyMember(FamilyMember family);
    void DeleteFamilyMember(int id);
}
