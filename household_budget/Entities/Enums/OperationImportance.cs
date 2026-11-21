namespace household_budget.Entities.Enums
{
    [Flags]
    public enum OperationImportance
    {
        None = 0,
        Unwanted = 1,
        Unexpected = 2,
        Important = 4,
        Regular = 8,
        Necessary = 16

    }
}