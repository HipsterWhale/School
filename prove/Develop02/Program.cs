using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.IO;

class Program
{

    // These 2 methods are used to simulate typing text with a random delay
    public static void Type(string text = "")
    {
        Random sleepTime = new Random();
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(sleepTime.Next(20, 80));
        }
    }
    public static void TypeLine(string text = "")
    {
        Random sleepTime = new Random();
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(sleepTime.Next(20, 80));
        }
        Console.WriteLine(); // Move to the next line after typing the text
    }

    private static string GetRandomPrompt()
    {
        string[] prompts = {
            "What was the best part of your day?",
            "What are you grateful for today?",
            "Describe a challenge you faced and how you overcame it.",
            "What is something new you learned today?",
            "What are your goals for tomorrow?"
        };
        Random random = new Random();
        return prompts[random.Next(prompts.Length)];
    }
    static void Main(string[] args)
    {
        Console.Clear();
        TypeLine("Welcome to the Journal Program!");
        string response = "0";
        Journal journal = new Journal();
        while (response != "5")
        {
            TypeLine("Please select one of the following choices");
            TypeLine("1. Write");
            TypeLine("2. Display");
            TypeLine("3. Load");
            TypeLine("4. Save");
            TypeLine("5. Quit");
            TypeLine("What would you like to do? ");

            response = Console.ReadLine();
            switch (response)
            {
                case "1":
                    Entry entry = new Entry(GetRandomPrompt());
                    journal.AddEntry(entry);
                    break;
                case "2":
                    journal.DisplayJournal();
                    break;

                case "3":
                    Type("Enter a filename to load your journal: ");
                    string loadFilename = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(loadFilename);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 3)
                        {
                            DateTime date = DateTime.Parse(parts[0]);
                            string prompt = parts[1];
                            string responseText = parts[2];
                            Entry loadedEntry = new Entry(prompt, responseText);;
                            journal.AddEntry(loadedEntry);
                        }
                        else
                        {
                            TypeLine($"Invalid entry format: {line}");
                        }
                    }
                    break;

                case "4":
                    Type("Enter a filename to save your journal: ");
                    string filename = Console.ReadLine();
                    try
                    {
                        journal.SaveToFile(filename);
                        TypeLine($"Journal saved to {filename}.");
                    }
                    catch (Exception ex)
                    {
                        TypeLine($"Error saving journal: {ex.Message}");
                    }

                    break;

                case "5":
                    Type("Goodbye.");
                    break;

                default:
                    Type($"You entered: {response}. Please enter a value 1-5.");
                    break;

            }
        }

    }
}