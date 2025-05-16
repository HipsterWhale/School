using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
    string response = "0";

    List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    Random rnd = new();

    void GetRandomPrompt()
    {
        int index = rnd.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
    }

    while (response != "5")
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            response = Console.ReadLine();
            switch (response)
            {
                case "1":
                    GetRandomPrompt();
                    break;

                case "2":
                    break;
                
                case "3":
                    break;

                case "4":
                    break;
                
                case "5":
                    Console.Write("Goodbye.");
                    break;

                default:
                    Console.Write($"You entered: {response}. Please enter a value 1-5.");
                    break;

            }
        }

    }
}