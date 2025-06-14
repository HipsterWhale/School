class Program

{
    static void Main(string[] args)
    {
        Scripture scripture1 = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        Scripture scripture2 = new Scripture("Proverbs 3:5-6", "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Welcome to the Scripture Memorization App!");
        Console.WriteLine("This app will help you memorize scripture by hiding words.");

        Console.WriteLine("\nChoose a scripture to memorize:");
        scripture1.Print();
        scripture2.Print();
        Console.WriteLine("\nType '1' for John 3:16 or '2' for Proverbs 3:5-6 to select a scripture.");
        string choice = Console.ReadLine();

        Scripture activeScripture;
        if (choice == "1")
        {
            activeScripture = scripture1;
        }
        else if (choice == "2")
        {
            activeScripture = scripture2;
        }
        else
        {
            Console.WriteLine("Invalid choice. Defaulting to John 3:16.");
            activeScripture = scripture1;
        }


        Console.Clear();

        Console.WriteLine("Press Enter to hide words, or type 'exit' to quit.");
        activeScripture.Print();
        while (true)
        {
            string input = Console.ReadLine();

            if (input == "")
            {
                Console.Clear();
                activeScripture.Hide_words(3);
                activeScripture.Print();
                Console.WriteLine("\nPress Enter to hide more words, or type 'exit' to quit.");
            }
            else if (input.ToLower() == "exit")
            {
                Console.WriteLine("Thank you for using the Scripture Memorization App. Goodbye!");
                break;
            }

            if (activeScripture.AllWordsHidden())
            {
                Console.WriteLine("Congratulations! You have hidden all the words.");
                Console.WriteLine("Type 'exit' to quit.");
                input = Console.ReadLine();
                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("Thank you for using the Scripture Memorization App. Goodbye!");
                    break;
                }
            }
        }




    }
}