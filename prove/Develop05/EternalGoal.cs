class EternalGoal : Goal
{
    private int bonusPoints;
    private int occurrencesToBonus;
    private int completions;
    public EternalGoal(string name, string description, int points) : base(name, description, points, false)
    {
        SetName(name);
        SetDescription(description);
        SetPoints(points);
        SetComplete(false);
    }
     public override string FormatForSave()
    {
        return ($"eternal#{GetName()}#{GetDescription}#{GetPoints}");
    }
}