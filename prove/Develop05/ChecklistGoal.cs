class ChecklistGoal : Goal
{
    private int _bonusPoints { get; set; }
    private int _occurencesForBonusPoints { get; set; }
    private int _completions { get; set; }
    public ChecklistGoal(string name, string description, int points, int occurencesForBonusPoints, int bonusPoints, int completions, bool isComplete)
        : base(name, description, points, isComplete)
    {
        SetPoints(points);
        SetName(name);
        SetDescription(description);
        _occurencesForBonusPoints = occurencesForBonusPoints;
        _bonusPoints = bonusPoints;
        _completions = completions;
        SetComplete(isComplete);
    }

    public override void Display()
    {
        Console.WriteLine($"Checklist Goal: {GetName()} - {GetDescription()} (Points: {GetPoints()}) -- Currently completed: {_completions}/{_occurencesForBonusPoints}");
    }

     public override string FormatForSave()
    {
        return ($"checklist#{GetComplete()}#{GetName()}#{GetDescription()}#{GetPoints()}#{_completions}#{_occurencesForBonusPoints}#{_bonusPoints}");
    }


}