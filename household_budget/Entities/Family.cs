using System;
using System.Collections.Generic;
using System.Text;

namespace household_budget.Entities;

public class Family{
    public int Id { get; private set; }

    public string Surname { get; private set; } = string.Empty;

    public static Family CreateFamily(int id, string surname)
    {
        return new Family
        {
            Id = id,
            Surname = surname
        };

    }

}

