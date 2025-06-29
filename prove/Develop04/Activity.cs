using System.Security.Cryptography.X509Certificates;

public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    private int _activityTimer;
    public abstract void Run();

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _activityTimer = 0;
    }
    public int GetActivityTimer()
    {
        return _activityTimer;
    }
    public void SetActivityTimer(int activityTimer)
    {
        _activityTimer = activityTimer;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        if (int.TryParse(Console.ReadLine(), out int duration) && duration > 0)
        {
            SetDuration(duration);
        }
        else
        {
            Console.WriteLine("Invalid duration. Please enter a positive integer.");
        }

        Console.Clear();
        Console.WriteLine("Get Ready...");
        spinner();
        Console.Clear();
    }

    public void End()
    {
        Console.WriteLine($"\nWell done!!\n\nYou have completed {_duration} seconds of the {_name} activity.");
        spinner();
    }

        public static void spinner(int times = 1)
    {
        for (int t = 0; t < times; t++)
        {
            int counter = 0;
            int sleepTime = 100;

        while (counter < 6)
        {

            Console.Write("|");
            Thread.Sleep(sleepTime);
            Console.Write("\b/");
            Thread.Sleep(sleepTime);
            Console.Write("\b-");
            Thread.Sleep(sleepTime);
            Console.Write("\b\\");
            Thread.Sleep(sleepTime);
            Console.Write("\b|");
            Thread.Sleep(sleepTime);
            Console.Write("\b/");
            Thread.Sleep(sleepTime);
            Console.Write("\b-");
            Thread.Sleep(sleepTime);
            Console.Write("\b\\");
            Thread.Sleep(sleepTime);
            Console.Write("\b*");
            Thread.Sleep(sleepTime);
            counter++;
            if (counter % 3 == 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("\b");
                    Console.Write(" ");
                    Console.Write("\b");

                    Thread.Sleep(sleepTime * 2);
                }
                Console.Write("   \b\b\b"); // Clear the spinner
                }
            }
            

        }

    }
}