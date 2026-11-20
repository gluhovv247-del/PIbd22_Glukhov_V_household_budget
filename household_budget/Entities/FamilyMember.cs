using household_budget.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace household_budget.Entities;

public class FamilyMember
{
    [Key]
    public int Id { get; private set; }

    [Column("first_name")]
    [MaxLength(50)]
    [Required]
    public string FirstName { get; private set; } = string.Empty;

    [ForeignKey(nameof(Family))]
    public int FamilyId { get; private set; }

    [Column("birth_date")]
    public DateTime BirthDate { get; private set; }

    [Column("role")]
    public FamilyRole Role { get; private set; }
    public List<BudgetItem>? BudgetItems { get; internal set; }
    public List<Operation>? Operations { get; internal set; }

    public static FamilyMember CreateFamilyMember(int id, string firstName, int familyId, DateTime birthDate, FamilyRole role)
    {
        return new FamilyMember
        {
            Id = id,
            FirstName = firstName,
            FamilyId = familyId,
            BirthDate = birthDate,
            Role = role
        };
    }

    public Family Family = null!;

}
