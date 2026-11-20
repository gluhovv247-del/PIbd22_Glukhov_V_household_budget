using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace household_budget.Entities;

public class BudgetItem
{
    [Key]
    public int Id { get; private set; }

    [Column("planned_amount")]
    public decimal PlannedAmount { get; private set; }

    [ForeignKey(nameof(Budget))]
    [Column("budget_id")]
    public int BudgetId { get; private set; }

    [ForeignKey(nameof(OperationCategory))]
    [Column("operation_category_id")]
    public int OperationCategoryId { get; private set; }

    [ForeignKey(nameof(FamilyMember))]
    [Column("family_member_id")]
    public int FamilyMemberId { get; private set; }

    public static BudgetItem CreateBudgetItem(int id, decimal plannedAmount, int budgetId, int operationCategoryId, int familyMemberId)
    {
        return new BudgetItem
        {
            Id = id,
            PlannedAmount = plannedAmount,
            BudgetId = budgetId,
            OperationCategoryId = operationCategoryId,
            FamilyMemberId = familyMemberId
        };
    }

    public FamilyMember FamilyMember = null!;

    public OperationCategory OperationCategory = null!;

    public Budget Budget = null!;

}
