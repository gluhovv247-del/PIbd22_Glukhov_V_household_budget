using household_budget.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Entities;

public class Operation
{

    public int Id { get; private set; }

    public DateTime CreateTime { get; private set; }

    public int OperationCategoryId { get; private set; }

    public OperationImportance Importance { get; private set; }

    public int FamilyMemberId { get; private set; }

    public Operation CreateOperation(int id, DateTime createTime, int operationCategoryId, OperationImportance importance, int familyMemberId)
    {
        return new Operation
        {
            Id = id,
            CreateTime = createTime,
            OperationCategoryId = operationCategoryId,
            Importance = importance,
            FamilyMemberId = familyMemberId
        };
    }
}
