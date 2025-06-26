  using System;

class Program
{
        public static void DisplayMenu()
    {
        Console.Clear();
        string choice = "";
        while (choice != "1" && choice != "2" && choice != "3" && choice != "4")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listening activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select an option from the menu: ");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing",
                    "This activity will help you relax by guiding you through slow, deep breaths.");
                    breathingActivity.Start();
                    breathingActivity.Run();
                    breathingActivity.End();
                    DisplayMenu();
                    break;
                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflectingActivity.Start();
                    reflectingActivity.Run();
                    reflectingActivity.End();
                    DisplayMenu();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    listingActivity.Start();
                    listingActivity.Run();
                    listingActivity.End();
                    DisplayMenu();
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
    
    static void Main(string[] args)
    {
        DisplayMenu();
    }

}
