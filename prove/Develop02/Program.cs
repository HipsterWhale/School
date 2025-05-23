using System;
using System.ComponentModel.DataAnnotations;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
    string response = "0";

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
                    Entry entry = new Entry();
                    break;

                case "2":
                    DisplayJournal();
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