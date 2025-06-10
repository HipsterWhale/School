  using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMenu(); // Call the method from Main
    }

    static void DisplayMenu()
    {
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
                    // Call method for breathing activity
                    break;
                case "2":
                    // Call method for reflecting activity
                    break;
                case "3":
                    // Call method for listening activity
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
}
