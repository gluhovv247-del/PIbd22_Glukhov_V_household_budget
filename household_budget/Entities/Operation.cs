using household_budget.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace household_budget.Entities;

public class Operation
{

    [Key]
    public int Id { get; private set; }

    [Column("create_time")]
    public DateTime CreateTime { get; private set; }

    [ForeignKey(nameof(OperationCategory))]
    public int OperationCategoryId { get; private set; }

    [Column("importance")]
    public OperationImportance Importance { get; private set; }

    [ForeignKey(nameof(FamilyMember))]
    public int FamilyMemberId { get; private set; }

    public static Operation CreateOperation(int id, DateTime createTime, int operationCategoryId, OperationImportance importance, int familyMemberId)
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

    public OperationCategory OperationCategory = null!;

    public FamilyMember FamilyMember = null!;
}
