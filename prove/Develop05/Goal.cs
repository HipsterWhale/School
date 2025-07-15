using System.Runtime.CompilerServices;

class Goal
{
    private string _name { get; set; }
    private string _description { get; set; }
    private int _points { get; set; }
    private bool _isComplete { get; set; }

    public Goal(string name, string description, int points, bool isComplete)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }

    public void SetName(string name)
    { _name = name; }
    public void SetDescription(string description)
    { _description = description; }
    public void SetPoints(int points)
    { _points = points; }
    public void SetComplete(bool complete)
    {_isComplete = complete; }

    public string GetName()
    { return _name; }
    public string GetDescription()
    { return _description; }
    public int GetPoints()
    { return _points; }
    public bool GetComplete()
    { return _isComplete; }
    
    public static Goal NewGoal()
    {

        List<string> goalTypes = new List<string> { "simple", "eternal", "list" };

        Console.WriteLine("The types of goals are:");
        foreach (var goal in goalTypes)
        {
            Console.WriteLine($" {goal}");
        }
        Console.WriteLine("Which type of goal would you like to create? ");
        string type = Console.ReadLine().ToLower().Trim();
        if (!goalTypes.Contains(type))
        {
            Console.WriteLine("Invalid goal type.");
            return NewGoal();
        }

        Console.WriteLine("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.WriteLine("Write a short description of your goal ");
        string description = Console.ReadLine();
        Console.WriteLine("How many points is completion of this goal worth? ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "simple":

                return new Goal(name, description, points, false);

            case "list":

                Console.WriteLine("How many times does this goal need to be accomplised for a bonus? ");
                int occurencesForBonusPoints = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the bonus for accompishing it that many times? ");
                int bonusPoints = int.Parse(Console.ReadLine());

                return new ChecklistGoal(name, description, points, occurencesForBonusPoints, bonusPoints, 0, false);

            case "eternal":

                return new EternalGoal(name, description, points);

            default:
                return null;

        }

    }
    public virtual string FormatForSave()
    {
        return ($"simple#{_isComplete}#{_name}#{_description}#{_points}");
    }
    public virtual void Display()
    {
        Console.WriteLine($"Goal: {_name} - {_description} (Points: {_points})");
    }
    
}