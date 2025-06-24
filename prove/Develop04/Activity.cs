using System.Security.Cryptography.X509Certificates;

public class Activity
{
    private string _welcomeMessage;
    private string _description;
    private int _duration;
    private string _endMessage;
    private string _activityName;

    public Activity(string welcomeMessage, string description)
    {
        _welcomeMessage = welcomeMessage;
        _description = description;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public string GetWelcomeMessage()
    {
        return _welcomeMessage;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void Start()
    {
        Console.WriteLine(_welcomeMessage);
        Console.WriteLine(_description);
        Console.Write("Enter the duration in seconds: ");
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
        Console.WriteLine();
    }
        public static void spinner()
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
                Console.Write("   "); // Clear the spinner
                Console.Write("\b\b\b"); // Move back to the start of the spinner
            }

        }

    }
}