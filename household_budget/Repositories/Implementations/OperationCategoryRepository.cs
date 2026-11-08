using household_budget.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Repositories.Implementations;

public class OperationCategoryRepository : IOperationCategoryRepository
{
    public void CreateOperationCategory(OperationCategory operationCategory)
    {
    }

    public void DeleteOperationCategory(int id)
    {
    }

    public IEnumerable<OperationCategory> ReadOperationCategories()
    {
        return [];
    }

    public OperationCategory ReadOperationCategoryById(int id)
    {
        return OperationCategory.CreateOperationCategory(0, string.Empty, string.Empty, string.Empty);
    }

    public void UpdateOperationCategory(OperationCategory operationCategory)
    {
    }
}
