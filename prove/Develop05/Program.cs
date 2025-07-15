using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goalBook = new List<Goal>();
        // fix public member variables and make accessor methods

        Menu(goalBook);
    }

    static void Menu(List<Goal> goalBook)
    {
        Console.Clear();

        int points = 0;
        foreach (Goal goal in goalBook)
        {
            if (goal.GetComplete() == true)
            { points += goal.GetPoints(); }
        } 

        string choice = "";
        while (choice != "1" && choice != "2" && choice != "3" && choice != "4")
        {
            Console.WriteLine($"You have {points} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select an option from the menu: ");

            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":

                    Console.WriteLine("Creating a new goal...");
                    goalBook.Add(Goal.NewGoal());
                    Menu(goalBook);
                    break;

                case "2":

                    Console.WriteLine("Listing goals...");
                    Console.Clear();
                    foreach (Goal goal in goalBook)
                    {
                        goal.Display();
                    }
                    Console.WriteLine("\nPress Enter to go back to the menu.");
                    Console.ReadLine();
                    Menu(goalBook);
                    break;

                case "3":

                    Console.WriteLine("Saving goals...");
                    SaveGoals(goalBook);
                    Menu(goalBook);
                    break;

                case "4":

                    Console.WriteLine("Loading goals...");
                    LoadInGoalsFromFile("myFile.txt", goalBook);
                    Menu(goalBook);
                    break;

                case "5":

                    Console.WriteLine("Recording event...");
                    for (int i = 0; i < goalBook.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {goalBook[i].GetName()}");
                    }
                    Console.WriteLine("Which goal did you accomplish? ");
                    int goalNumber = int.Parse(Console.ReadLine());
                    goalBook[goalNumber - 1].SetComplete(true);
                    int Points = goalBook[goalNumber - 1].GetPoints();
                    Console.WriteLine($"Congratulations! You have earned {Points} points!");

                    Menu(goalBook);
                    break;

                case "6":

                    Console.WriteLine("Exiting the program...");
                    return; // Exit the loop and program

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }

    static void SaveGoals(List<Goal> goalBook)
    {
        string filename = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // You can add text to the file with the WriteLine method
            foreach (Goal goal in goalBook)
            {
                outputFile.WriteLine(goal.FormatForSave());
            }
        }
    }

    static void LoadInGoalsFromFile(string filename, List<Goal> goalBook)
    {
        string fileName = filename;
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("#");

            string goalType = parts[0];

            switch (goalType)
            {
                case "simple":

                    bool isComplete = bool.Parse(parts[1]);
                    string name = parts[2];
                    string description = parts[3];
                    int points = int.Parse(parts[4]);
                    Goal newGoal = new Goal(name, description, points, isComplete);
                    goalBook.Add(newGoal);
                    break;

                case "checklist":
                    isComplete = bool.Parse(parts[1]);
                    name = parts[2];
                    description = parts[2];
                    points = int.Parse(parts[3]);
                    int completions = int.Parse(parts[4]);
                    int occurencesForBonusPoints = int.Parse(parts[5]);
                    int bonusPoints = int.Parse(parts[6]);
                    ChecklistGoal newChecklistGoal = new ChecklistGoal(name, description, points, occurencesForBonusPoints, bonusPoints, completions, isComplete);
                    goalBook.Add(newChecklistGoal);
                    break;

                case "eternal":
                    name = parts[2];
                    description = parts[2];
                    points = int.Parse(parts[3]);
                    EternalGoal newEternalGoal = new EternalGoal(name, description, points);
                    goalBook.Add(newEternalGoal);
                    break;

                default:
                    break;

            }

        }
    }



}