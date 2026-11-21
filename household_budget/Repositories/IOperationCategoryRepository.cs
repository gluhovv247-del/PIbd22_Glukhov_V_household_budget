using household_budget.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Repositories;

public interface IOperationCategoryRepository
{
    IEnumerable<OperationCategory> ReadOperationCategories();
    OperationCategory ReadOperationCategoryById(int id);
    void CreateOperationCategory(OperationCategory operationCategory);
    void UpdateOperationCategory(OperationCategory operationCategory);
    void DeleteOperationCategory(int id);
}
