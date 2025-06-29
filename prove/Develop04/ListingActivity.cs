public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    public ListingActivity(string name, string description) : base(name, description)
    {
        _prompts.AddRange(new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        });
    }

    public override void Run()
    {


        Console.WriteLine("List as many responses as you can to the following prompt:\n");
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($" ---- {prompt} ----\n");

        // 5 second countdown
        for (int i = 5; i >= 0; i--)
        {
            Console.Write($"You may begin in: {i}");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        }

        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        // Example: loop for a certain duration (e.g., 30 seconds)
        while ((DateTime.Now - startTime).TotalSeconds < GetDuration())
        {
            Console.Write("> ");
            Console.ReadLine();
        }
    }
}