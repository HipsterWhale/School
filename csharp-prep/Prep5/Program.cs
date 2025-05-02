using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {Console.WriteLine("Welcome to the Program!");}

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            return Console.ReadLine();
        }
        
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            return int.Parse(Console.ReadLine());
        }

        static int SquareNumber(int val)
        {return val * val;}

        static void DisplayResult(string name, int square)
        {Console.Write($"{name}, the square of your number is {square}");}

        DisplayWelcome();
        DisplayResult(PromptUserName(), SquareNumber(PromptUserNumber()));
    }
}