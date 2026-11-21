using household_budget.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Repositories;

public interface IOperationRepository
{
    IEnumerable<Operation> ReadOperations(
        DateTime? dateFrom, DateTime? dateTo,
        int? operationCategoryId = null, int? familyMemberId = null
        );
    void CreateOperation(Operation family);
    void DeleteOperation(int id);
}
