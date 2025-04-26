using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string user_Input = Console.ReadLine();
        float percentage = float.Parse(user_Input);
        string letter = string.Empty;
        string sign = string.Empty;

        if (percentage < 60)
        {
            letter = "F";
        }
        else if (percentage < 70)
        {
            letter = "D";
        }
        else if (percentage < 80)
        {
            letter = "C";
        }
        else if (percentage < 90)
        {
            letter = "B";
        }
        else if (percentage >= 90)
        {
            letter = "A";
        }
        if (percentage >= 70)
        {
            Console.WriteLine("Great Job! You passed!");
        }
        else
        {
            Console.WriteLine("You did not pass. Keep trying.");
        }
        if (percentage / 10 >= 7 && letter != "A")
        {
            sign = "+";
        }
        if (percentage / 10 < 3)
        {
            sign = "-";
        }
        if (letter == "F")
        {
            sign = "";
        }
        Console.WriteLine($"Your grade: {letter}{sign}");

    }
}