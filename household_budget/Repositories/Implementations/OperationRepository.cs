using household_budget.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Repositories.Implementations;

public class OperationRepository : IOperationRepository
{
    public void CreateOperation(Operation family)
    {
    }

    public void DeleteOperation(int id)
    {
    }

    public IEnumerable<Operation> ReadOperations(DateTime? dateFrom, DateTime? dateTo, int? operationCategoryId = null, int? familyMemberId = null)
    {
        return [];
    }
}
